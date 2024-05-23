//See https://aka.ms/new-console-template for more information


//Ogrenci ogr1 = new Ogrenci(111, "Ahmet");
//Console.WriteLine("No:" + ogr1.getOgrNo() + "\nAdı:" + ogr1.getOgrAd()) + "\nKayıt Tarihi" + ogr1.getolusturulmaTarihi());



// class Ogrenci // -----> immutable object and classes ( sabit/değişmez nesneler ve sınıflar)
//{
//    private int ogrNo;
//    private string ogrAd;
//    private DateTime olusturulmaTarihi;

//    public Ogrenci(int ogrNo, string ogrAd)
//    {
//        this.ogrNo = ogrNo;
//        this.ogrAd = ogrAd;
//        olusturulmaTarihi = DateTime.Now;
//    }

//    public int getOgrNo()
//    {
//        return ogrNo;
//    }

//    public string getOgrAd()
//    {
//        return ogrAd;
//    }

//    public DateTime getolusturulmaTarihi()
//    {
//        return olusturulmaTarihi;
//    }
//}



//KALITIM 

//Insan insan1 = new Insan();
//insan1.Ad = "Emir";
//insan1.Soyad = "ÖZ";

//Calisan calisan1 = new Calisan();
//calisan1.Ad = "Melek";
//calisan1.Soyad = "Yılmaz";
//calisan1.CalisanId = 1234;
//calisan1.FirmaAdi = "Google";
//calisan1.Maas = 100000;

//Console.WriteLine(insan1.yazdir());
//Console.WriteLine(calisan1.yazdir());
//Console.WriteLine(" ");
//Console.WriteLine(calisan1.ToString());  //nesnenin class ını getirir 

//Console.ReadKey();
//class Insan
//{
//    public string Ad { get; set; }

//    public string Soyad { get; set; }

//    public string yazdir()
//    {
//        return Ad + " " + Soyad;
//    }
//}

//class Calisan : Insan
//{
//    public int CalisanId { get; set; }

//    public string FirmaAdi { get; set; }

//    public int Maas { get; set; }

//    public string yazdir()
//    {
//        return Ad + " " + Soyad + " " + CalisanId + " " + FirmaAdi + " " + Maas;
//    }



//---------------------------------------------------------------------------


//Daire daire1 = new Daire(10, "beyaz");
//daire1.yazdir();

//Dikdortgen dik1 = new Dikdortgen(10, 20);
//dik1.yazdir();
   


//class GeometrikNesne
//    {
//        public string Renk { get; set; }

       
//        public GeometrikNesne(string renk)
//        {
//            Renk = renk;
//        }

//        public virtual void yazdir() 
//        {
//            Console.WriteLine("Rengi:" + Renk);
//        }




//    }

//    class Daire : GeometrikNesne
//    {
   
//    //  1. yöntem
//        public Daire(string renk) : base(renk)
//        {
//        }



//        public Daire(double yaricap)
//        {
//            Yaricap = yaricap;
//        }


     
//    //2. yöntem
//        public Daire(double yaricap, string renk):base(renk) 
//        {
//            Renk = renk;
//            Yaricap = yaricap;
//        }


//        public double Yaricap { get; set; }

//        public double alanHesapla()
//        {
//            return Math.PI * Yaricap * Yaricap;
//        }

//        public double cevreHesapla()
//        {
//            return Math.PI * Yaricap * 2;
//        }

//        public override void yazdir()
//        {
//            Console.WriteLine("Rengi:" + Renk + "\nYaricapı:" + Yaricap + "\nAlanı:" + alanHesapla() + "\nÇevre" + cevreHesapla());
//        }

//    }

//    class Dikdortgen : GeometrikNesne
//    {
//        public double Genislik { get; set; } 

//        public double Yukseklik { get; set; }

//    public Dikdortgen(string renk) : base(renk)
//    {
//    } 

//    public Dikdortgen (double genislik, double yukseklik)
//    {
//        Genislik= genislik; 
//        Yukseklik= yukseklik;
//    }

//    public double alanHesapla()
//    {
//        return Genislik * Yukseklik;
//    }

//    public double cevreHesapla()
//    {
//        return (Genislik + Yukseklik) * 2;
//    }

//    public override void yazdir()
//    {
//        Console.WriteLine("Rengi:" + Renk + "\nGenişlik:" + Genislik + "\nYükseklik" + Yukseklik + "\nAlanı:" + alanHesapla() + "\nÇevre" + cevreHesapla());
//    }


//}
