using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;

namespace CradleHunter.Core
{

    /// <summary>
    /// 服务
    /// </summary>
    public class ServiceManager
    {

        private static IServiceCollection _services;
        private static IServiceProvider _serviceProvider;
        private static readonly ServiceManager Container = new ServiceManager();

        public static void Reset(IServiceCollection services)
        {
            _services = services;
            _serviceProvider = _services.BuildServiceProvider();

        }

        static ServiceManager() {
            _services = new ServiceCollection();
            _serviceProvider = _services.BuildServiceProvider();

        }

        public static ICatchException ExceptionProvider { get; private set; }

        public static Func<IMonitor> CreateMonitor {
            get {
               return ()=>GetRequiredService<IMonitor>();

            }
        }

        #region IOC

        public static void AddTransient(Type serviceType, Type implementationType)
        {
            _serviceProvider = _services.AddTransient(serviceType, implementationType).BuildServiceProvider();
        }

        public static void AddTransient(Type serviceType, Func<IServiceProvider, object> implementationFactory)
        {
            _serviceProvider = _services.AddTransient(serviceType, implementationFactory).BuildServiceProvider();
        }

        public static void AddTransient<TService, TImplementation>()
            where TService : class where TImplementation : class, TService
        {
            _serviceProvider = _services.AddTransient<TService, TImplementation>().BuildServiceProvider();
        }

        public static void AddTransient(Type serviceType)
        {
            _serviceProvider = _services.AddTransient(serviceType).BuildServiceProvider();
        }

        public static void AddTransient<TService>() where TService : class
        {
            _serviceProvider = _services.AddTransient<TService>().BuildServiceProvider();
        }

        public static void AddTransient<TService>(Func<IServiceProvider, TService> implementationFactory)
            where TService : class
        {
            _serviceProvider = _services.AddTransient(implementationFactory).BuildServiceProvider();
        }

        public static void AddTransient<TService, TImplementation>(Func<IServiceProvider, TImplementation> implementationFactory) where TService : class
            where TImplementation : class, TService
        {
            _serviceProvider = _services.AddTransient<TService, TImplementation>(implementationFactory).BuildServiceProvider();
        }

        public static void AddScoped(Type serviceType, Type implementationType)
        {
            _serviceProvider = _services.AddScoped(serviceType, implementationType).BuildServiceProvider();
        }

        public static void AddScoped(Type serviceType, Func<IServiceProvider, object> implementationFactory)
        {
            _serviceProvider = _services.AddScoped(serviceType, implementationFactory).BuildServiceProvider();
        }

        public static void AddScoped<TService, TImplementation>() where TService : class
            where TImplementation : class, TService
        {
            _serviceProvider = _services.AddScoped<TService, TImplementation>().BuildServiceProvider();
        }

        public static void AddScoped(Type serviceType)
        {
            _serviceProvider = _services.AddScoped(serviceType).BuildServiceProvider();
        }

        public static void AddScoped<TService>() where TService : class
        {
            _serviceProvider = _services.AddScoped<TService>().BuildServiceProvider();
        }

        public static void AddScoped<TService>(Func<IServiceProvider, TService> implementationFactory) where TService : class
        {
            _serviceProvider = _services.AddScoped(implementationFactory).BuildServiceProvider();
        }

        public static void AddScoped<TService, TImplementation>(Func<IServiceProvider, TImplementation> implementationFactory) where TService : class where TImplementation : class, TService
        {
            _serviceProvider = _services.AddScoped<TService, TImplementation>(implementationFactory).BuildServiceProvider();
        }

        public static void AddSingleton(Type serviceType, Type implementationType)
        {
            _serviceProvider = _services.AddSingleton(serviceType, implementationType).BuildServiceProvider();
        }

        public static void AddSingleton(Type serviceType, Func<IServiceProvider, object> implementationFactory)
        {
            _serviceProvider = _services.AddSingleton(serviceType, implementationFactory).BuildServiceProvider();
        }

        public static void AddSingleton<TService, TImplementation>() where TService : class where TImplementation : class, TService
        {
            _serviceProvider = _services.AddSingleton<TService, TImplementation>().BuildServiceProvider();
        }

        public static void AddSingleton(Type serviceType)
        {
            _serviceProvider = _services.AddSingleton(serviceType).BuildServiceProvider();
        }

        public void AddSingleton<TService>() where TService : class
        {
            _serviceProvider = _services.AddSingleton<TService>().BuildServiceProvider();
        }

        public static void AddSingleton<TService>(Func<IServiceProvider, TService> implementationFactory) where TService : class
        {
            _serviceProvider = _services.AddSingleton(implementationFactory).BuildServiceProvider();
        }

        public static void AddSingleton<TService, TImplementation>(Func<IServiceProvider, TImplementation> implementationFactory) where TService : class where TImplementation : class, TService
        {
            _serviceProvider = _services.AddSingleton<TService, TImplementation>(implementationFactory).BuildServiceProvider();
        }

        public static void AddSingleton(Type serviceType, object implementationInstance)
        {
            _serviceProvider = _services.AddSingleton(serviceType, implementationInstance).BuildServiceProvider();
        }

        public static void AddSingleton<TService>(TService implementationInstance) where TService : class
        {
            _serviceProvider = _services.AddSingleton(implementationInstance).BuildServiceProvider();
        }

        public static T GetService<T>()
        {
            return _serviceProvider.GetService<T>();
        }

        public static object GetRequiredService(Type serviceType)
        {
            return _serviceProvider.GetService(serviceType);
        }

        public static T GetRequiredService<T>()
        {
            return _serviceProvider.GetRequiredService<T>();
        }

        public static IEnumerable<T> GetServices<T>()
        {
            return _serviceProvider.GetServices<T>();
        }

        public static IEnumerable<object> GetServices(Type serviceType)
        {
            return _serviceProvider.GetServices(serviceType);
        }

        #endregion

    }
   
}
