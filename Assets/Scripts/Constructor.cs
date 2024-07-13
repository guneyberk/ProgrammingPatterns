using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

abstract class Animal
{
    public abstract void AnimalSound();
}

class Pig : Animal
{
    public override void AnimalSound()
    {
        Console.WriteLine("Pig");
    }
}

class Cat: Animal
{
    public override void AnimalSound()
    {
        Console.WriteLine("Cat");
    }
}

class Program
{

    public static void Main()
    {
        Cat catObj = new Cat();
        Pig pigObj = new Pig();

        catObj.AnimalSound();
        pigObj.AnimalSound();

    }


    


}


