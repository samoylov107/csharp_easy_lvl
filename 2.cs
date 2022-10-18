// Упражнение 1
/* За каждый месяц банк начисляет к сумме вклада 7% от суммы. Напишите консольную программу, в которую пользователь вводит сумму вклада и количество месяцев. А банк вычисляет конечную сумму вклада с учетом начисления процентов за каждый месяц.
Для вычисления суммы с учетом процентов используйте цикл for. Для ввода суммы вклада используйте выражение Convert.ToDecimal(Console.ReadLine()) (сумма вклада будет представлять тип decimal). */
Console.Write("Укажите сумму вклада: ");
decimal vklad = Convert.ToDecimal(Console.ReadLine());

Console.Write("Укажите количество месяцев: ");
int months_qty = Convert.ToInt32(Console.ReadLine());

if (months_qty > 1)
{
	for (int circle = 1; circle <= months_qty; circle++)
	{
		vklad += vklad * 0.07m;
	}
	Console.WriteLine($"Накопленная сумма по завершению вклада {vklad.ToString("0.00")} руб.");
}
else
{
	Console.WriteLine("Минимальный срок вклада - 1 месяц.");
}

// Упражнение 2
/* Перепишите предыдущую программу, только вместо цикла for используйте цикл while. */
Console.Write("Укажите сумму вклада: ");
decimal vklad = Convert.ToDecimal(Console.ReadLine());

Console.Write("Укажите количество месяцев: ");
int months_qty = Convert.ToInt32(Console.ReadLine());

if (months_qty > 1)
{
	int circle = 1;
	while (circle <= months_qty)
	{
		vklad += vklad * 0.07m;
		circle++;
	}
	Console.WriteLine($"Накопленная сумма по завершению вклада {vklad.ToString("0.00")} руб.");
}
else
{
	Console.WriteLine("Минимальный срок вклада - 1 месяц.");
}

// Упражнение 3
/* Напишите программу, которая выводит на консоль таблицу умножения */
// не сам писал, почему-то был такой пример в статье, не сильно понимаю, что как тут работают между собой Console.Write и Console.WriteLine и почему без последней всё криво
for (int i = 1; i <= 10; i++)
{
    for (int j = 1; j <= 10; j++)
    {
        Console.Write($"{i * j} \t");
    }
    Console.WriteLine();
}

// Упражнение 4
/* Напишите программу, в которую пользователь вводит два числа и выводит результат их умножения. При этом программа должны запрашивать у пользователя ввод чисел, пока оба вводимых числа не окажутся в диапазоне от 0 до 10. Если введенные числа окажутся больше 10 или меньше 0, то программа должна вывести пользователю о том, что введенные числа недопустимы, и повторно запросить у пользователя ввод двух чисел. Если введенные числа принадлежат диапазону от 0 до 10, то программа выводит результат умножения.
Для организации ввода чисел используйте бесконечный цикл while и оператор break. */

Console.Write("Укажите первое число от 0 до 10: ");
int	num1 = Convert.ToInt32(Console.ReadLine());
while (num1 < 0 || num1 > 10)
{
	Console.Write("Введено недопустимое число - укажите первое число от 0 до 10: ");
	num1 = Convert.ToInt32(Console.ReadLine());
	/* if (num1 >= 0 && num1 <= 10)
		break; странное задание - циклу не нужен брейк */
}

Console.Write("Укажите второе число от 0 до 10: ");
int	num2 = Convert.ToInt32(Console.ReadLine());
while (num2 < 0 || num2 > 10)
{
	Console.Write("Введено недопустимое число - укажите второе число от 0 до 10: ");
	num2 = Convert.ToInt32(Console.ReadLine());
	/* if (num2 >= 0 && num2 <= 10)
		break; */
}

Console.WriteLine($"Результат умножения двух чисел {num1 * num2}");
