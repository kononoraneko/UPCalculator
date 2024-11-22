using System;
using ArithmeticClassLibrary;

class IOSystem
{

    public IOSystem()
    {

    }

    public void start()
    {
        ArithmeticMethods arith = new ArithmeticMethods();
        while (true)
        {
            int key = readSelectMenu();

            if (key == 0)
            {
                return;
            }
            if (key == 1)
            {
                int[] res = readNums(2);
                arith.printIntSum(res[0], res[1]);
            }
            if (key == 2)
            {
                int[] res = readNums(2);
                arith.printIntDiff(res[0], res[1]);
            }
            if (key == 3)
            {
                int[] res = readNums(1);
                Console.WriteLine($"Угол в {res[0]} градусов - {arith.angleName(res[0])}");
            }
            if (key == 4)
            {
                int[] res = readNums(1);
                Console.WriteLine($"Факториал от {res[0]} - {arith.factorial(res[0])}");
            }
            if (key == 5)
            {   
                int[] res = readNums(1);
                Func<bool, string> isEven = x => x ? "Чётное" : "Нечётное";  
                Console.WriteLine($"Число {res[0]} - {isEven(arith.isIntEven(res[0]))}");
            }

        }
    }

    private int[] readNums (int count)
    {
        int[] res = new int[count];

        for (int i = 0; i < count; i++)
        {
            Console.Write("Введите число: ");
            int parsedInt;
            while (!int.TryParse(Console.ReadLine(), out parsedInt))
            {
                Console.WriteLine("Ошибка ввода! Попробйте заново!\nВведите число: ");
            }
            res[i] = parsedInt;
        }

        return res;
    }

    int readSelectMenu()
    {
        Console.WriteLine(
    @"
    Выберите операцию:
    1. Сложение
    2. Вычитание
    3. Узнать тип угла
    4. Найти факториал
    5. Число чётное?
    0. Выход
    ");
        int key;
        while (!int.TryParse(Console.ReadLine(), out key))
        {
            Console.WriteLine("Ошибка ввода!");
        }
        return key;
    }

}
