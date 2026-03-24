using System;

namespace Variant10
{
    // Класс Собака
    class Dog
    {
        private string nickname;
        private string breed;
        private float age;

        public Dog()
        {
            nickname = "Неизвестно";
            breed = "Неизвестно";
            age = 0f;
        }

        public Dog(string nickname, string breed, float age)
        {
            this.nickname = nickname;
            this.breed = breed;
            this.age = age;
        }

        public void Print()
        {
            Console.WriteLine($"Кличка: {nickname}");
            Console.WriteLine($"Порода: {breed}");
            Console.WriteLine($"Возраст: {age} лет");
            Console.WriteLine(new string('-', 30));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Демонстрация класса Dog");
            Console.WriteLine();

            Dog dog1 = new Dog();
            Console.WriteLine("Объект dog1 (конструктор по умолчанию):");
            dog1.Print();

            Dog dog2 = new Dog("Рекс", "Немецкая овчарка", 3.5f);
            Console.WriteLine("Объект dog2 (конструктор с параметрами):");
            dog2.Print();

            Dog dog3 = new Dog("Шарик", "Дворняга", 1.2f);
            Console.WriteLine("Объект dog3:");
            dog3.Print();

            Console.ReadKey();
        }
    }
}