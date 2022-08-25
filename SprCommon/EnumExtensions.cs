using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprCommon
{
    public static class EnumExtensions
    {
        /// <summary>
        /// enumに適用されている属性を取得
        /// </summary>
        /// <typeparam name="TAttribute"></typeparam>
        /// <param name="value"></param>
        /// <returns></returns>
        public static IEnumerable<TAttribute> GetApplied<TAttribute>(this Enum value) where TAttribute : Attribute
        {
            return value
                .GetType()
                .GetField(value.ToString())
                .GetCustomAttributes(false)
                .OfType<TAttribute>();
        }
    }
}
