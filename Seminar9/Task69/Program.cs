﻿// Напишите программу, которая на вход принимает 
// два числа A и B, и возводит число А в целую степень
//  B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8


int a = 3;
int b = 5;

int StepenRec(int x, int y)
{
    if(y == 0) return 1;
    return StepenRec(x, y - 1) * x;
}
Console.Write(StepenRec(a, b));