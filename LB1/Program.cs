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

        }
    }
}