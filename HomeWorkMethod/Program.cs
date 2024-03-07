//Task - 1Task - 1
//FindCharIndex metodu - pramater olaraq 1 string ve 1 char value qebul edir ve
//gonderilmis char deyeri gonderilmis string deyerinde necenci indexde yerlesirse hemin indexi geri qaytarir,
//eger tapilmasa -1 qaytarir.
//Misal ucun metodu call ederken "code" ve 'a deyerlerini gondersek metod bize -1,
//"code" ve 'c' deyerlerini gondersek 0 qaytarmalidir Bu metodu Main metodunda call edib isledeceksiniz.

//static int FindCharIndex(string name,char herf)
//{
//    for (int i = 0;i < name.Length; i++)
//    {
//        if (name[i] == herf)
//        {
//            return i;
//        }
//    }return -1;

//}
//Console.WriteLine(FindCharIndex("Senan", 'n'));


//Task - 3
//IsPrime metodu - parametr olaraq ineteger value qebul edir.
//Gonderilims integer deyerin sade olub olmadigini qaytarir.
//Eded sadedirse true, deyilse false qayitmalidir


//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Eded daxil edin");

//        int number = int.Parse(Console.ReadLine());

//        Console.WriteLine(IsPrime(number));
//    }

//    static bool IsPrime(int n)
//    {
//        if (n <= 1)
//            return false;

//        for (int i = 2; i <= Math.Sqrt(n); i++)
//        {
//            if (n % i == 0)
//                return false;
//        }

//        return true;
//    }
//}





Console.WriteLine(Say(3, 4, 5));

static int Say(int a, int b, int c)
{
    if (a > b && a > c)
    {
        return a;
    }
    else if (b > a && b > c)
    {
        return b;
    }
    else return c;
}
