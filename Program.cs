//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

/*
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
*/

 //Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*

void Sum (int[]array)
{
    int sum =0;

    for(int i=0; i<array.Length;i++){
sum=sum+array[i];
    }
    Console.WriteLine(sum);
}
Console.WriteLine ("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
string a = num.ToString();
    int [] arr= new int [a.Length];
    for (int i = 0; i<a.Length; i++){

    
    arr [i] = int.Parse(a[i].ToString());}

Sum(arr);
*/
//Напишите программу, которая задаёт массив из произвольного элементов и выводит их на экран.
//void FillArray (int[]newarray)

int[] CreateRandomArray(int size){
    int[] array = new int[size];
    for (int i=0; i < size; i++){
        array[i] = new Random().Next(0,11 );
    }
    return array;
}

void ShowArray(int[] array){
    Console.Write("[ ");
    for(int i=0; i<array.Length; i++){
        Console.Write(array[i]+" ");
    }
    Console.Write("]");
}

ShowArray(CreateRandomArray(20));

// Массив - это набор элементов одного типа, создающийся для совершения действий над однотипными данными
// для упрощения ввода и вывода информации.:)