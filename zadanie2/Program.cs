using System;
using static System.Console;
Write("Число от: ");
int number1 = int.Parse(ReadLine());
Write("Число до: ");
int number2 = int.Parse(ReadLine());
Write(WriteNow(number1,number2));
int WriteNow(int number1,int number2)
{if (number1==number2){
    return number2;}
    return number1+WriteNow(++number1,number2);
    }