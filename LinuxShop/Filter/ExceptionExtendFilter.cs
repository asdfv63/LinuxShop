using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using log4net;
using Microsoft.AspNetCore.Mvc.Filters;

namespace LinuxShop.Filter
{
    public class ExceptionExtendFilter : IExceptionFilter
    {
        private ILog log = LogManager.GetLogger(Startup.repository.Name, typeof(ExceptionExtendFilter));
        void IExceptionFilter.OnException(ExceptionContext context)
        {
            log.Info(context.Result.ToString());
        }
    }
}
