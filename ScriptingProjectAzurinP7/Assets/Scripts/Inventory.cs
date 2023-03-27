using Palmmedia.ReportGenerator.Core.Reporting.Builders;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public class stuff
    {
        public int bullets;
        public int grenades;
        public int rockets;
        public float fuel;

        public stuff(int bul, int gre, int roc)
        {
            bullets = bul;
            grenades = gre;
            rockets = roc;
        }

        public stuff(int  bul, float fu)
        {
            bullets = bul;
            fuel = fu;
        }

        //Constructor
        public stuff ()
        {
            bullets = 1;
            grenades = 1;
            rockets = 1;
        }
    }

    public stuff myStuff = new stuff(50, 5, 5);

    public stuff myOtherStuff = new stuff(50, 1.5f);
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(myStuff.bullets);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
