using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Datatype : MonoBehaviour
{
    int integerNumber;
    float floatNumber;
    double doubleNumber;

    // Start is called before the first frame update
    void Start()
    {
        integerNumber = 8;
        Debug.Log(integerNumber);
        floatNumber = 1.5f;
        Debug.Log(floatNumber);
        doubleNumber = 1.234567890123;
        Debug.Log(doubleNumber);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
