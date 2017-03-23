using CradleHunter.Core;
using System;
using System.Collections.Generic;

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

        public int LegCount { get; set; }

        public string Address { get; private set; }

        public string Template { get; private set; }

        public SpiderContext(int legs,string taskAddress,string taskTemplate)
        {
            LegCount = legs;
            Address = taskAddress;
            Template = taskTemplate;
        }
    }

    /// <summary>
    /// 蜘蛛人
    /// </summary>
    public class Spider: Operate<SpiderContext>
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
        public Spider(IScheduler scheduler,string name,SpiderContext context):base(context)
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
            Monitor = ServicesManager.CreateMonitor();
        }

        /// <summary>
        /// 执行
        /// </summary>
        private void Execute()
        {
            TryCatch($"{Name} Spider Execute", ()=> {
                if (Result.Succeeded) Limbs.Fetch();
                if (Result.Succeeded) Head.Analysis();
            },()=>{
                Scheduler.Fail(Result);
            });
        }
    }

    /// <summary>
    /// 蜘蛛 爬行器  Execute to fetch
    /// </summary>
    public class SpiderLimb
    {
        public Spider Owner { get; private set; }
        public SpiderLimb(Spider owner) { Owner = owner; }
        public void Fetch()
        {

        }
    }



    /// <summary>
    /// 蜘蛛 分析器 Analysis
    /// </summary>
    public class SpiderHead
    {
        public Spider Owner { get; private set; }
        public SpiderHead(Spider owner) { Owner = owner; }
        public void Analysis()
        {

        }
    }

   

}
