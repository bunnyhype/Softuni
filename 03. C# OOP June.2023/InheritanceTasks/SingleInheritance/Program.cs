﻿namespace Farm
{
    public class StartUp
    {

        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Bark();

            Cat cat = new Cat();
            cat.Meow(); 
            cat.Eat();
        }
    }
}