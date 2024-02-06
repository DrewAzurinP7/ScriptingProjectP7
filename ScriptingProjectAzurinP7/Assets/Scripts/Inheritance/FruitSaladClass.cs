using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSaladClass : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Creating the fruit");
        FruitClass myFruit = new FruitClass();
        Debug.Log("Creating the apple");
        AppleClass myApple = new AppleClass();

        myFruit.sayHello();
        myFruit.Chop();

        myApple.sayHello();
        myApple.Chop();

        Debug.Log("Creating the fruit");
        myFruit = new FruitClass("yellow");
        Debug.Log("Creating the apple");
        myApple = new AppleClass("green");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
