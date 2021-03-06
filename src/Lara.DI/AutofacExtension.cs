﻿using Autofac.Core;
using Lara.DI.Helpers;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Lara.DI
{
    public static class AutofacExtension
    {
        public static IServiceProvider ToAutofacProvider(this IServiceCollection services, params IModule[] modules)
        {
            return AutofacHelper.BuildServiceProvider(services);
        }
    }
}