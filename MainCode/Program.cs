using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Container;
namespace MainCode
{
    class Program
    {
        static void Main(string[] args)
        {
            DIC dc = new DIC();

            dc.Register<ISomeIntrface, SomeClassRealization>();
            dc.Register<MyAbstractClass, UsefullClass>();

            Console.WriteLine(dc.Resolve<ISomeIntrface>().IsDoingNothingMethod());
            Console.WriteLine(dc.Resolve<MyAbstractClass>().UselessMethod());
            //dc.Register<ISomeIntrface, UsefullClass>();
            //dc.Register<SomeClassRealization, MyAbstractClass>();
            //Console.WriteLine(dc.Resolve<MyAbstractClass>().UselessMethod());
        }
    }
    public interface ISomeIntrface
    {
        bool IsDoingNothingMethod();
    }
    public class SomeClassRealization : ISomeIntrface
    {
        public bool IsDoingNothingMethod()
        {
            return true;
        }
    }
    public abstract class MyAbstractClass
    {
        public abstract bool UselessMethod();

    }
    public class UsefullClass : MyAbstractClass
    {
        public override bool UselessMethod()
        {
            return false;
        }
    }
}
