using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


class Car2
{
    private string Car2_model = "Shelby";
}
class Car
{
    public string model;
    public string color;
    public int year;
    Car(string model,int year,string color) {
        model = model;
        color = color;
        year = year;

    }

    static void Main(string[] args)
    {
        Car carObj = new Car("Ford",5,"Red");

        Console.WriteLine(carObj.model);
    }


}
