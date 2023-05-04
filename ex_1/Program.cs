﻿// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

void polindrom(int a){
    int b1 =0, b2 = 0; // 
    int c1 =0, c2 = 0; // 
    b1 = a/10000;
    b2 = (a-b1*10000)/1000;

    c2 = a%10;
    c1 = (a%100 - c2)/10;

    if (b1 == c2 && b2 == c1){
      Console.WriteLine($"{a} число является полиндромом");
    }
    else {
      Console.WriteLine($"{a} число не является полиндромом");
    }
}

Console.WriteLine($"введите пятизначное число");
int a = Convert.ToInt32(Console.ReadLine());


if (a > 9999 && a < 100000){
    polindrom(a);
}
else {
        Console.WriteLine($"Вы ввели не пятизначное число");
}
