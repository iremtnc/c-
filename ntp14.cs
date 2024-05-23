// See https://aka.ms/new-console-template for more information



// Exceptions(Hatalar) 

//Sytnax Errors --> yazım hataları 
//RunTime Error --> program çalışmaz
//Logic Error -->  program çalışır ama yanlış çalışır 

//long deger = long.MaxValue;
//Console.WriteLine(deger);
//Console.WriteLine(deger + 1);//---->logic error 





//int sonuc = topla(5, 3);
//Console.WriteLine("Sonuç:" +sonuc); ---> logic error 

//static int topla(int a, int b)
//{
//    return a * b;
//} 


//int a = 5;
//int b = 6;
//int c = 7;
//int ort = a + b + c / 3; -----> logic 



//int a = 10;
//int b = 0;
//Console.WriteLine(a/b); ----->runtime 


//try
//{
//    int a = 10;
//    int b = 0;
//    Console.WriteLine(a / b);
//} 
//catch (DivideByZeroException)
//{
//    Console.WriteLine("Sıfıra bölünme hatası");
//}



//string s = "abs"; 
//Console.WriteLine(s[4]); ------->runtime(taşma hatası)



//int deger = Int32.MaxValue;
//Console.WriteLine(deger); 

//try
//{
//    int karesi = deger * deger;
//} 
//catch (OverflowException) 
//{
//    Console.WriteLine("Taşma hatası"); 
//}


//hata açıklamaları özelden genele yazılmalı yoksa hata verir 

//try
//{

//} 
//catch (OverflowException) // D seviye 
//{

//} 
//catch (DivideByZeroException)  // D seviye 
//{

//}
//catch (IndexOutOfRangeException)  // D seviye 
//{

//} 
//catch (ArithmeticException)  //C seviye 
//{

//} 
//catch (SystemException)  //B seviye 
//{

//}
//catch (Exception)  //A seviye 
//{
//    throw;
//}


//try
//{

//    Console.Write("Şifrenizi giriniz:");
//    string sifre = Console.ReadLine();

//    if (sifre == null)
//    {
//        throw new ArgumentNullException("Şifre boş olamaz");
//    }
//    if (sifre.Length < 5)
//    {
//        throw new ArgumentException("Şifre en az 5 karakter olmalıdır.");
//    }

//    bool hasLowercase = false, hasUppercase = false, hasSpecialChar = false, hasDigitChar = false;

//    foreach (char c in sifre)
//    {
//        if (char.IsLower(c)) hasLowercase = true;
//        if (char.IsUpper(c)) hasUppercase = true;
//        if (!char.IsLetterOrDigit(c)) hasSpecialChar = true;
//        if (char.IsDigit(c)) hasDigitChar = true;
//    }

//    Console.WriteLine("Küçük harf içeriyor:" + hasLowercase);
//    Console.WriteLine("Büyük harf içeriyor:" + hasUppercase);
//    Console.WriteLine("Özel karakter içeriyor:" + hasSpecialChar);
//    Console.WriteLine("Rakam içeriyor:" + hasDigitChar);


//}
//catch (ArgumentNullException ex)
//{
//    Console.WriteLine("Hata:" + ex.Message); 
//} 
//catch (ArgumentException ex)
//{
//    Console.WriteLine("Hata" + ex.Message);
//} 
 
//using System.IO;  // include the System.IO namespace

//string writeText = "Hello World!";  // Create a text string
//File.WriteAllText("filename.txt", writeText);  // Create a file and write the content of writeText to it

//string readText = File.ReadAllText("filename.txt");  // Read the contents of the file
//Console.WriteLine(readText);  // Output the content 


//Console.ReadLine();

 
