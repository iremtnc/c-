// See https://aka.ms/new-console-template for more information


//UnvOgrenci o=new UnvOgrenci();
//o.Ad ="Mehmet";
//o.Soyad ="Yılmaz";
//o.Sehir = "Ankara";
//o.dogumtarihi = new DateTime(2003, 10, 10);

//o.OkulAdi = "BANU";
//o.Sinifi = "YBS2";
//o.OkulNo = 2023101;

//Console.WriteLine("Adı:" + o.Ad + 
//    "\nSoyadı:" + o.Soyad + 
//    "\nDoğum Yeri:" + o.Sehir + 
//    "\nDoğum Tarihi:" + o.getDogumTarihi().ToShortDateString + 
//    "\nOkul Adı:" + o.OkulAdi + 
//    "\nOkul No:" + o.OkulNo);


//Surucu s = new Surucu();
//s.Ad = "Mehmet";
//s.Soyad = "Yılmaz";
//s.Sehir = "Ankara";
//s.dogumtarihi = new DateTime(2003, 10, 10);

//s.ESinifi = "B Sınıfı";
//s.ehliyetAldigiTarih = new DateTime(2022, 10, 2); 


//Console.WriteLine("Adı:" + o.Ad +
//    "\nSoyadı:" + s.Soyad +
//    "\nDoğum Yeri:" + s.Sehir +
//    "\nDoğum Tarihi:" + s.getDogumTarihi().ToShortDateString + 
//    "\nEhliyet Sınıfı:" + s.ESinifi + 
//    "\nEhliyet Aldığı Tarih:" + s.getEhliyetAldigiTarih().ToShortDateString()); 

//Console.ReadLine(); 

//public interface NufusCuzdani
//{
//    public string Ad { get; set; }

//    public string Soyad { get; set; }

//    public string Sehir { get; set; }

//    public DateTime getDogumTarihi();

//} 

// public interface OgrenciKarti : NufusCuzdani
//{
//    public string OkulAdi { get; set; } 

//    public string Sinifi { get; set; }

//    public int OkulNo { get; set; } 
//}

//public interface Ehliyet : NufusCuzdani
//{

//    public string ESinifi { get; set; }

//    public DateTime getEhliyetAldigiTarih(); 

//} 

//abstract class Insan : NufusCuzdani
//{
//    public abstract string Ad { get; set; }

//    public abstract string Soyad { get; set; }

//    public abstract string Sehir { get; set; }

//    public abstract DateTime getDogumTarihi();
//}

//abstract class Ogrenci : Insan, OgrenciKarti
//{
//    public abstract string OkulAdi { get; set; }

//    public abstract string Sinifi { get; set; }

//    public abstract int OkulNo { get; set; }

//    public bool bursdurumu(bool durum) { return durum; }
//}

//class UnvOgrenci : Ogrenci
//{
//    private string adi;
//    private string soyadi;
//    private string sehir;
//    private string okuladi;
//    private string sinifi;
//    private int okulno;
//    public DateTime dogumtarihi;

//    public override string Ad { get { return adi; } set { adi = value; } }
//    public override string Soyad { get { return soyadi; } set { soyadi = value; } }
//    public override string Sehir { get { return sehir; } set { sehir = value; } }
//    public override string OkulAdi { get { return okuladi; } set { okuladi = value; } }
//    public override string Sinifi { get { return sinifi; } set { sinifi = value; } }
//    public override int OkulNo{ get { return okulno; } set { okulno = value; } }

//    public override DateTime getDogumTarihi()
//    {
//        return dogumtarihi;
//    }

//}   

//class Surucu : Insan, Ehliyet
//{
//    private string adi;
//    private string soyadi;
//    private string sehir;
//    private string esinifi;
//    public DateTime dogumtarihi;
//    public DateTime ehliyetAldigiTarih; 

//    public override string Ad { get { return adi; } set { adi = value; } }
//    public override string Soyad { get { return soyadi; } set { soyadi = value; } }
//    public override string Sehir { get { return sehir; } set { sehir = value; } }

//    public string ESinifi { get { return esinifi; } set { esinifi = value; } }

//    public override DateTime getDogumTarihi()
//    {
//        return dogumtarihi; 
//    }

//    public DateTime getEhliyetAldigiTarih() 
//    {
//        return ehliyetAldigiTarih;
//    }
//}


//ENUMS 

//Seviye myVar =Seviye.Orta;

//switch (myVar)
// {
// case Seviye.Dusuk:
// Console.WriteLine("Düşük Seviye");
// break;
// case Seviye.Orta:
//Console.WriteLine("Orta Seviye");
//break;
//case Seviye.Yuksek:
//Console.WriteLine("Yüksek Seviye");
//break;
// } 


//enum Seviye
//{
//    Dusuk,
//    Orta,
//    Yuksek
//} 


//-----------------------------------------------------------------------------------


//Insan insan = new Insan();
//insan.ad = "Ali";
//insan.cinsiyet = Cinsiyet.Erkek;

//Console.WriteLine(insan.cinsiyet); 

//Console.ReadLine();




//class Insan
//{
//    public string ad;
//    public Cinsiyet cinsiyet;
//} 

//public enum Cinsiyet
//{
//    Kadin,
//    Erkek
//} 


//--------------------------------------------------------------------------------------

//EXCEPTİONS

//try
//{
//    int[] sayilar = { 1, 2, 3 };
//    Console.WriteLine(sayilar[5]);
//} 

//catch (Exception e)
//{
//    //Console.WriteLine(e.Message);
//    Console.WriteLine("Bir şeyler yanlış gitti..."); 
//} 
//finally
//{
//    Console.WriteLine("Burası her türlü çalışır."); 
//}

//Console.ReadLine(); 


//--------------------------------------------------------------------------------------

//static void yasKontrol(int yas)
//{
//    if (yas<20)
//    {
//        throw new ArgumentException("Yaşınız yeterli değil");
//    } 
//    else
//    {
//        Console.WriteLine("Yaşınız yeterli"); 
//    }
//}

////yasKontrol(22);
//yasKontrol(11);   

