using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Manager
    {
        /*
        public void Delete(Product product)
        {
            Console.WriteLine("Silinme işlemi tamamlandı... Silinen öğe:"+product.İsim);
            Console.WriteLine("Sıra sıra ögeler:"+product.Açıklama+product.X+product.İsim+product.Fiyat);
            
        }
        */
        public void Sil(Product sil)
        {
            Console.WriteLine("Sıra sıra ögeler:" + sil.Açıklama + sil.X + sil.İsim + sil.Fiyat);
        }
        /*
        public void Ekle(string İsim,int Fiyat,string Açıklama,String X) {
            Console.WriteLine("İsim, Fiyat, Açıklama,X:"+İsim+ Fiyat+ Açıklama+X);
        }

        public void Düzenle(string İsim,int Fiyat,String Açıklama,String X)
        {
            Console.WriteLine("İsim, Fiyat, Açıklama,X:" + İsim + Fiyat + Açıklama+X);
        }
        */
    }
}
