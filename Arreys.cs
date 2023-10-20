//Створіть інтерфейс IOutput2. У ньому мають бути два методи:
//■ void ShowEven() — відображає парні значення контейнера з даними;
//■ void ShowOdd() — відображає непарні значення контейнера з даними.
//Клас, створений раніше у практичному завданні Array, має імплементувати інтерфейс IOutput2.
//Метод ShowEven — відображає парні значення з масиву.
//Метод ShowOdd — відображає непарні значення масиву.
//Напишіть код для тестування отриманої функціональності.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_Homework_6_3
{
    internal class Arreys : IOutput2
    {
        int[] ar;
        public Arreys(int size)
        {
            Console.Write("Введіть нижню межу рандомних значень масиву: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введіть нижню межу рандомних значень масиву: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Random r = new Random();
            ar = new int[size];
            for (int i = 0; i < size; i++)
            {
                ar[i] = r.Next(a, b);
            }
        }
        public void Input(int size)
        {
            ar = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Введіть значення елементу {i + 1}: ");
                ar[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
        }
        public void Show()
        {
            Console.Write("Елементи масиву:\n");
            for (int i = 0; i < ar.Length; i++)
            {
                Console.Write($"{ar[i]} ");
            }
            Console.WriteLine();
        }
        public void RandShow()
        {
            Array.Sort(ar);
             foreach (int i in ar)
                {
                    Console.Write($"{i} ");
                }
            }
        public void ShowEven()
        {
            for(int i = 0;i < ar.Length; i++)
            {
                if (ar[i] % 2 == 0)
                {
                    Console.Write($"{ar[i]} ");
                }
            }
        }
        public void ShowOdd()
        {
            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] % 2 != 0)
                {
                    Console.Write($"{ar[i]} ");
                }
            }
        }
    }
 }
