using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //static variables are shared across all instances of a class.
    public static int enemyCount = 0;

    public Enemy()
    {
        //Increment the static variable to know how many objects of this class has been created.
        enemyCount++;
    }
}
