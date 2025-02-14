/* Составить программу, которая считывает с клавиатуры числа и четные 
записывает в файл even.txt, нечетные записывает в файл odd.txt. Считывать числа до тех 
пор, пока не введено число 0. Далее рассчитать сумму нечетных чисел и произведение 
четных чисел. */

// 6 варивант

StreamWriter evenwriter = new StreamWriter("even.txt");
StreamWriter oddwriter = new StreamWriter("odd.txt");

while (true)
{
    string input = Console.ReadLine();

    if (int.TryParse(input, out int number))
    {
        if (number == 0)
            break;
        if (number % 2 == 0)
            evenwriter.WriteLine(number);
        else
            oddwriter.WriteLine(number);
    }
    else
    {
        Console.WriteLine("Введите целое число");
    }
}



evenwriter.Close();
oddwriter.Close();

Console.WriteLine("\nЧетные числа: ");
Console.WriteLine(File.ReadAllText("even.txt")); // вывод четных
Console.WriteLine("\nНечетные числа: ");
Console.WriteLine(File.ReadAllText("odd.txt")); // вывод нечетных












