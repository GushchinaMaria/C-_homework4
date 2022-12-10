/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16 */

/* int Set_numbers ()      // метод для ввода переменных с клавиатуры
{
    Console.WriteLine ("Введите натуральное число:");
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int A = Set_numbers();
int B = Set_numbers(); 

int Pow_mine(int A,int B)               // реализуем Nath.Pow
{
    int numA = A;
    int numB = B;

    if ((numA == 0) || (numA == 1 ))  return numA;  // ноль и единица в любой степент 0 и 1
    if (numB == 0) return 1;                        // любое число в 0 степени = 1

    int result = numA;                              // все остальные случаи
    for (int i =1; i < numB; i++)
    {
        result *= numA;

    }
    return result;
}
int res = Pow_mine(A,B);
Console.WriteLine(res); */

// конец первой задачи
/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12 */

/* int Set_numbers ()      // метод для ввода переменных с клавиатуры
{
    Console.WriteLine ("Введите натуральное число:");
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int numb = Set_numbers();
int res = 0;
while (numb > 0)
{
    res += numb%10;
    numb/=10;
}
Console.WriteLine ($"Сумма цифр числа равна {res}");
 */
// конец второй задачи

/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33] */

int [] Set_array(int N)                  //задаем массив из N элементов
{
    int [] array = new int [N];
    Random rnd = new Random();

    for (int i = 0; i < N; i++ )
        array[i] = rnd.Next(10,100);

    return (array);
}
void Print_array (int [] array)                    // печатаем массив
{
    int lenght_of_array = array.Length;

    for (int i = 0; i < lenght_of_array; i++)
         Console.Write($"{array[i]} ");

}

Console.WriteLine("ВВедите число элементов массива: ");         //здесь просим ввести число элементов
int N = Convert.ToInt32(Console.ReadLine());
int [] array = Set_array(N);
 Console.WriteLine("Заданный массив из 8 элементов");
Print_array(array);

