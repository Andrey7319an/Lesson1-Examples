﻿/* Задача 2: 
Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3

!!! ВОПРОС: Я НЕ ЗНАЮ, КАКОЙ КОМАНДОЙ/ОПЕРАЦИЕЙ/строкой ПОКАЗАТЬ, ЧТО У ЧИСЛА А ЕСТЬ ТРИ ВАРИАНТА (5, 2, -9)
И У ЧИСЛА Б ТОЖЕ ТРИ ВАРИАНТА (7, 10, -3)*/

int a = 5;
int b = 7;

int max = a;
int min = b;
if (a > max ) max = a;
if (b > max ) max = b;
if (a < min ) min = a;
if (b < min ) min = b;

Console.Write("max = ");
Console.WriteLine(max);

Console.Write("min = ");
Console.WriteLine(min);

