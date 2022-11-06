https://ulearn.me/course/basicprogramming/Zadachi_na_seminar_aef25d82-818b-4a50-a2f0-bba842eeeedc

/* Expr1. 
Как поменять местами значения двух переменных? 
Можно ли это сделать без ещё одной временной переменной. 
Стоит ли так делать? */

string variable1 = "переменная № 1";
string variable2 = "переменная № 2";
Console.WriteLine(variable1);
Console.WriteLine(variable2);
string variable_empty = variable1;
variable1 = variable2;
variable2 = variable_empty;
Console.WriteLine(variable1);
Console.WriteLine(variable2);


/* Expr2. 
Задается натуральное трехзначное число (гарантируется, что трехзначное). 
Развернуть его, т.е. получить трехзначное число, записанное теми же цифрами в обратном порядке. */

int a = 0;
while (a < 100 || a > 999)
{
	Console.Write("Укажите натуральное трехзначное число (от 100 до 999): ");
	a = Convert.ToInt32(Console.ReadLine());
}
string str_a = a.ToString();
char[] ch = str_a.ToCharArray();
Array.Reverse(ch);
str_a = String.Concat(ch[0], ch[1], ch[2]);
// a = Int32.Parse(str_a); 
// Если выводить на консоль "инотовое а", при вводе 500, реверс будет 5, а не 005
Console.WriteLine($"Ваше число задом наперёд: {str_a}");
Console.ReadKey();

/* Expr3. 
Задано время Н часов (ровно). 
Вычислить угол в градусах между часовой и минутной стрелками. 
Например, 5 часов -> 150 градусов, 20 часов -> 120 градусов. 
Не использовать циклы. */

Console.Write("Укажите число от 0 до 11: ");
int hour = Convert.ToInt32(Console.ReadLine());
if (hour >= 0 && hour <= 6)
{
	Console.WriteLine(hour * 30);
}	
else if (hour >= 7 && hour <= 11)
{
	Console.WriteLine((12 - hour) * 30);
}


/* Expr4. 
Найти количество чисел меньших N, которые имеют простые делители X или Y. */

Console.Write("Найти количество чисел меньших N, которые имеют простые делители X или Y.\nУкажите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите делитель X: ");
int X = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите делитель Y: ");
int Y = Convert.ToInt32(Console.ReadLine());
int increment = 0;

for (int circles = N - 1; circles > 0; circles--)
{
	if ((circles % X == 0) || (circles % Y == 0))
	{
		increment++;
	}	
}	

Console.WriteLine($"Количество чисел меньших {N}, которые имеют простые делители {X} или {Y}: {increment}.");


/* Expr5. 
Найти количество високосных лет на отрезке [a, b]. */

Console.Write("Найти количество високосных лет на отрезке.\nУкажите год начала отсчёта: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите год завершения отсчёта: ");
int b = Convert.ToInt32(Console.ReadLine());
int increment = 0;

for (int circles = b; a <= circles; circles--)
{
	if (circles % 4 == 0)
	{
		increment++;
	}	
}	

Console.WriteLine($"Количество високосных лет на отрезке от {a} до {b}: {increment}.");


/* Expr5. 
Найти количество високосных лет на отрезке [a, b] не используя циклы. */

Console.Write("Найти количество високосных лет на отрезке.\nУкажите год начала отсчёта: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите год завершения отсчёта: ");
int b = Convert.ToInt32(Console.ReadLine());
int qty = 0;

if (b - a == 1)
{
	qty = ((a % 4 == 0) || (b % 4 == 0)) ? 1 : 0;
}
else if (b - a == 2)
{
	qty = ((a % 4 == 0) || (b % 4 == 0) || ((b - 1) % 4 == 0)) ? 1 : 0;
}	
else if (b - a == 3)
{
	qty = 1;
}
else if (b - a >= 4)
{
	qty += (a % 4 == 0) ? 1 : 0;
        qty += (b % 4 == 0) ? 1 : 0;
        qty += (qty == 2) ? ((b - 1) - (a + 1)) / 4 : (b - a) / 4; 
}
Console.WriteLine($"Количество високосных лет на отрезке от {a} до {b}: {qty}.");
Console.ReadKey();
