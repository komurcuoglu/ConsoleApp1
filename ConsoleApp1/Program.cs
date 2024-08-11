using ConsoleApp1;
using System;
using System.ComponentModel;


class Program
{
    static void Main(string[] args)
    {
        Product product = new Product();
        product.İsim = "Mehmet";
        product.Açıklama = "AÇıklama";
        product.Fiyat = 15;
        product.X = "100";
        Manager manager = new Manager();

        Product sil = new Product();
        sil.Açıklama = "a";
        sil.X = "a";
        sil.İsim = "a";
        sil.Fiyat = 15;
        manager.Sil(sil);
      

        /*
        manager.Delete(product);
        //Encapsulation
        manager.Ekle("Mehmet", 15, "Açıklama","asd");
        */
        
    }
}


