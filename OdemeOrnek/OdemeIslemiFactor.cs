using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdemeOrnek
{
    public class OdemeIslemiFactor
    {
        public IOdemeTipi GetInstance(string className)
        {
            var newClass = System.Reflection.Assembly.GetAssembly(typeof(IOdemeTipi))
                .CreateInstance("OdemeOrnek." + className);


            return (IOdemeTipi)newClass;
                
        }

    }
}
