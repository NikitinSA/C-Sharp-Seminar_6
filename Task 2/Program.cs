/*Напишите программу, которая принимает на вход три числа и проверяет, 
может ли существовать треугольник со сторонами такой длинны*/

Console.Clear();

Console.Write("Введите 1 число: ");
int Num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите 2 число: ");
int Num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите 3 число: ");
int Num3 = Convert.ToInt32(Console.ReadLine());

void Triangle(int Num1, int Num2, int Num3)
{
    if (Num1 < (Num2 + Num3) && Num2 < (Num1 + Num3) && Num3 < (Num1 + Num2))
    {
        Console.WriteLine("Такой треугольник может существовать");
    }
    else
    {
        Console.WriteLine("Такой треугольник не может существовать");
    }
}

Triangle(Num1, Num2, Num3);