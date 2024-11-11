using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Method2 method2 = new Method2();
           Method3 method3 = new Method3();
           InfoMethod ınfoMethod = new InfoMethod();
            Console.ReadLine();
            
        }
    }
    public class Method2
    {
        public Method2()
        {
           DortIslem dortIslem = new DortIslem(2, 9);
            Console.WriteLine(dortIslem.Carp2());
            Console.WriteLine(dortIslem.Carp(10,2));
        }
    }
    public class Method3
    {
        public Method3()
        {
            var type = typeof(DortIslem);
            DortIslem dortIslem = (DortIslem)Activator.CreateInstance(type,10,3);
             Console.WriteLine(dortIslem.Carp(10,2));
            Console.WriteLine(dortIslem.Topla2());
        }
    }
    public class InfoMethod
    {
       
        public InfoMethod()
        {
            DortIslem dortIslem = new DortIslem();
            var type = typeof(DortIslem);
            var instance = Activator.CreateInstance(type, 5, 2);

            MethodInfo methodInfo = instance.GetType().GetMethod("Carp2");
            Console.WriteLine(methodInfo.Invoke(instance, null));

            Console.ReadLine();

        }
       
        
    }
    public class DortIslem
    {
      
        private int _sayi1;
        private int _sayi2;

        public DortIslem(int sayi1, int sayi2)
        {
            _sayi1 = sayi1;
            _sayi2 = sayi2;
            
        }
        public DortIslem()
        {
            
        }
        public int Topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;

        }
        public int Carp (int sayi1,int sayi2)
        {
            return sayi1 * sayi2;

        }
        public int Topla2()
        {
            return _sayi1 + _sayi2;       
        }
        public int Carp2()
        {
            return _sayi1 * _sayi2;

        }
    }
}
