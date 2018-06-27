using System;

namespace Klypz.Switchblade.Extensions
{
    [System.AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
    public sealed class EnumDescriptionAttribute : Attribute
    {
        internal string Description { get; }

        public EnumDescriptionAttribute(string description)
        {
            this.Description = description;
        }
    }
}

