using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DortIslem dostIslem = new DortIslem(2, 3);
            //Console.WriteLine( dostIslem.Topla(3,4));
            //Console.WriteLine(dostIslem.Topla2());

            //Çalışma anında bilgileri elde etmek için kullanılır.Costu fazla old için zorunlu olmadığı takdirede kullanılmaz
            var tip = typeof(DortIslem);
            //DortIslem dortIslem = (DortIslem)Activator.CreateInstance(tip,7,8); // Çalışma anında Dinamik instance üretir.
            //Console.WriteLine( dortIslem.Topla(4, 6));
            //Console.WriteLine(dortIslem.Topla2());

            var instance = (DortIslem)Activator.CreateInstance(tip, 7, 8);
            //Console.WriteLine(instance.GetType().GetMethod("Topla2").Invoke(instance,null)); // GetMethot ile metota ulaşıyoruz ve Invoke ile çalıştırıyoruz
            // invoke içinde instance ı tekrar yazmalıyız kim için çalıştırıyoruz

            var metodlar = tip.GetMethods();

            foreach (var method in metodlar)
            {
                Console.WriteLine("Metot: {0}",method.Name);
                foreach (var parameter in method.GetParameters())
                {
                    Console.WriteLine("Parametre: {0}",parameter.Name);
                }
                foreach(var attribute in method.CustomAttributes)
                {
                    Console.WriteLine("Attribute: {0}", attribute.GetType().Name);
                }
            }
            
            
            Console.ReadLine();                                         
            

        }
    }
    public class DortIslem
    {
        private int _sayi1;
        private int _sayi2;
        public DortIslem(int sayi1,int sayi2)
        {
            _sayi1 = sayi1;
            _sayi2 = sayi2;
            
        }
        public DortIslem()
        {
            
        }
        public int Topla (int sayi1, int sayi2) 
        {
            return (sayi1 + sayi2); 
        }
        public int Carp(int sayi1, int sayi2)
        {
            return (sayi1 * sayi2);
        }
        public int Topla2()
        {
            return (_sayi1 + _sayi2);
        }
        public int Car2()
        {
            return (_sayi1 * _sayi2);
        }
    }
}
