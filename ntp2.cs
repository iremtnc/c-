using System.Security.Cryptography;

namespace ntp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Lütfen isminizi giriniz:");
            //string isim = Console.ReadLine();

            //Console.WriteLine("Hoş geldiniz" + isim);
            //Console.ReadKey();

            // comment kısayol tuşu = ctrl + k + c 
            // uncomment kısayol tuşu = ctrl + k + u 

            // /* */ birden çok satırı yorum satırı yapar 

            // İki sayı arasındaki sayıların toplamı 
            //int toplam = 0;
            //for (int i = 0; i < 10; i++)
            //{
            //    toplam += i;
            //    toplam=toplam+i;
            //}
            //Console.WriteLine("Sayıların toplamı=" + toplam);
            //cv + tab + tab 
            //Console.ReadKey();
            // ctrl + k + d  = dizayn 

            //Toplam Metodu 

            //static int toplamMetodu(int sayi1, int sayi2)
            //{
            //    int toplam = 0;
            //    for (int i = sayi1; i < sayi2; i++)
            //    {
            //        toplam += i;
            //    }
            //    return toplam;
            //}
            //int toplamSonuc = toplamMetodu(10, 20);
            //Console.WriteLine("10dan 20ye kadar olan sayıların toplamı:" + toplamSonuc);
            //Console.ReadKey();

            // Çarpım Metodu 

            //static int carpimMetodu(int sayi1, int sayi2)
            //{
            //    int carpim = sayi1 * sayi2;
            //    return carpim;
            //}
            //Console.WriteLine("Sonuc:" + carpimMetodu(5, 23));
            //Console.ReadKey();


            //En büyük sayıyı bulma 

            //static int max(int sayi1, int sayi2)
            //{
            //    int sonuc;
            //    if (sayi1 > sayi2)
            //    {
            //        sonuc = sayi1;
            //    }
            //    else
            //    {
            //        sonuc = sayi2;
            //    }
            //    return sonuc;
            //}
            //int i = 5;
            //int j = 10;
            //int k = max(i, j);
            //Console.WriteLine(i + "ile" + j + "den büyük olanı" + k + "dır");
            //Console.ReadKey();

            // Not harfini bulma metodu 

            //static void notYazdir(double ort)
            //{
            //    if (ort >= 90)
            //    {
            //        Console.WriteLine("A");
            //    }
            //    else if (ort >= 80)
            //    {
            //        Console.WriteLine("B");
            //    }
            //    else if (ort >= 70)
            //    {
            //        Console.WriteLine("C");
            //    }

            //    else if (ort >= 60)
            //    {
            //        Console.WriteLine("D");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Seneye görüşürüz");
            //    }
            //    Console.WriteLine("Not ortalamınızı giriniz:");
            //    double ortalama = Convert.ToDouble(Console.ReadLine());
            //    notYazdir(ortalama);
            //    Console.ReadKey();

                //Not harfini bulan metod- char 

                //static char notYazdir(double ort)
                //{
                //    if (ort >= 90)
                //    {
                //        return 'A';
                //    }
                //    else if (ort >= 80)
                //    {
                //        return 'B';
                //    }
                //    else if (ort >= 70)
                //    {
                //        return 'C';
                //    }
                //    else if (ort >= 60)
                //    {
                //        return 'D';
                //    }
                //    else
                //    {
                //        return 'F';
                //    }
                //}
                //Console.WriteLine("Not ortalamınızı giriniz:");
                //double ortalama = Convert.ToDouble(Console.ReadLine());
                //Console.WriteLine(notYazdir(ortalama));

                //Console.ReadKey();

                //Arttırma metodu 

                //int x = 5;
                //Console.WriteLine("x in önceki hali" + x); //sonuc 5 
                //arttir(x);
                //Console.WriteLine("x in sonraki hali" + x); //sonuc 6 
                //static void arttir(int x)
                //{
                //    x++;
                //    Console.WriteLine("x in metod içindeki hali:" + x); //sonuc 5 
                //}

                //Console.ReadLine();

                //EBOB 

                //Console.WriteLine("Birinci sayıyı giriniz:");
                //int sayi1 = Convert.ToInt32(Console.ReadLine());

                //Console.WriteLine("İkinci sayıyı giriniz:");
                //int sayi2 = Convert.ToInt32(Console.ReadLine());

                //Console.WriteLine("İki sayının ebobu:" + ebob(sayi1, sayi2));

                //static int ebob(int sayi1, int sayi2)
                //{
                //    int ebobu = 0;
                //    int bolen = 2;

                //    while (bolen <= sayi1 && sayi2 % bolen == 0)
                //    {
                //        if (sayi1 % bolen == 0 && sayi2 % bolen == 0)
                //        {
                //            ebobu = bolen;
                //        }
                //        bolen++;

                //    }
                //    return ebobu;
                //}
                //Console.ReadLine();
            }
        

        }
    }
}