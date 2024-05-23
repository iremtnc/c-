// See https://aka.ms/new-console-template for more information

////1

//Cember cember1 = new Cember();
//cember1.yaricapGuncelle(5);

//Console.WriteLine("Alanı" + cember1.alanHesapla());
//Console.WriteLine("Çevresi" + cember1.cevreHesapla());

////2

//Cember cember2 = new Cember(10);
//Console.WriteLine("Alanı" + cember2.alanHesapla());
//Console.WriteLine("Çevresi" + cember2.cevreHesapla());

////3

//Console.WriteLine("Alanı:" + new Cember(100).alanHesapla());
//Console.WriteLine("Alanı:" +new Cember(100).cevreHesapla()); 

//referans 

//int i = 1;
//int j = 2;
//i = j;
//i++;
//Console.WriteLine("i:" + i); //3 
//Console.WriteLine("j:" + j); //2 

//Cember c1= new Cember(5);
//Cember c2 = new Cember(10);

//c1 = c2;
//c1.yaricap = 25;

//Console.WriteLine("Çember1 in yarıçapı" + c1.yaricap);
//Console.WriteLine("Çember2 nin yarıçapı" + c2.yaricap);

//Console.ReadKey(); 

using System;
using System.Security.Cryptography.X509Certificates;


//TV tv1= new TV();
//tv1.ac();
//tv1.kanaliayarla(28);
//tv1.sesayarla(5);

//Console.WriteLine("Tv1 Kanal:" + tv1.kanal + "Ses:" + tv1.sesSeviyesi);

//TV tv2 = new TV();
//tv1.ac();
//tv1.kanaliayarla(32);
//tv1.sesayarla(4);

//Console.WriteLine("Tv2 Kanal:" + tv2.kanal + "Ses:" + tv2.sesSeviyesi);



//public class TV
//{
//    public int kanal = 1;  //1-120
//    public int sesSeviyesi = 1;  //1-7 
//    bool acikMi = true; 


//     public TV()
//    {

//    }
//    public void ac()
//    {
//        acikMi = true;



//    }
//    public void kapat()
//    {
//        acikMi=false;   
//    }
//    public void kanaliayarla(int yenikanal)
//    {
//        if(acikMi && yenikanal>=1 && yenikanal<=120)
//        {
//            kanal=yenikanal;
//        } 
//    } 
//    public void sesayarla(int yenises)
//    {
//        if(acikMi && sesSeviyesi>=1 && yenises<=7)
//        {
//            sesSeviyesi = yenises;
//        }

//    }
//    public void kanalYukari()
//    {
//        if (acikMi && kanal<120)
//        {
//            kanal++;
//        } 
//    }
//    public void kanalAsagi()
//    {
//        if (acikMi && kanal>1)
//        {
//            kanal--;
//        }
//    }
//    public void sesYukari()
//    {
//        if (acikMi && sesSeviyesi<7)
//        {
//            sesSeviyesi++;
//        }
//    }
//    public void sesAsagi()
//    {
//        if (acikMi && sesSeviyesi > 1)
//        {
//            sesSeviyesi--;
//        }
//    } 

//Öğrenci 


//Ogrenci ogr1= new Ogrenci();
//Console.WriteLine("Adı:" + ogr1.adi);
//Console.WriteLine("Yaşı:" + ogr1.yas  );
//Console.WriteLine("YBS Öğrencisi Mi?:" + ogr1.YBSmi);
//Console.WriteLine("Cinsiyeti:" + ogr1.cinsiyet); 
//public class Ogrenci
//{
//    public string? adi; //null
//    public int yas;  //0 
//    public bool YBSmi;  //false
//    public char cinsiyet;  //boşluk 
//} 

// DateTime 
//DateTime simdi = DateTime.Now;
//Console.WriteLine("Şimdi:"+ simdi);

//Console.WriteLine("Bugün:" + simdi.DayOfWeek);

//Console.WriteLine("Kısa Tarih:" + simdi.ToShortDateString());
//Console.WriteLine("Kısa saat:" + simdi.ToShortTimeString());

//simdi = simdi.AddYears(10);
//Console.WriteLine("Gelecekte bugün:" + simdi);

//DateTime dt =new DateTime(2023, 12, 8, 15, 35, 48);

//Console.WriteLine("Tarih:{0:f}", dt);
//Console.WriteLine("Gün:{0:dddd}", dt);
//Console.WriteLine(" Uzun Tarih:{0:D}", dt);
//Console.WriteLine("Kısa Tarih:{0:t}", dt); 

//Console.ReadKey(); 

//Random 

//Random r1=new Random(5);
//for (int i = 0; i < 10; i++)
//{
//    Console.Write(r1.Next(1000) + " ");
//}
//Console.WriteLine(" ");
//Random r2 = new Random(5);

//for (int i = 0; i < 10; i++)
//{
//    Console.Write(r2.Next(1000) + " "); 
//}

//Console.ReadKey();  
//}


//public class Cember
//{
//     public double yaricap = 1;
    // parametresiz constructor ( kurucu/ olusturucu)
    // sağ click hizli eylemler oluşturucuyu oluştur


//    public Cember()
//    {
//    }

//    public Cember(double y)
//    {
//        this.yaricap = yaricap;
//    }
//    public double alanHesapla()
//    {
//        return yaricap * yaricap * Math.PI;
//    }

//    public double cevreHesapla()
//    {
//        return 2 * yaricap * Math.PI;
//    }

//    public void yaricapGuncelle(double y)
//    {
//        yaricap = y;
//    }
//} 
