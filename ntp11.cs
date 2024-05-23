// See https://aka.ms/new-console-template for more information



//OVERLOAD 


//A a = new A();
//a.p(10);   //10
//a.p(10.0); //20 

//Console.ReadKey();

//class B
//{
//    public void p(double i)
//    {
//        Console.WriteLine("İ:" + (i * 2));
//    }
//}

//class A : B  //alt sınıf 
//{
//    public void p(int i)
//    {
//        Console.WriteLine("i:" + i);
//    }
//}


//------------------------------------------------------------------------ 

//OVERRİDE

//AA aa = new AA();
//aa.p(10);
//aa.p(10.0);

//BB bB = new BB();
//bB.p(10);
//bB.p(10.0);

//Console.ReadKey();



//class BB
//{
//    public virtual void p (double i)
//    {
//        Console.WriteLine("i:" + (i*2));
//    } 
//}

//class AA: BB
//{
//    public override void p (double i)
//    {
//        Console.WriteLine("i:" + (i));
//    }
//} 



//-------------------------------------------------------------------

//ZİNCİR  

//void m(object o)
//{
//    Console.WriteLine(o.ToString);
//}

//m(new MezunOgrenci());
//m(new Ogrenci());
//m(new Kisi());
//m(new Object());

//Console.Read();

//class Kisi : Object
//{
//    public override string ToString()
//    {
//        // return base.ToString(); 
//        return "Kisi";
//    }
//}

//class Ogrenci : Kisi
//{
//    public override string ToString()
//    {

//        return "Ogrenci";
//    }
//}
//class MezunOgrenci : Ogrenci
//{
//    public override string ToString()
//    {
//        return "Ogrenci";
//    }
//}



//---------------------------------------------------------------------------

//POLİMORFİZM 

//Hayvan kedi = new Kedi("Loki");
//Hayvan kopek = new Kopek("Pamuk");
//Hayvan at = new At("Düldül");

//Console.WriteLine(kedi.konus());
//Console.WriteLine(kopek.konus());
//Console.WriteLine(at.konus());

//Console.ReadKey();




//public class Hayvan
//{
//    private string isim;

//    public Hayvan(string isim)
//    {
//        this.isim = isim;
//    }

//    public virtual string konus()
//    {
//        return "Hayvan konuşuyor...";
//    }

//    public string getİsim()
//    {
//        return isim;
//    }

//    public void setİsim(string isim)
//    {
//        this.isim = isim;
//    }
//}

//public class Kedi : Hayvan
//{
//    public Kedi(string isim) : base(isim)
//    {
//    }

//    public override string konus()
//    {
//        return this.getİsim() + " miyavlar...";
//    }
//}

//public class Kopek : Hayvan
//{
//    public Kopek(string isim) : base(isim)
//    {
//    }

//    public override string konus()
//    {
//        return this.getİsim() + " havlar...";
//    }
//}

//public class At : Hayvan
//{
//    public At(string isim) : base(isim)
//    {
//    }

//    public override string konus()
//    {
//        return base.konus();
//    }
//}


//---------------------------------------------------------------------------

//ARRAYLİST 

//using System.Collections;

//ArrayList sehirListesi = new ArrayList();

//sehirListesi.Add("Bandırma");
//sehirListesi.Add("İstanbul");
//sehirListesi.Add("Ankara");
//sehirListesi.Add("Yozgat");
//sehirListesi.Add("Çorum");
//sehirListesi.Add("Mersin");

//Console.WriteLine("Listenin boyutu:" + sehirListesi.Count);
//Console.WriteLine("Listede Yozgat var mı?" + sehirListesi.Contains("Yozgat"));
//Console.WriteLine("Kapasite:" + sehirListesi.Capacity);

//sehirListesi.Remove("Çorum");
//Console.WriteLine("Listenin boyutu:" + sehirListesi.Count);

//for (int i = 0; i < sehirListesi.Count; i++)
//{
//    Console.WriteLine(sehirListesi);
//    Console.ReadLine();
//}

//kapasite 4er 4er artıyor 

//ArrayList liste = new ArrayList();

//Console.WriteLine("Sayı giriniz (Çıkış için 0)");

//while (true)
//{
//    int sayi = Convert.ToInt32(Console.ReadLine());
//    if (sayi == 0)
//    {
//        break;
//    }
//    if (!liste.Contains(sayi))
//    {
//        liste.Add(sayi);
//    }
//}

//foreach (int sayi in liste)
//{
//    Console.WriteLine(sayi + " ");
//}

//Console.ReadKey();

