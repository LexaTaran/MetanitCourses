// Arrays.
#region  Base information
/*
int[] num;                       // обьявили num как массив
int[] num1 = new int [4];       // назначили количесто элементов массива. 4. Длина массива!

// ***** Способы обозначения массивов. Все они равноценны.
int[] num2 = new int [4] { 1, 2, 3, 4};
int[] num3 = new int [] { 1, 2, 3, 4};
int[] num4 = new[] { 1, 2, 3, 4};
int[] num5 = { 1, 2, 3, 4};

string[] people = { "Alex", "Bob", "Stiven", "Tatiana" };   // Массив значений string.

***************************************
// Синтаксис инициализации массива с использованием
// ключевого слова new
int[] myArr = new int[] {10,20,30,40,50};

// Синтаксис инициализации массива без использования
// ключевого слова new
string[] info = { "Фамилия", "Имя", "Отчество" };

// Используем ключевое слово new и желаемый размер
char[] symbol = new char[4] { 'X','Y','Z','M' };
**************************************

*/
// **** вывод созданного массива. int- 0000, bool- false false false, string - пусто пусто пусто
/*
double[] num = new double[6];
foreach ( double  i in num)
{
    Console.WriteLine(i);
}
*/


// *****  Получение данных из массива.  Первый элемент в массиве имеет ондекс 0!!!

/*
int[] numb = {1, 2, 3};
Console.WriteLine(numb[0]);     // получение первого! элемента из массива.

var n = numb[1];
Console.WriteLine(n);           // получение элемента массива в переменную!
*/

// ****** Также мы можем изменить элемент массива по индексу:

/*
int[] num = { 1, 2, 3 };
num[0] = 24;
Console.WriteLine(num[0]);
*/

// ***** Свойство Length и длина массива ****
/*
int[] num = new[] { 1, 2, 3, 4, 24, 6, 7, 8 };

Console.WriteLine(num.Length);      // Выводит длину массива
Console.WriteLine(num.Max());       // Выводит максимальное значение в массиве
*/

// ***** Получение элементов с конца массива
/*
int[] num = { 1, 2, 24, 4, 5 };

Console.WriteLine(num[^1]);         // 5. ^1 - означает последний элемент массива
Console.WriteLine(num[^3]);         // 24. ^3 - означает элемент 3 с конца массива
Console.WriteLine(num[^4]);         // 2. ^4 - означает элемент 4 с конца массива
*/

// ******  Перебор массивов. Для перебора массивов мы можем использовать различные типы циклов
// *** FOR

/*
int[] num = { 1, 6, 3, 4, 24, 95 };

for (int i = 0; i < num.Length; i++)
{
    num[i] *= 2;
    Console.WriteLine(num[i]);
}
*/

// *** Цыкл FOREACH.

/*
int[] num = { 1, 6, 3, 4, 24, 95 };

foreach ( int i  in num)
{
    Console.WriteLine(i);
}
*/

// *** Цыкл WHILE.

/*
int[] num = { 1, 6, 3, 4, 24, 95 };

int i = 0;

while ( i < num.Length)
{
    Console.WriteLine(num[i]);
    i++;
}
*/

#endregion

#region Многомерные массивы
// *** Вид Двумерного массива
/*
int[,] nums = { { 0, 1, 2 }, { 3, 4, 5 } }; // Двумерный массив
*/

/*      0 1 2
 *      3 4 5
 */

// *** Заполнение 2-х мерного массива. Все они однозначны.
/*
int[,] nums1;
int[,] nums2 = new int[2, 3];
int[,] nums3 = new int[2, 3] { { 0, 1, 2 }, { 3, 4, 5 } };
int[,] nums4 = new int[,] { { 0, 1, 2 }, { 3, 4, 5 } };
int[,] nums5 = new[,] { { 0, 1, 2 }, { 3, 4, 5 } };
int[,] nums6 = { { 0, 1, 2 }, { 3, 4, 5 } };
*/
//******* Пример вывода 2-х мерного массива.
/*
int[,] nums = { { 0, 1, 2 }, { 3, 4, 5 } };

foreach (int i in nums)
{
    Console.Write($"{i} ");  // Вывод в строку всех элементов.
}
*/

// ****** GetUpperBound(номер разрядности)
/*
int[,] nums = { { 0, 1, 2 }, { 3, 4, 5 } };

// nums.GetUpperBound(0) + 1;  - Получает Индекс последнего элемента заданного измерения в массиве.
// nums.Length; -  количество элементов в строке.

int row = nums.GetUpperBound(0) + 1;    // количество строк ( Получает Индекс последнего элемента заданного измерения в массиве.) ?????????????
int collums = nums.Length / row;        // количество столбцов  или int collums = nums.GetUpperBound(1) + 1;

for (int i = 0; i < row; i++)
{
    for (int j = 0; j < collums; j++)
    {
        Console.Write($"{nums[ i, j ]} \t");
    }
    Console.WriteLine();
}
*/


#endregion

#region Many Arrays. зубчатый массив
// ****  Массив массивов

/*
int[][] nums = new int[3][];
nums[0] = new int[2] { 1, 2 };          // выделяем память для первого подмассива
nums[1] = new int[3] { 1, 2, 3 };       // выделяем память для второго подмассива
nums[2] = new int[5] { 1, 2, 3, 4, 5 }; // выделяем память для третьего подмассива

        1 2
        1 2 3   
        1 2 3 4 5

*/
//      **** ИЛИ так
/*
int[][] numbers = {
    new int[] { 1, 2 },
    new int[] { 1, 2, 3 },
    new int[] { 1, 2, 3, 4, 5 }
};
*/

//     **** Переборка массивов FOREACH
/*
numbers[2] = new int[] { 1, 2, 3, 4, 5 };
foreach (int[] row in numbers)
{
    foreach (int number in row)
    {
        Console.Write($"{number} \t");
    }
    Console.WriteLine();
}
*/
// перебор с помощью цикла FOR
/*
for (int i = 0; i < numbers.Length; i++)
{
    for (int j = 0; j < numbers[i].Length; j++)
    {
        Console.Write($"{numbers[i][j]} \t");
    }
    Console.WriteLine();
}
*/
#endregion

#region Основные понятия массивов. Var

/*  Суммируем основные понятия массивов:
 *  Ранг (rank): количество измерений массива
 *  Длина измерения (dimension length): длина отдельного измерения массива
 *  Длина массива (array length): количество всех элементов массива
*/
//  int[,] numbers = new int[3, 4]; 

/* Rank - 2 (так как двухмерный);
 * dimension length - 3 ( количество значений в стрке );
 * array length - 12 ( то есть общее количество элементов - 12.)
*/
// *****  Type - var.  Автомотически определякт тип переменных в массиве.
/*
var arry = new[] {1, 2, 3};
Console.WriteLine($" var type is : {arry.GetType()}");

var arry2 = new[] {"A","B","X"};
Console.WriteLine($" var type is : {arry2.GetType()}");
*/


#endregion
#region Определение массива объектов. object

// Объявляем и инициализируем массив объектов
/*
object[] anyTypeInArray = { true, 24, "A", "Alex", 14.4m };

foreach (var item in anyTypeInArray)
{
    Console.WriteLine($"Type for each elements: {item} - {item.GetType()}");
}
*/
#endregion
#region



#endregion