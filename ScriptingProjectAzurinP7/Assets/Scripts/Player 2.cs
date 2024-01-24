using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    //Static variables are shared across all instances of a class.
    public static int playerCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        //Inrement the static variable to know how many objects of this class has been created.
        playerCount++;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
