using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
    float coffeeTempurature = 85.0f;
    float hotLimitTempurature = 70.0f;
    float coldLimitTempurature = 40.0f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            TempuratureTest();

        coffeeTempurature -= Time.deltaTime * 5f;
    }


    void TempuratureTest()
    {
        if (coffeeTempurature > hotLimitTempurature)
        {
            print("Coffee is too hot.");
        }
        else if (coffeeTempurature < coldLimitTempurature)
        {
            print("Coffee is too cold.");
        }
        else
        {
            print("Coffee is just right.");
        }
    }
}