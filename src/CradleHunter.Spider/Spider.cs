using CradleHunter.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CradleHunter.Spider
{
    /// <summary>
    /// 爬取深度 
    /// </summary>
    public enum CrawlerDeep
    {
        ALL = -1,
        Level = 0,
    }

    /// <summary>
    /// 爬取结果
    /// </summary>
    public enum CrawlerResult
    {
        Down,
        Analysis,
        DownAnalysis,
    }

    /// <summary>
    /// 爬取范围
    /// </summary>
    public enum CrawlerExtent
    {
       Html,
       Image,
       Content,
    }

    /// <summary>
    /// 蜘蛛上下文
    /// </summary>
    public class SpiderContext: IContext
    {
        public StatusResult Result { get; set; } = new StatusResult();

        public string Address { get; private set; }

        public string Template { get; private set; }

        public SpiderContext(string taskAddress,string taskTemplate)
        {
            Address = taskAddress;
            Template = taskTemplate;
        }
    }

    /// <summary>
    /// 蜘蛛人
    /// </summary>
    public class SpiderOperater : Operate<SpiderContext>
    {
        /// <summary>
        /// 任务名称
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// 调度器
        /// </summary>
        public IScheduler Scheduler { get; private set; }

        /// <summary>
        /// 监视器
        /// </summary>
        public IMonitor Monitor { get; private set; }

        /// <summary>
        /// 爬行器
        /// </summary>
        private SpiderLimb Limbs { get;  set; }

        /// <summary>
        /// 分析器
        /// </summary>
        private SpiderHead Head { get;  set; }

        /// <summary>
        /// 构造函数
        /// </summary>
        public SpiderOperater (IScheduler scheduler,string name,SpiderContext context):base(context)
        {
            Scheduler = scheduler;
            Name = name;
            Init();
        }
       
        /// <summary>
        /// 启动执行
        /// </summary>
        public void Start()
        {
            Execute();
        }

        /// <summary>
        /// 初始化
        /// </summary>
        private void Init()
        {
            Limbs = new SpiderLimb(this);

            Head = new SpiderHead(this);

            Monitor = ServiceManager.CreateMonitor();

        }

        /// <summary>
        /// 执行
        /// </summary>
        private void Execute()
        {
            TryCatch($"{Name} Spider Execute", async () =>
            {
                if (Result.Succeeded) await Limbs.Fetch();

                if (Result.Succeeded) await Head.Analysis();

            }, ()=>{
                Scheduler.Fail(Result);

            });
        }
    }

   
    /// <summary>
    /// 蜘蛛 爬行器  Execute to fetch
    /// </summary>
    public class SpiderLimb
    {
        public SpiderContext Context { get { return Owner.Context; } }

        public SpiderOperater  Owner { get; private set; }

        public SpiderLimb(SpiderOperater  owner) { Owner = owner; }
        
        private WaitOrTimerCallback TimeoutCallback { get; set; } = (state, timedOut) => { };

        public async Task Fetch()
        {
            HttpClientHandler handler = new HttpClientHandler();
            handler.UseDefaultCredentials = true;
            HttpClient Client = new HttpClient(handler);

            try
            {
                var fetchResult = Client.GetAsync(new Uri(Context.Address));
                fetchResult.Wait();
                var result =  fetchResult.Result;
                var fetchContent= result.Content.ReadAsStringAsync();
                fetchContent.Wait();
                var content = fetchContent.Result;
                var file = $"{AppContext.BaseDirectory}\\downhtml\\{Context.Address.Replace("\\", string.Empty).Replace("/", string.Empty).Replace(":", string.Empty)}-{DateTime.Now.ToString("yyyy-MM-dd-hh-mm-ss.fff")}.html";
                File.WriteAllText(file, content);
            }
            catch (Exception ex)
            {
                Context.Result.AddError(ex.Message);
            }
        }
      
    }



    /// <summary>
    /// 蜘蛛 分析器 Analysis
    /// </summary>
    public class SpiderHead
    {
        public SpiderOperater  Owner { get; private set; }
        public SpiderHead(SpiderOperater  owner) { Owner = owner; }
        public async Task Analysis()
        {

        }
    }

   

}
