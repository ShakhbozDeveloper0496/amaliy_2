﻿
//1. Kalkulyator:

System.Console.WriteLine("Enter 1st number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Enter (+,-,/,*) which one: ");
char  signAdd = Convert.ToChar(Console.ReadLine());

System.Console.WriteLine("Enter 2nd number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());


if (signAdd == '+')
{
    int yigindi= firstNumber+secondNumber;
    System.Console.WriteLine(yigindi);
}
else if (signAdd == '-')
{
     int ayirma= firstNumber-secondNumber;
    System.Console.WriteLine(ayirma);
}
else if(signAdd == '*')
{
     int kopaytma= firstNumber*secondNumber;
    System.Console.WriteLine(kopaytma);
}
else if(signAdd == '/')
{
     int bolinma= firstNumber/secondNumber;
    System.Console.WriteLine(bolinma);
}
else
{
    System.Console.WriteLine("bunday amal yoq");
}



//2. Raqamlar qatorining yigindisini hisoblash:

System.Console.Write("N sonini kiriting: ");
int nSoni = Convert.ToInt32(Console.ReadLine());
int sum=0;

for (int i = 0; i <= nSoni; i++)
{
 sum =sum+i;    
}
System.Console.WriteLine(sum);

//3.  Paritet tekshiruvi:

System.Console.Write("Raqamni kiriting: ");
int son = Convert.ToInt32(Console.ReadLine());

if(son % 2 == 0)
{
    System.Console.WriteLine("juft son");
}
else
{
    System.Console.WriteLine("toq son");
}
