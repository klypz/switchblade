using System;

namespace Klypz.Switchblade.Basic
{
    public static class DateTimeExtension
    {
        private static readonly DateTime UnixEpoch = new DateTime(1970, 1, 1);

        /// <summary>
        /// Converte de DateTime para UnixTime
        /// </summary>
        /// <param name="dateTime">Data a ser convertida</param>
        /// <returns>Número compatível com UnixTime</returns>
        public static long ToUnixTime(this DateTime dateTime)
        {
            return (dateTime - UnixEpoch).Ticks / TimeSpan.TicksPerMillisecond;
        }

        /// <summary>
        /// Converte de UnixTime para DateTime
        /// </summary>
        /// <param name="timeUnix">Número compativel com UnixTime</param>
        /// <returns>DateTime a partir de numeração UnixTime</returns>
        public static DateTime FromUnixTime(this long timeUnix)
        {
            return UnixEpoch.AddMilliseconds(timeUnix).ToLocalTime();
        }
    }
}
