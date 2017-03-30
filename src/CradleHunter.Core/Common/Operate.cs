using System;
using System.Collections.Generic;
using System.Text;

namespace CradleHunter.Core
{
    public abstract class Operate<C> : IOperate<C> where C: IContext
    {
        public C Context { get; set; }

        public StatusResult Result { get { return Context.Result; } }

        public Operate(C context)
        {
            Context = context;
        }

        protected void TryCatch(string Message, Action TaskExcute, Action ExceptionCatch = null)
        {
            TryCatch(Message, () =>
            {
                TaskExcute();
                return Result;
            }, ExceptionCatch);
        }

        protected void TryCatch(string Message, Func<StatusResult> TaskExcute,Action ExceptionCatch = null)
        {
            try
            {
                if (Result.Succeeded) TaskExcute();
            }
            catch (Exception ex)
            {
                ExceptionCatch?.Invoke();
                ServiceManager.ExceptionProvider.Catch(ex);
                Result.AddError($" {Message}, throw Exception：{ex.Message}");
            }
        }

     
    }

   
}
