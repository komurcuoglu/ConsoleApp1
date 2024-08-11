using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
    internal class DortIslem
    {
        public void Topla(int a,int b)
        {
            int toplam = a + b;
            Console.WriteLine(toplam);
        }
        public void Cikar(int a,int b)
        {
            Console.WriteLine(a-b);
        }
        public void Bolme(int a,int b)
        {
            Console.WriteLine(a/b);
        }
    }
}
