// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int numberA = 3;
int numberB = 5;
int result = 1;

 for(int i = 1; i <= numberB; i++)
 {
    result = result * numberA;
 }
 Console.WriteLine(result);