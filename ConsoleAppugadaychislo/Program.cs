do
{
    // 1. Загадываем число от 1 до 100
    Random rnd = new Random();
    int sekret = rnd.Next(1, 101);

    int popytki = 7; 

    Console.WriteLine("--- Новая игра! Я загадал число от 1 до 100 ---");

    // 2. Игровой цикл для попыток
    while (popytki > 0)
    {
        Console.Write($"У вас осталось {popytki} попыток. Введите число: ");
        int otvet = Convert.ToInt32(Console.ReadLine());

        if (otvet == sekret)
        {
            Console.WriteLine("Поздравляю! Вы выиграли!");
            popytki = 0; // Обнуляем попытки, чтобы выйти из цикла 
        }
        else if (otvet < sekret)
        {
            Console.WriteLine("Загаданное число больше.");
            popytki = popytki - 1; 
        }
        else
        {
            Console.WriteLine("Загаданное число меньше.");
            popytki = popytki - 1; 
        }

        // Проверяем: eckb gjgsnrb rjyxbkcm b yt gjkexbkjcm euflfnm
        if (popytki == 0 && otvet != sekret)
        {
            Console.WriteLine($"Вы проиграли! Было загадано число: {sekret}");
        }
    }

    
    Console.Write("Хотите сыграть снова? (да/нет): ");
}
while (Console.ReadLine() == "да"); // Если ввели "да", цикл do-while запустится заново

// 4. Ожидание Enter перед выходом
Console.WriteLine("Нажмите Enter для выхода...");
Console.ReadLine();

