﻿// Задачи по основам языка C# с решениями

// Console.Title = " Many chalanges";

#region S. Ввод и вывод числовых данных. Оператор присваивания (44 задачи)
#region S1. Простейшие программы. Арифметические выражения. Done.

// S1 .1.Вывести на экран число  с точностью до сотых.

/*
Console.WriteLine("Enter the number with , :");
double a = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(Math.Round(a,2));
*/

// S1.2. Вывести на экран число e (основание натурального логарифма) с точностью до десятых.

// decimal e = (decimal)Math.E;
// Console.WriteLine(Math.Round(e,1));
/*
Console.WriteLine(Math.Round(Math.E,1)); // ***************************************
*/


// S1.3. Составить программу вывода на экран числа, вводимого с клавиатуры. Выводимому числу должно предшествовать сообщение «Вы ввели число».
/*
Console.WriteLine("Enter the number:");
var num = Console.ReadLine();
Console.WriteLine($"your number is {num}");
*/
/*
Console.WriteLine("Enter the number:");
int a = Int32.Parse(Console.ReadLine());
Console.WriteLine($"your number is {a}");
*/

// S1.4. Составить программу вывода на экран числа, вводимого с клавиатуры. После выводимого числа должно следовать сообщение » — вот какое число Вы  ввели».
/*
Console.Write("Enter the number: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine($"{a} - this is Number");   
*/

// S1.5. Вывести на одной строке числа 1, 13 и 49 с одним пробелом между ними.
/*
int a = 1, b = 13, c = 49;
Console.WriteLine($"{a} {b} {c} ");
*/
// S1.6. Вывести на одной строке числа 7, 15 и 100 с двумя пробелами между ними.
/*
int a = 7, b = 15, c = 100;
Console.WriteLine($"{a}  {b}  {c}");
*/
// S1.7. Составить программу вывода на экран в одну строку трех любых чисел с двумя пробелами между ними.
/*
Random ran = new Random();

int a = ran.Next(-100, 100);
int b = ran.Next(-100, 100);
int c = ran.Next(-100, 100);

Console.WriteLine($"{a}  {b}  {c}  ");
*/

// S1.8. Составить программу вывода на экран в одну строку четырех любых чисел  с одним пробелом между ними.
/*
 * 
Random ran = new Random();

int a = ran.Next(-100, 100);
int b = ran.Next(-100, 100);
int c = ran.Next(-100, 100);
int d = ran.Next(-100, 100);

Console.WriteLine($"{a} {b} {c} {d}");
*/

// S1.9. Вывести на экран числа 50 и 10 одно под другим.
/*
int a = 50, b = 100;
Console.WriteLine($"{a} \n{b}");
*/

// S1.10. Вывести на экран числа 5, 10 и 21 одно под другим.
/*
int a = 5, b = 10, c = 21;
Console.WriteLine($"{a} \n{b} \n{c}");
*/
// S1.11. Составить программу вывода на экран «столбиком» четырех любых чисел.
/*
Random ram = new Random();
int a = ram.Next(-100,100), b = ram.Next(-100, 100), c = ram.Next(-100, 100), d = ram.Next();

Console.WriteLine($"{a} \n{b} \n{c} \n{d}");
*/
/*S1.12. Составить программу вывода на экран следующей информации:
 *5 10
 *7 см
*/
/*
int a = 5, b = 10, c = 7;
string s = "cm";

Console.WriteLine($"{a} {b} \n{c} {s}");
*/
/* S1.13. Составить программу вывода на экран следующей информации:
 * 2 кг
 * 13 17
 */

// Console.WriteLine($"2 kg \n13 17");


#endregion
#region S2. Вычисления по известным формулам
/* S2.1. Составить программу:
 * а) вычисления значения функции y=7x^2+3x+6 при любом значении x;
 * б) вычисления значения функции x=12a^2+7a+12 при любом значении а.*/
/*
long x, y;
Random ram = new Random();
x = ram.Next(-100, 100);

y = Convert.ToInt64(7 * (Math.Pow(x, 2)) + 3 * x + 6);

Console.WriteLine($"y=7x^2+3x+6 \n X = {x}, Y = {y}");
*/

// S2.2. Дана сторона квадрата. Найти его периметр. — решение.
/*
Console.Write("Enter the legth of cube :");
int a = int.Parse(Console.ReadLine());

if (a>0)
{
    Console.WriteLine($"The perimeter of cube with legth {a} is = {a *= 4}");
}
else
{
    Console.WriteLine("The legth of cobe should be > 0");
}
*/

// S2.3. Дан радиус окружности. Найти ее диаметр. — решение.

/*
double d;
Console.Write("Enter the radius: ");
double r = Convert.ToDouble(Console.ReadLine());

if (r > 0)
{
    d = 2 * r;
    Console.WriteLine($"The diametr with R={r}, D = {d}");
}
else
    Console.WriteLine("The radius should be >0 ");
*/

// S2.4. РИСУНОК. Считая, что Земля — идеальная сфера с радиусом R=6350 км, определить расстояние до линии горизонта от точки В с заданной высотой h=AB над Землей.
/*
double r = 6350, x;

Console.Write("Enter the hight h= ");
double h = Convert.ToDouble(Console.ReadLine());

if (h>0)
{
   x = Convert.ToDouble( Math.Sqrt(Math.Pow(r + h,2) - (r * r)));
    
   Console.WriteLine($"The x = {x}");   
}
else
{
    Console.WriteLine("Hight should be >0");
}
*/

// S2.5. Дана длина ребра куба. Найти объем куба и площадь его боковой поверхности. — решение
/*
double v, s;

Console.Write("Enter the length of cube: a = ");
double a = Convert.ToDouble(Console.ReadLine());

if (a>0)
{
    s = a*a;
    v = Math.Pow(a, 3);

    Console.WriteLine($" S = {s} \n Volume = {v}");
}
else
{
    Console.WriteLine("the length of cube: a >0");
}
*/

// S2.6. Дан радиус окружности. Найти длину окружности (2пr) и площадь круга s = 2пr^2.
/*
double d, s;

Console.Write(" Enter R= ");
double r = Convert.ToDouble(Console.ReadLine());

d = 2 * Math.PI * r;
s = 2* Math.PI * Math.Pow(r,2);

Console.WriteLine($"D = {d} \nS = {s}");
*/

// S2.7. Даны два целых числа. Найти: а) их среднее арифметическое; б) их среднее геометрическое.

/*
double medAr, medFeo;

Console.Write("Enter number 1 :");
double num1 = double.Parse(Console.ReadLine());
Console.Write("Enter number 2 :");
double num2 = double.Parse(Console.ReadLine());

medAr = (num1+num2)/2;
medFeo = Math.Sqrt(num1 * num2);

Console.WriteLine($"Medium Ariffmet = {medAr} \nMedium Geometr = {medFeo}");
*/

// S2.8. Известны объем и масса тела. Определить плотность материала этого тела.




// S2.9. Известны количество жителей в государстве и площадь его территории. Определить плотность населения в этом государстве.

// S2.10. Составить программу решения линейного уравнения ax+b=0 (a ≠ 0).

// S2.11. Даны катеты прямоугольного треугольника. Найти его гипотенузу.

// S2.12. Найти площадь кольца по заданным внешнему и внутреннему радиусам.

// S2.13.  Даны катеты прямоугольного треугольника. Найти его периметр.

// S2.13А. Даны два числа. Найти среднее арифметическое и среднее геометрическое их  модулей.

// S2.14. Даны основания и высота равнобедренной трапеции. Найти ее периметр.

// S2.14А. Даны стороны прямоугольника. Найти его периметр и длину диагонали.

// S2.15. Даны два числа. Найти их сумму, разность, произведение, а также частное от деления первого числа на второе.

// S2.16. Даны длины сторон прямоугольного параллелепипеда. Найти его объем и площадь боковой поверхности.

// S2.17. Известны координаты на плоскости двух точек. Составить программу вычисления расстояния между ними.

// S2.18. Даны основания и высота равнобедренной трапеции. Найти периметр трапеции.

// S2.19. Даны основания равнобедренной трапеции и угол при большем основании. Найти площадь трапеции.

// S2.20. Треугольник задан координатами своих вершин. Найти периметр и площадь треугольника.

// S2.21. Выпуклый четырехугольник задан координатами своих вершин. Найти площадь этого четырехугольника как сумму площадей треугольников.

// S2.22. Известна стоимость 1 кг конфет, печенья и яблок. Найти стоимость всей покупки, если купили x кг конфет, у кг печенья и z кг яблок.

// S2.23. Известна стоимость монитора, системного блока, клавиатуры и мыши. Сколько будут стоить 3 компьютера из этих элементов? N компьютеров?

// S2.24. Возраст Тани — X лет, а возраст Мити — Y лет. Найти их средний возраст, а также определить, на сколько отличается возраст каждого ребенка от среднего значения.  —  решение

/* S2.25. Два автомобиля едут навстречу друг другу с постоянными скоростями V1 и  V2 км/час.
 *Определить, через какое время автомобили встретятся, если расстояние между ними было S км. */

/* S2.26. Два автомобиля едут друг за другом с постоянными скоростями V1 и  V2 км/час (V1>V2). 
 * Определить, какое расстояние будет между ними через 30 минут после того, как первый автомобиль опередил второй на S км.*/

/* S2.27. Известно значение температуры по шкале Цельсия. 
 * Найти соответствующее  значение температуры по шкале: а) Фаренгейта; б) Кельвина. 
 * Для пересчета по шкале Фаренгейта необходимо исходное значение температуры умножить на 1,8 и к результату прибавить 32, 
 * а по шкале Кельвина абсолютное значение нуля соответствует 273,15 градуса по шкале Цельсия.*/

/* S2.28. У американского писателя-фантаста Рэя Бредбери есть роман «450 градусов  по Фаренгейту». 
 * Какой температуре по шкале Цельсия соответствует указанное в названии значение? (См. предыдущую задачу).*/



#endregion
#region S3. Часто используемые эффективные алгоритмы.
// Все переменные — целые числа.
// S3 .1 Составить программу обмена значениями двух переменных величин.
/*
int p;

Console.Write("Enter num1= ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter num2= ");
int num2 = Convert.ToInt32(Console.ReadLine());

    p = num2;
    num2 = num1;
    num1 = p;

    Console.WriteLine($"Reverce number1: {num1} \n\t number2: {num2}");
*/

// Variant 2
/*
int num_1 = Convert.ToInt32(Console.ReadLine());
int num_2 = Convert.ToInt32(Console.ReadLine());

(num_1, num_2) = (num_2, num_1);

Console.WriteLine(num_1 + " " + num_2);
*/

/* S3.2. Cоставить программу обмена значениями трех переменных величин а, b, c по
следующим двум схемам: — есть решение.
а) b присвоить значение c, а присвоить значение b, с присвоить значение а;
б) b присвоить значение а, с присвоить значение b, а присвоить значение с.*/

/*
int x;

Console.Write("Enter a= ");
int a = Convert.ToInt16(Console.ReadLine());

Console.Write("Enter b= ");
int b = Convert.ToInt16(Console.ReadLine());

Console.Write("Enter c= ");
int c = Convert.ToInt16(Console.ReadLine());

x = c; //3

c = a; //1 

a = b; //2

b = x; //3

Console.WriteLine($" a (b) = {a} \n b (c) = {b} \n c (a) = {c}");
*/
/*
int x;

Console.Write("Enter a= ");
int a = Convert.ToInt16(Console.ReadLine());
Console.Write("Enter b= ");
int b = Convert.ToInt16(Console.ReadLine());
Console.Write("Enter c= ");
int c = Convert.ToInt16(Console.ReadLine());

x = c; //3

c = b; //2

b = a; //1

a = x; //3

Console.WriteLine($" a (c) = {a} \n b (a) = {b} \n c (b) = {c}");
*/

/* S3.3. Дано вещественное число а. Пользуясь только операцией умножения, получить:
а) a^4 за две операции;
б) a^6 за три операции;
в) a^7 за четыре операции;
г) a^8 за три операции;
д) a^9 за четыре операции;
е) a^10 за четыре операции.*/


//Console.WriteLine($"a^4 = {a}");



/* S3.4. Дано вещественное число a. Пользуясь только операцией умножения, получить:
а) a^3 и a^10 за четыре операции;
б) a^4 и a^20 за пять операций;
в) a^5 и a^13 за пять операций;
г) a^5 и a^19 за пять операций;
д) a^2, a^5 и a^17 за шесть операций;
е) a^4, a^12 и a^28 за шесть операций.*/

// S3.5. Чему будет равно 10^10 по Вашему алгоритму?





#endregion