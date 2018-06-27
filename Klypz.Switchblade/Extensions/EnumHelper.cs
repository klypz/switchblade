using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Klypz.Switchblade.Extensions
{
    public class EnumHelper
    {
        public static bool TryParseValue<TKey, TEnum>(TKey value, out TEnum? result)
            where TEnum : struct
            where TKey : struct
        {
            var _result = Enum.ToObject(typeof(TEnum), value);

            if (!Enum.IsDefined(typeof(TEnum), _result))
            {
                result = (TEnum)_result;
                return false;
            }
            else
            {
                result = (TEnum)_result;
                return true;
            }
        }

        public static string GetDescription(Enum @enum)
        {
            if (@enum == null)
            {
                throw new ArgumentNullException(nameof(@enum));
            }

            if (!Enum.IsDefined(@enum.GetType(), @enum))
            {
                return "";
            }
            else
            {
                var field = @enum.GetType().GetFields().First(p => p.GetValue(@enum).Equals(@enum));

                var desc = (EnumDescriptionAttribute)field.GetCustomAttributes(typeof(EnumDescriptionAttribute), true).FirstOrDefault();

                return desc?.Description;
            }
        }
    }
}

