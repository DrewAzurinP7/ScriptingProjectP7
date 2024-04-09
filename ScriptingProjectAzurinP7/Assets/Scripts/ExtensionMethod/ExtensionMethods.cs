using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ExtensionMethods 
{
   public static void ResetTransformation(this Transform trans)
    {
        trans.position = Vector3.zero;
        trans.localRotation = Quaternion.identity;
        trans.localScale = new Vector3(3, 3, 3);
    }
}
