using log4net;
using log4net.Config;

namespace PM3
{
    public static class Logger
    {
        private static readonly ILog log = LogManager.GetLogger("LOGGER");
        private static readonly ILog errorLog = LogManager.GetLogger("ERROR_LOGGER");

        public static ILog Log => log;
        public static ILog ErrorLog => errorLog;

        public static void InitLogger()
        {
            XmlConfigurator.Configure();
        }
    }
}
