using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class Animal
{
    public virtual void AnimalSound()
    {
        Console.WriteLine("nunu");
    }
}

public class Dog : Animal
{
    public override void AnimalSound()
    {
        Console.WriteLine("Bark");
    }
}

public class Cat : Animal
{
    public override void AnimalSound()
    {
        Console.WriteLine("Meow");
    }
}

public class Program
{
    public static void Main()
    {
        Cat catObj = new Cat();
        Dog dogObj = new Dog();

        catObj.AnimalSound();
        dogObj.AnimalSound();
    }
}
