using log4net;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skeleton.Logger
{
    public class Logger<T> : Logger
    {
        public Logger()
        {
            _logger = LogManager.GetLogger(typeof(T));
        }
    }

    public class Logger : ILogger
    {
        protected ILog _logger;

        #region Singleton Methods and Fields

        static Logger()
        {
            log4net.Config.XmlConfigurator.Configure();
        }

        /// <summary>
        /// Gets the logger using the stack frame to get the appropriate name
        /// </summary>
        /// <returns></returns>
        public static Logger GetLogger()
        {
            string loggerName;
            Type declaringType;
            int framesToSkip = 1;
            do
            {
                StackFrame frame = new StackFrame(framesToSkip, false);

                var method = frame.GetMethod();
                declaringType = method.DeclaringType;
                if (declaringType == null)
                {
                    loggerName = method.Name;
                    break;
                }
                framesToSkip++;
                loggerName = declaringType.FullName;
            } while (declaringType.Module.Name.Equals("mscorlib.dll", StringComparison.OrdinalIgnoreCase));

            return new Logger(LogManager.GetLogger(loggerName));
        }

        //UnComment the following code if we need independent Instance of Logger Class

        //private static readonly Logger _instance = Logger.GetLogger();
        //public static Logger Instance
        //{
        //    get
        //    {
        //        return _instance;
        //    }
        //}

        #endregion Singleton Methods and Fields

        #region Constructor: Different ways of creating Logger Class

        public Logger() { }

        public Logger(ILog logger)
        {
            _logger = logger;
        }

        public Logger(string loggerName)
        {
            _logger = LogManager.GetLogger(loggerName);
        }

        public Logger(Type logClass)
        {
            _logger = LogManager.GetLogger(logClass);
        }

        #endregion

        #region Logging Methods

        public void LogInfo(string message)
        {
            try
            {
                _logger.Info(message);
            }
            catch
            {
                //Ignore
            }
        }

        public void LogWarning(string message)
        {
            try
            {
                _logger.Warn(message);
            }
            catch
            {
                //Ignore
            }

        }

        public void LogDebug(string message)
        {
            try
            {
                _logger.Debug(message);
            }
            catch
            {
                //Ignore
            }
        }

        public void LogError(string message)
        {
            try
            {
                //Manual configuration
                //log4net.LogicalThreadContext.Properties["IsEmailSent"] = 0;
                
                _logger.Error(message);
            }
            catch
            {
                //Ignore
            }
        }

        public void LogError(Exception ex)
        {
            try
            {
                LogError(BuildExceptionMessage(ex));
            }
            catch
            {
                //Ignore
            }
        }

        public void LogError(string message, Exception ex)
        {
            try
            {
                _logger.Error(message, ex);
            }
            catch
            {
                //Ignore
            }
        }

        public void LogFatal(string message)
        {
            try
            {
                _logger.Fatal(message);
            }
            catch
            {
                //Ignore
            }
        }

        public void LogFatal(Exception ex) 
        {
            try
            {
                LogFatal(BuildExceptionMessage(ex));
            }
            catch
            {
                //Ignore
            }
        }

        public string BuildExceptionMessage(Exception ex)
        {
            string stackTrace = ex.StackTrace + " Inner Exception: " + ex.InnerException?.StackTrace;

            return string.Format("Message:{0}; Source:{1}; TargetSite:{2}, StackTrace:{3}; ",
                                  ex.Message, ex.Source, ex.TargetSite, stackTrace);
        }

        #endregion

    }
}
