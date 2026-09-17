// Console.WriteLine("Привет от ИСп-244");
// Console.WriteLine("Автор: Васильев Юрий");
// Console.WriteLine("Год: 2026");
// int age = 20;
// double gpa = 4.5;
// bool isStudent = true;
// string name = "Юрий";
// Console.WriteLine(name);
// Console.WriteLine(age);
// Console.WriteLine(gpa);
// Console.WriteLine(isStudent);
// var city = "Москва";
// var year = 2026;
// var pi = 3.14159;
// var isActive = true;
// string myName = "Юрий";
// int myAge = 18;
// string myGroup = "ИСП-241";
// Console.WriteLine($"Меня зовут {myName}, мне {myAge} лет, я учусь в группе {myGroup}.");
// Console.Write("Введите ваше имя: ");
// string name2 = Console.ReadLine();
// Console.WriteLine($"Привет, {name2}");
// Console.Write("Введите ваш возраст: ");
// string input = Console.ReadLine();
// int age2 = int.Parse(input);
// Console.WriteLine($"Через 10 лет вам будет {age2 + 10} лет.");
// int x = 10;
// int y = 3;
// Console.WriteLine(x + y);
// Console.WriteLine(x - y);
// Console.WriteLine(x * y);
// Console.WriteLine(x / y);
// Console.WriteLine(x % y);
// string firstName = "Юрий";
// string lastName = "Васильев";
// string group = "ИСП-241";
// int birthYear = 2008;
// double gpa = 4.5;
// bool hasScholarship = true;
// int currentYear = 2026;
// int age = currentYear - birthYear;
// Console.WriteLine("Студенческое удостоверение");
// Console.WriteLine($"Имя: {firstName} {lastName}");
// Console.WriteLine($"Группа: {group}");
// Console.WriteLine($"Возраст: {age} лет.");
// Console.WriteLine($"Средний балл: {gpa}");
// Console.WriteLine($"Степендия: {hasScholarship}");
// int a = 15;
// int b = 4;
// Console.WriteLine($"Сумма: {a + b}");
// Console.WriteLine($"Разность: {a - b}");
// Console.WriteLine($"Произведение: {a * b}");
// Console.WriteLine($"Частное (int): {a / b}");
// Console.WriteLine($"Остаток: {a % b}");
// double result = (double)a / b;
// Console.WriteLine($"Частное (double): {result}");
// Console.WriteLine(Math.Abs(-5));
// Console.WriteLine(Math.Pow(2,10));
// Console.WriteLine(Math.Sqrt(144));
// Console.WriteLine(Math.Max(10,25));
// Console.WriteLine(Math.Min(10,25));
// Console.WriteLine(Math.Round(3.567,2));
// Console.WriteLine("Калькулятор");
// Console.WriteLine("Введите первое число: ");
// double num1 = double.Parse(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// double num2 = double.Parse(Console.ReadLine());
// Console.WriteLine($"Сумма: {num1 + num2}");
// Console.WriteLine($"Разность: {num1 - num2}");
// Console.WriteLine($"Произведение: {num1 * num2}");
// if (num2 != 0)
// {
//     Console.WriteLine($"Частное (int): {num1 / num2}");
// } 
// else
// {
//     Console.WriteLine("Деление на ноль невозможно!");
// }
// Console.WriteLine(int.MaxValue);
// Console.WriteLine(int.MinValue);
// Console.WriteLine(double.MaxValue);
// Console.WriteLine(double.MaxValue);
// Console.WriteLine("Добро пожаловать в анкету!");
// Console.Write("Введите ваше имя: ");
// string name = Console.ReadLine();
// Console.Write("Введите вашу фамилию: ");
// string surname = Console.ReadLine();
// Console.Write("Введите вашу группу: ");
// string group = Console.ReadLine();
// Console.Write("Введите ваш год рождения: ");
// int birthYear = int.Parse(Console.ReadLine());
// Console.Write("Введите ваш средний балл (например, 4.5): ");
// double gpa = double.Parse(Console.ReadLine());
// int currentYear = 2026;
// int age = currentYear - birthYear;
// bool isExcellent = gpa >= 4.5;
// string status;
// if (isExcellent == true)
// {
//     status = "Отличник";
// }
// else
// {
//     status = "Хорошист";
// }
// Console.WriteLine("Ваша анкета");
// Console.WriteLine($"Имя:            {name} {surname}");
// Console.WriteLine($"Группа:         {group}");
// Console.WriteLine($"Возраст:        {age} лет");
// Console.WriteLine($"Средний балл:   {gpa}");
// Console.WriteLine($"Статус: {status}");
// Console.WriteLine($"Лет до 30: {30 - age}");
// Console.WriteLine($"Нажмите enter для выхода...");
// Console.ReadLine();

/* Задание 1. Переменные */

// string kino = "Человек паук";
// int num = 23;
// double pi = 3.14;
// char letter = 'Ю';
// Console.WriteLine(kino);
// Console.WriteLine(num);
// Console.WriteLine(pi);
// Console.WriteLine(letter);

/* Задание 2. Напишите программу, которая выводит на 4 строчках I need more power! */

// for (int i = 0; i < 4; i++)
// {
//     Console.WriteLine("I need more power!");
// }

/* Задание 3. Управляющая последовательность */

// Console.WriteLine("\"Hello there\"");

/* Задание 4. Стоимость покупки PC */

// Console.Write("Введите стоимость монитора: ");
// double monitor = double.Parse(Console.ReadLine());
// Console.Write("Введите стоимость Системного блока: ");
// double PC = double.Parse(Console.ReadLine());
// Console.Write("Введите стоимость клавиатуры: ");
// double keyboard = double.Parse(Console.ReadLine());
// Console.Write("Введите стоимость мыши: ");
// double mouse = double.Parse(Console.ReadLine());
// double res = monitor + PC + keyboard + mouse;
// Console.WriteLine($"Стоимость вашего компьютера: {res}");

/* Задание 5. Значение функции */

// Console.Write("Введите число a: ");
// int a = int.Parse(Console.ReadLine());
// Console.Write("Введите число b: ");
// int b = int.Parse(Console.ReadLine());
// double res = 3 * (a + b) + 275 * Math.Pow(b, 2) - 127 * a - 41;
// Console.WriteLine($"Значение функции: {res}");

/* Задание 6. Конвертер температуры */

Console.Write("Введите температуру в °C: ");
double temp = double.Parse(Console.ReadLine());
double res = ((temp * 9) / 5) + 32;
Console.WriteLine($"Температура в ℉: {res}");
 