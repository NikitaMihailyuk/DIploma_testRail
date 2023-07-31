using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace Core
{
    public class BaseService
    {
        protected BaseApiClient apiClient;
        protected static NLog.Logger logger = LogManager.GetCurrentClassLogger();
        public BaseService(string url)
        {
            this.apiClient = new BaseApiClient(url);
        }
    }
}
