using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitClass : MonoBehaviour
{
    

    public string color;

    public FruitClass()
    {
        color = "orange";
        Debug.Log("1st Fruit Constructor Called");
    }

    public FruitClass(string newColor)
    {
        color = newColor;
        Debug.Log("2nd Fruit Constructor Called");
    }

    public void Chop()
    {
        Debug.Log("The " + color + " fruit has been chopped.");
    }

    public void sayHello()
    {
        Debug.Log("Hello, I'm a fruit.");
    }
}
