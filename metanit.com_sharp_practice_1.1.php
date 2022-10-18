// Упражнение 1
/* Напишите консольную программу, в которую пользователь вводит с клавиатуры два числа. А программа сранивает два введенных числа и выводит на консоль результат сравнения (два числа равны, первое число больше второго или первое число меньше второго). */
Console.Write("Укажите первое число: ");
int first_num = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите второе число: ");
int second_num = Convert.ToInt32(Console.ReadLine());
if (first_num > second_num)
{
	Console.WriteLine($"Первое число больше второго.");
}
else if (first_num < second_num)
{
	Console.WriteLine($"Первое число меньше второго.");
}
else
{
	Console.WriteLine($"Два числа равны.");
}

// Упражнение 2
/* Напишите консольную программу, в которую пользователь вводит с клавиатуры число. Если число одновременно больше 5 и меньше 10, то программа выводит "Число больше 5 и меньше 10". Иначе программа выводит сообщение "Неизвестное число". */
Console.Write("Укажите любое число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 5 && num < 10) 
{
	Console.WriteLine("Число больше 5 и меньше 10.");
}
else
{
	Console.WriteLine("Неизвестное число.");
}

// Упражнение 3
/* Напишите консольную программу, в которую пользователь вводит с клавиатуры число. Если число либо равно 5, либо равно 10, то программа выводит "Число либо равно 5, либо равно 10". Иначе программа выводит сообщение "Неизвестное число". */
Console.Write("Укажите любое число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num == 5 || num == 10) 
{
	Console.WriteLine("Число либо равно 5, либо равно 10.");
}
else
{
	Console.WriteLine("Неизвестное число.");
}

// Упражнение 4
/* В банке в зависимости от суммы вклада начисляемый процент по вкладу может отличаться. Напишите консольную программу, в которую пользователь вводит сумму вклада. Если сумма вклада меньше 100, то начисляется 5%. Если сумма вклада от 100 до 200, то начисляется 7%. Если сумма вклада больше 200, то начисляется 10%. В конце программа должна выводить сумму вклада с начисленными процентами.
Для получения вводимого с клавиатуры числа используйте выражение Convert.ToDouble(Console.ReadLine()) */
Console.Write("Укажите сумму вклада: ");
double num = Convert.ToDouble(Console.ReadLine());
double num1 = num * 0.05 + num;
double num2 = num * 0.07 + num;
double num3 = num * 0.1 + num;
if (num < 100)
{
	Console.WriteLine($"Итог: {num1} руб.");
}
else if (num >= 100 && num < 200)
{
	Console.WriteLine($"Итог: {num2} руб.");
}
else 
{
	Console.WriteLine($"Итог: {num3} руб.");
}

// Упражнение 5
/* Изменим предыдущую задачу. Допустим, банк периодически начисляет по всем вкладам кроме процентов бонусы. И, допустим, сейчас банк решил доначислить по всем вкладам 15 единиц вне зависимости от их суммы. Измените программу таким образом, чтобы к финальной сумме дочислялись бонусы. */
Console.Write("Укажите сумму вклада: ");
double num = Convert.ToDouble(Console.ReadLine());
double num1 = num * 0.05 + num + 15;
double num2 = num * 0.07 + num + 15;
double num3 = num * 0.1 + num + 15;
if (num < 100)
{
	Console.WriteLine($"Итог: {num1} руб.");
}
else if (num >= 100 && num < 200)
{
	Console.WriteLine($"Итог: {num2} руб.");
}
else 
{
	Console.WriteLine($"Итог: {num3} руб.");
}

// Упражнение 6
/* Напишите консольную программу, которая выводит пользователю сообщение "Введите номер операции: 1.Сложение 2.Вычитание 3.Умножение". Рядом с названием каждой операции указан ее номер, например, операция вычитания имеет номер 2. Пусть пользователь вводит в программу номер операции, и в зависимости от номера операции программа выводит ему название операции.
Для определения операции по введенному номеру используйте конструкцию switch...case.
Если введенное пользователем число не соответствует никакой операции (например, число 120), то выведите пользователю сообщение о том, что операция неопределена. */
Console.Write("Введите номер операции:\n1 - Сложение\n2 - Вычитание\n3 - Умножение\n4 - Деление\n	>> ");
int num = Convert.ToInt32(Console.ReadLine());
switch (num)
{
	case 1:
		Console.WriteLine("Вы выбрали сложение.");
		break;
	case 2:
    Console.WriteLine("Вы выбрали вычитание.");
		break;	
	case 3:
    Console.WriteLine("Вы выбрали умножение.");
		break;	
	case 4:
    Console.WriteLine("Вы выбрали деление.");
		break;
	default:
		Console.WriteLine("Операция неопределена.");
		break;
}

// Упражнение 7
/* Измените предыдущую программу. Пусть пользователь кроме номера операции вводит два числа, и в зависимости от номера операции с введенными числами выполняются определенные действия (например, при вводе числа 3 числа умножаются). Результа операции выводиться на консоль. */
Console.Write("Укажите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Укажите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите номер операции:\n1 - Сложение\n2 - Вычитание\n3 - Умножение\n4 - Деление\n	>> ");
int motion = Convert.ToInt32(Console.ReadLine());
switch (motion)
{
	case 1:
		num1 += num2;
	    Console.WriteLine($"Ответ: {num1}");
	    break;
	case 2:
		num1 -= num2;
      Console.WriteLine($"Ответ: {num1}");
	    break;	
	case 3:
		num1 *= num2;
      Console.WriteLine($"Ответ: {num1}");
	    break;	
	case 4:
		num1 /= num2;
      Console.WriteLine($"Ответ: {num1}");
	    break;
	default:
		Console.WriteLine("Операция неопределена.");
		break;
}