namespace ntp_3
{
    internal class Program
    {
        //static void Main(string[] args)
        //  {
        //Console.Write("bir sayı giriniz:");
        //int sayi = Convert.ToInt32(Console.ReadLine());

        //static int rakamlarinToplami(int sayi)
        //{
        //    int gecici = sayi;
        //    int toplam = 0;

        //    while (gecici != 0)
        //    {
        //        int rakam = gecici % 10;
        //        toplam += rakam;
        //        gecici = gecici / 10;
        //    }
        //    return toplam;
        //   }
        //Console.WriteLine(sayi + "rakamları toplamı:" + rakamlarinToplami(sayi));

        // Celcius u Fahrenneit a çeviren program 

        //Console.Write( "Fahreneit değerini giriniz");
        //double sayi1=Convert.ToDouble(Console.ReadLine());

        //Console.WriteLine(fah2cel(sayi1)); 

        //static double fah2cel(double sayi)
        //{
        //    // return (5 / 9) * (sayi - 32);  int/int=int verir. hatalı 
        //    // return 5 / 9 * sayi - 32; işlem önceliği yanlış - mantıksal hata
        //    return (5.0 / 9) * (sayi - 32);
        //}
        //Console.ReadLine();

        //Console.Write("Celcius değerini giriniz");
        //double sayi2 = Convert.ToDouble(Console.ReadLine());

        //Console.WriteLine(cel2fah(sayi2));

        //static double cel2fah(double sayi)
        //   {
        // return (5 / 9) * (sayi +32);  int/int=int verir. hatalı 
        // return 5 / 9 * sayi +32; işlem önceliği yanlış - mantıksal hata
        //    return (9/5.0) * (sayi + 32);
        //}
        //Console.ReadLine();

        ////Mükemmel sayı 
        //Console.Write("Bir sayı giriniz"); 
        //int sayi =Convert.ToInt32(Console.ReadLine());
        //int toplam = 0; 

        //for (int i=1; i<sayi; i++)
        //{
        //    if (sayi%i==0)
        //    {
        //        toplam += i;
        //    }
        //}
        //if (toplam==sayi)
        //{
        //    Console.WriteLine( "Girilen sayı mükemmel sayıdır."); 

        //}
        //else
        //{
        //    Console.WriteLine("Girilen sayı mükemmel sayı değildir.");
        //}
        //Console.ReadLine();

        //ARRAYS

        //string[] cars0 = new string[4];
        //string[] cars1 = new string[4] {"volvo" , "ford", "bmw" , "skoda};
        //string[] cars2 = new string[]  {"volvo", "ford", "bmw", "skoda"}; 
        //string[] cars3= {"volvo", "ford", "bmw", "skoda"};

        //    string[] cars4;
        //    cars4=new string[] {"volvo", "ford", "bmw", "skoda"};
        //cars4={"volvo", "ford", "bmw", "skoda"}; ----> hatalı kod  

        //int[] sayilar = { 10, 20, 30, 40 };
        //Console.WriteLine(sayilar[0]); ---->10 

        //sayilar[0]=100;
        //    Console.WriteLine(sayilar[0]); ----> 100 

        //sayilar[4] = 100;  //hatalı
        //Console.WriteLine(sayilar[4]);  // hatalı

//        int[] dizi = new int[10];
//for (int i = 0; i< 10; i++)
//{
//    dizi[i] = i;
//    Console.WriteLine("dizi[" + i + "]: " + dizi[i]);
//}

//    int[] dizi = new int[10];
//    int toplam = 0;
//for (int i = 0; i< 10; i++)
//{
//    dizi[i] = i* 10;
//    Console.WriteLine("dizi[" + i + "]: " + dizi[i]);
//    toplam += dizi[i];
//}
//Console.WriteLine("Toplam: " + toplam);

//string[] cars = { "volvo", "bmw", "ford", "skoda" };
//foreach (string car in cars)
//{
//    Console.WriteLine(car);
//}

//Array.Sort(cars);
//foreach (string car in cars)
//{
//    Console.WriteLine(car);
//}

//int[] sayilar = { 10, 20, 30, 5, 89, 48, 63, 7 };
//Array.Sort(sayilar);
//foreach (int i in sayilar)
//{
//    Console.WriteLine(i);
//}
//Console.WriteLine("");
//Console.WriteLine(sayilar.Max());
//Console.WriteLine(sayilar.Min());
//Console.WriteLine(sayilar.Sum());
//Console.WriteLine(sayilar.Count());


////Çok boyutlu diziler

//int[,] sayilar = { { 1, 4, 2 }, { 3, 5, 6 } };
//Console.WriteLine(sayilar[0, 2]);

//sayilar[0, 0] = 5;
//Console.WriteLine(sayilar[0, 0]);

//foreach (int i in sayilar)
//{
//    Console.WriteLine(i);
//}



////Değişkenler ve Dizi Elemanları

//int x = 1;
//int[] y = new int[2];
//string z = "zeynep";

//Console.WriteLine("metotdan önce ");
//Console.WriteLine("x in değeri: " + x);
//Console.WriteLine("y dizisinin elemanı: " + y[0]);
//Console.WriteLine("z nin değeri: " + z);
//metot(x, y, z);
//Console.WriteLine("metotdan sonra ");
//Console.WriteLine("x in değeri: " + x);
//Console.WriteLine("y dizisinin elemanı: " + y[0]);
//Console.WriteLine("z nin değeri: " + z);

//static void metot(int x, int[] y, string z)
//{
//    x = 100;
//    y[0] = 100;
//    z = "ZEYNEP";

//    Console.WriteLine("metodun içinde ");
//    Console.WriteLine("x in değeri: " + x);
//    Console.WriteLine("y dizisinin elemanı: " + y[0]);
//    Console.WriteLine("z nin değeri: " + z);
//}


//Console.ReadLine();



        }
    }
}