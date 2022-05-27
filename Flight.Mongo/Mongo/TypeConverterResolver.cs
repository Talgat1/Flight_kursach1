using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Flight.Mongo.Mongo
{
    internal static class TypeConverterResolver
    {
        internal static void RegisterTypeConverter<T, TC>() where TC : TypeConverter
        {
            Attribute[] attr = new Attribute[1];
            TypeConverterAttribute vConv = new TypeConverterAttribute(typeof(TC));
            attr[0] = vConv;
            TypeDescriptor.AddAttributes(typeof(T), attr);
        }
    }
}
