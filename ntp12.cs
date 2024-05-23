// See https://aka.ms/new-console-template for more information

//ABSTRACT (SOYUTLAMA) 


//Kare kare1 = new Kare(5, "Kare1");
//Daire daire1 = new Daire(3, "Daire1");


//kare1.alanHesapla();
//daire1.alanHesapla();

//kare1.cevreHesapla();

//Sekil kare2 = new Kare(10, "Kare2");
//kare2.alanHesapla();

//((Kare)kare2).cevreHesapla();  

//public abstract class Sekil
//{
//    private string isim;

//    protected Sekil(string isim)
//    {
//        this.isim = isim;
//    }

//    public void isimYazdir()
//    {
//        Console.WriteLine(isim);
//    }

//    public abstract void alanHesapla(); 

//    public string getIsim()
//    {
//        return isim;
//    }

//    public void setIsim(string isim)
//    {
//        this.isim = isim;
//    }
    

   
//}

//public class Kare : Sekil
//{

//    private int kenar;
//    public Kare(int kenar, string isim) : base(isim) 
//    { 
//        this.kenar= kenar;  
//    }
//    public override void alanHesapla()
//    {
//        Console.WriteLine(getIsim() + "alanı:" + (kenar*kenar)); 
//    }

//    public void cevreHesapla()
//    {
//        Console.WriteLine(getIsim() + "alanı:" + (kenar * 4));
//    }

    
//} 

//public class Daire : Sekil
//{
//    private int yaricap; 

//    public Daire (int yaricap, string isim) : base(isim)
//    {
//        this.yaricap= yaricap;  
//    }

//    public override void alanHesapla()
//    {
//        Console.WriteLine(getIsim() + " alanı:" + (Math.PI * yaricap*yaricap));
//    } 

//    public void cevreHesapla()
//    {
//        Console.WriteLine(getIsim() + " çevre" + (Math.PI*yaricap*2)); 
//    }
//} 


//------------------------------------------------------------------------------



// INTERFACE 

//interface IYenilebilir
//{
//    string nasilYenir(); 
//}

//abstract class Hayvan
//{
//    public abstract string ses(); 
//} 

//class Tavuk : Hayvan, IYenilebilir 
//{
//    public override string ses()
//    {
//        return "Gıd gıd gıdak";
//    } 

//    public string nasilYenir()
//    {
//        return "köri sosu ile yenir";
//    } 
 
//}

//class Kaplan : Hayvan
//{
//    public override string ses()
//    {
//        return "ROAAARRR"; 
//    } 

//} 

//abstract class Meyve : IYenilebilir
//{
//    public abstract string nasilYenir();
//} 

//class Elma : Meyve
//{
//    public override string nasilYenir()
//    {
//        return "doğrayarak yenir";
//    }
//}

//class Portakal : Meyve
//{
//    public override string nasilYenir()
//    {
//        return "Suyu sıkılırarak içilir"; 
//    }
//} 