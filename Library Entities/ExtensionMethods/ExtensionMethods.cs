using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Entities
{
    public static class ExtensionMethods
    {
        //property list generation for generalized ToString overriding
        //see: http://stackoverflow.com/questions/4023462/how-do-i-automatically-display-all-properties-of-a-class-and-their-values-in-a-s
        public static string Properties(this object obj)
        {
            var properties = obj.GetType().GetProperties();
            var stringBuilder = new StringBuilder();

            foreach (var property in properties)
            {
                stringBuilder.AppendLine(property.Name + ": " + property.GetValue(obj, null));
            }

            return stringBuilder.ToString();
        }
    }
}
