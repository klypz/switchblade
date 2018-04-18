using System;

namespace Klypz.Switchblade.Extensions
{
    /// <summary>
    /// Extensão de funcionalidades da classe [DateTime] 
    /// </summary>
    public static class DateTimeExtension
    {
        private static readonly DateTime UnixEpoch = new DateTime(1970, 1, 1);

        /// <example>
        /// <code>
        ///     DateTime date = new DateTime(2015, 1, 1);
        ///     Console.WriteLine(date.ToUnixTime());
        ///     //retorno 1420070400000
        /// </code>
        /// </example>
        /// <summary>
        /// <para>Converte de DateTime para UnixTime</para>
        /// <para>O Unix time são os milisegundos contados a partir do dia 01/01/1970 00:00:00.000 UTC</para>
        /// </summary>
        /// <param name="dateTime">Data a ser convertida</param>
        /// <returns>Número compatível com UnixTime</returns>
        public static long ToUnixTime(this DateTime dateTime)
        {
            return (dateTime - UnixEpoch).Ticks / TimeSpan.TicksPerMillisecond;
        }

        /// <summary>
        /// <para>Converte de UnixTime (long) para DateTime.</para>
        /// <para>O Unix time são os milisegundos contados a partir do dia 01/01/1970 00:00:00.000 UTC</para>
        /// </summary>
        /// <example>
        /// <code>
        ///     DateTime date = DateTimeExtension.FromUnixTime(1420070400000);
        ///     Console.WriteLine(date.ToString("yyyy-MM-dd"));
        ///     //retorno 2015-01-01
        /// </code>
        /// </example>
        /// <param name="timeUnix">UnixTime (long)</param>
        /// <returns>DateTime a partir de um UnixTime (long)</returns>
        public static DateTime FromUnixTime(long timeUnix)
        {
            return UnixEpoch.AddMilliseconds(timeUnix);
        }
    }
}
