using Core.CrossCuttingConcerns.Caching;
using Core.Ultities.Interceptors;
using Core.Utilities.IoC;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using Castle.DynamicProxy;

namespace Core.Aspects.Autofac.Caching
{
    public class CacheRemoveAspect :MethodInterception
    {
        private string _pattern;
        private ICacheManager _cacheManager;

        public CacheRemoveAspect(string pattern)
        {
            _pattern = pattern;
            _cacheManager = ServiceTool.ServiceProvider.GetService<ICacheManager>();

        }
        protected override void OnSuccess(IInvocation ınvocation)
        {
            _cacheManager.RemoveByPattern(_pattern);
        }

    }
}
