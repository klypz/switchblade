namespace Klypz.Switchblade.Calc.Financial
{
    /// <summary>
    /// Período de aplicação de Taxa
    /// </summary>
    public enum RatePeriod
    {
        /// <summary>
        /// Anual
        /// </summary>
        PerYear = 360,
        /// <summary>
        /// Semestral
        /// </summary>
        PerHalfYear = 180,
        /// <summary>
        /// Trimestral
        /// </summary>
        PerQuarterYear = 90,
        /// <summary>
        /// Mensal
        /// </summary>
        PerMonth = 30,
        /// <summary>
        /// Quinzenal
        /// </summary>
        PerHalfMonth = 15,
        /// <summary>
        /// Semanal
        /// </summary>
        PerWeek = 7,
        /// <summary>
        /// Diária
        /// </summary>
        PerDay = 1
    }
}
