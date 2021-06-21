using System;
using System.Collections.Generic;
using System.Text;

namespace FlagControl
{
    public static class EnumExtensions
    {
        /// <summary>Returns the value of the DescriptionAttribute associated with the enum value,
        /// or the results of value.ToString() if it has no DescriptionAttribute.
        /// </summary>
        public static string GetDescription(this System.Enum value)
        {
            System.Reflection.FieldInfo fieldInfo = value.GetType().GetField(value.ToString());
            if (fieldInfo == null)
                return value.ToString();
            object[] attribArray = fieldInfo.GetCustomAttributes(typeof(System.ComponentModel.DescriptionAttribute), false);
            if (attribArray.Length == 0)
                return value.ToString();
            else
                return ((System.ComponentModel.DescriptionAttribute)attribArray[0]).Description;
        }
    }
}