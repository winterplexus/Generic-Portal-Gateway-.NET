//
//  UsersLog.cs
//
//  Wiregrass Code Technology 2017
//
using System;
using System.Globalization;
using NLog;

[assembly: CLSCompliant(true)]

namespace PortalGateway.Log
{
    public static class UsersLog
    {
        public static void WriteActivity(string message)
        {
            var logger = LogManager.GetLogger("Users");
            logger.Info(CultureInfo.InvariantCulture, message);
        }
    }
}