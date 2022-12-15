using System;


namespace odev_14
{
    class Program
    {
        static void Main(string[] args)
        {
            // String Kütüphanesi

            string degisken = "Dersimiz Csharp Hoşgeldiniz!";
            string degisken2 = "C sharp";
            // lenght
            Console.WriteLine(degisken.Length);
            //ToUpper ToLower 
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());

            // concat ekleme yapar
            Console.WriteLine(String.Concat(degisken,"Merhaba"));

            //Compare Compare to
            Console.WriteLine(degisken.CompareTo(degisken2)); //d==d2-->0 ; d>d2--->1 ; d<d2--->-1 döndürür 
            Console.WriteLine(String.Compare(degisken,degisken2,true));// büyük küçük harf duyarsız olur
            Console.WriteLine(String.Compare(degisken,degisken2,false));

            // Contains içeriyor mu
            Console.WriteLine(degisken.Contains(degisken2));
            Console.WriteLine(degisken.EndsWith("hoşgeldiniz !"));
            Console.WriteLine(degisken.StartsWith("Merhaba !"));

            //Index Of
            Console.WriteLine(degisken.IndexOf("CS"));// nerede içerdiğini söyler
            Console.WriteLine(degisken.IndexOf("Zikriye"));// yoksa -1 döner

            //Insert
            Console.WriteLine(degisken.Insert(0,"Merhaba! "));//0. indexten sonra ekler
            Console.WriteLine(degisken.LastIndexOf("i")); // son indexi getirir

            //PadLeft,PadRight;
            Console.WriteLine(degisken+degisken2.PadLeft(30));// 30'a kadar değişken2 ekle
            Console.WriteLine(degisken+degisken2.PadLeft(30,'*')); // 30'a kadar degisken2 ekle boşluklara * koy
            Console.WriteLine(degisken.PadRight(50,'-')+degisken2.PadLeft(30,'*'));

            //Remove
            Console.WriteLine(degisken.Remove(10));//10 karakter siler
            Console.WriteLine(degisken.Remove(5,3));//5.indexten başlayarak 3 karakter siler
            Console.WriteLine(degisken.Remove(0,1));

            //Replace
            Console.WriteLine(degisken.Replace("Csharp","C#"));//Değiştirir

            //Split boşluktan sonralarını dizi yapıp sıralar
            Console.WriteLine(degisken.Split(' ')[1]);

            //Substring
            Console.WriteLine(degisken.Substring(4));
            Console.WriteLine(degisken.Substring(4,6)); // 4. indexten 6 karakteri getirir


            Console.Read();
        }
    }
}
