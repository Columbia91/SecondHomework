using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            while (true)
            {
                Tasks(); // вызов функции, в котором перечислены задания
                Console.Write("Введите номер задания: ");
                choice = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (choice)
                {
//***********************************************************************************
                    case 1:                                         
                        Random rnd = new Random();                  
                        int[] arr = new int[3];                     
                        for (int i = 0; i < arr.Length; i++)        
                        {                                           
                            arr[i] = rnd.Next(10);                  
                            Console.Write(arr[i] + "  ");           
                        }                                           
                        break;                                      
//************************************************************************************
                    case 2:                                                             
                        const int NUMB1 = 5, NUMB2 = 10, NUMB3 = 21;                    
                        Console.Write(NUMB1 + "\n" + NUMB2 + "\n" + NUMB3);             
                        break;
//************************************************************************************
                    case 3:
                        Console.Write("Введите расстояние в сантиметрах: ");
                        int distance = int.Parse(Console.ReadLine());
                        Console.Write("Это эквивалентно - " + distance / 100 + " м");
                        break;
//************************************************************************************
                    case 4:
                        int pastDays = 234, daysInWeek = 7;
                        Console.Write("Прошло " + pastDays + " дня\nПрошло полных недель - " + (pastDays / daysInWeek));
                        break;
//************************************************************************************
                    case 5:
                        Random rand = new Random();
                        int firstNumb, secondNumb, count = 0;
                        int twoDigitNumber = rand.Next(10, 100);
                        if ((firstNumb = twoDigitNumber / 10) == 1) count++;
                        if ((secondNumb = twoDigitNumber % 10) == int.Parse("1")) count++;

                        Console.WriteLine("Дано двузначное число: " + twoDigitNumber);
                        Console.Write("Число десятков в нем - " + twoDigitNumber / 10 +
                            "\nЧисло единиц в нем - " + count +
                            "\nСумма его цифр - " + (firstNumb + secondNumb) +
                            "\nПроизведение его цифр - " + (firstNumb * secondNumb));
                        break;
//************************************************************************************
                    case 6:
                        bool A = true, B = false, C = false;

                        Console.WriteLine("A = true, B = false, C = false\n");
                        Console.WriteLine("A или B - " + (A || B ? A : B));
                        Console.WriteLine("A и B - " + (A && B ? A : B));
                        Console.WriteLine("B или C - " + (B || C ? B : C));
                        break;
//************************************************************************************
                    case 7:
                        const double PI = 3.14;
                        double circleArea, squareArea;

                        Console.Write("Введите радиус круга: ");
                        int radius = int.Parse(Console.ReadLine());
                        Console.Write("Введите сторону квадрата: ");
                        int sideOfSquare = int.Parse(Console.ReadLine());

                        circleArea = PI * Math.Pow(radius, 2); // S = PI * R^2
                        squareArea = sideOfSquare * sideOfSquare; // S = a^2

                        Console.Write(circleArea > squareArea ?
                            "\nУ круга площадь больше чем у квадрата" : "\nУ квадрата площадь больше чем у круга");
                        break;
//************************************************************************************
                    case 8:
                        Console.Write("Введите объем 1-тела: "); int amount = int.Parse(Console.ReadLine());
                        Console.Write("Введите массу 1-тела: "); int mass = int.Parse(Console.ReadLine());
                        double densityOfMaterial = mass / amount; // p = m/V

                        Console.Write("Введите объем 2-тела: "); amount = int.Parse(Console.ReadLine());
                        Console.Write("Введите массу 2-тела: "); mass = int.Parse(Console.ReadLine());
                        double densityOfMaterial_2 = mass / amount;

                        Console.Write(densityOfMaterial > densityOfMaterial_2 ?
                            "\nПлотность 1-тела больше чем у 2-тела" : "\nПлотность 2-тела больше чем у 1-тела");
                        break;
//************************************************************************************
                    case 9:
                        Console.Write("Введите значение напряжения эл. цепи № 1: "); int voltage = int.Parse(Console.ReadLine());
                        Console.Write("Введите значение сопротивления эл. цепи № 1: "); int resistance = int.Parse(Console.ReadLine());
                        double current = voltage / resistance; // I = U/R

                        Console.Write("Введите значение напряжения эл. цепи № 2: "); voltage = int.Parse(Console.ReadLine());
                        Console.Write("Введите значение сопротивления эл. цепи № 2: "); resistance = int.Parse(Console.ReadLine());
                        double current_2 = voltage / resistance;

                        Console.Write(current < current_2 ?
                            "\nПо первому участку протекает меньший ток" : "\nПо второму участку протекает меньший ток");
                        break;
//************************************************************************************
                    case 10:
                        int numb = 20, numb2 = 35, numb3 = 10, numb4 = 50;
                        int a, b;
                        while (true)
                        {
                            Console.Write("Введите число a: "); a = int.Parse(Console.ReadLine());
                            Console.Write("Введите число b: "); b = int.Parse(Console.ReadLine());
                            if (a < b && a < numb4 && b > numb3) break;
                            else Console.WriteLine("Ошибка! Необходимо чтобы было a < b && a < 50 && b > 10");
                        }

                        Console.SetCursorPosition(0, 3);
                        Console.Write("ч от " + numb + " до " + numb2);
                        for (int i = numb, j = 4; i < numb2 + 1; i++, j++)
                        {
                            Console.SetCursorPosition(5, j);
                            Console.Write(i);
                        }

                        Console.SetCursorPosition(15, 3);
                        Console.Write("кв ч от " + numb3 + " до " + b);
                        for (int i = numb3, j = 4; i < b; i++, j++)
                        {
                            Console.SetCursorPosition(20, j);
                            Console.Write(i * i);
                        }

                        Console.SetCursorPosition(35, 3);
                        Console.Write("ч от " + a + " до " + b);
                        for (int i = a, j = 4; i < b; i++, j++)
                        {
                            Console.SetCursorPosition(40, j);
                            Console.Write(i);
                        }

                        Console.SetCursorPosition(50, 3);
                        Console.Write("куб ч от " + a + " до " + numb4);
                        for (int i = a, j = 4; i < numb4; i++, j++)
                        {
                            Console.SetCursorPosition(55, j);
                            Console.Write(Math.Pow(i, 3));
                        }
                        break;
//************************************************************************************
                    default:
                        break;
                }
                Console.Write("\n\nДля продолжения нажмите ENTER");
                Console.ReadLine();
                Console.Clear();
            }
        }
        static void Tasks()
        {
            Console.WriteLine("1. Составить программу вывода на экран в одну строку трех любых чисел с двумя пробелами между ними." +
"\n2. Вывести на экран числа 5, 10 и 21 одно под другим." +
"\n3. Дано расстояние в сантиметрах.Найти число полных метров в нем." +
"\n4. С некоторого момента прошло 234 дня.Сколько полных недель прошло за этот период ?" +
"\n5. Дано двузначное число. Найти:" +
            "\n\ta. число десятков в нем;" +
            "\n\tb. число единиц в нем;" +
            "\n\tc. сумму его цифр;" +
            "\n\td. произведение его цифр" +
"\n6.Вычислить значение логического выражения при следующих значениях логических величин А, В и С: А = Истина, В = Ложь, С = Ложь:" +
            "\n\ta. А или В;" +
            "\n\tb. А и В;" +
            "\n\tc. В или С." +
"\n7. Даны радиус круга и сторона квадрата.У какой фигуры площадь больше ?" +
"\n8. Даны объемы и массы двух тел из разных материалов.Материал какого из тел имеет большую плотность ?" +
"\n9. Известны сопротивления двух несоединенных друг с другом участков электрической цепи и напряжение на каждом из них. По какому участку протекает меньший ток?" +
"\n10. Напечатать столбиком: " +
            "\n\ta. все целые числа от 20 до 35;" +
            "\n\tb. квадраты всех целых чисел от 10 до b(значение b вводится с клавиатуры; b > 10);" +
            "\n\tc. третьи степени всех целых чисел от a до 50(значение a вводится с клавиатуры; a < 50);" +
            "\n\td. все целые числа от a до b(значения a и b вводятся с клавиатуры; b > a)."
);
        }
    }
}