using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Container
{
    public class InvalideAbstractionType : Exception
    {
        public override string Message => "Parameter is either Interface or Abstract class";
    }
    public class DIC
    {
        public IDictionary<Type,Type> TypesStorege { get; private set; }
        public DIC()
        {
            TypesStorege = new Dictionary< Type, Type>();
        }
        public void Register<T1, T2>()
        {
            var type1 = typeof(T1);
            var type2 = typeof(T2);
            if(type2.IsAbstract || type2.IsInterface)
            {
                throw new InvalideAbstractionType();
            }

            if(type1.IsInterface && !type1.IsAbstract)
            {
                throw new InvalideAbstractionType();
            }

        }
    }
}
