//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

void Function(int a, int b) {
int result = a;
   
 for (int curr = 1; curr<b; result= result*a) {
 curr++;
 }

Console.WriteLine ($"Число {a} в степени {b} равно {result}");

    
}
 Console.WriteLine("Введите первое число: ");
 int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int y = Convert.ToInt32(Console.ReadLine());

if (y == 0) { 
    Console.WriteLine("1");
}
else Function (x,y);

