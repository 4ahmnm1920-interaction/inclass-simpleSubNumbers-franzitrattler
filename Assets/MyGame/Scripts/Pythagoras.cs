using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pythagoras : MonoBehaviour
{
    public int value;
    public float a;
    public float b;

    void Start()
    {
        //int result = Square(value) + Square(value);
        //Debug.Log("result Addition: " + result);
        PythagorasMethode(a, b);
        float result = PythagorasMethode(a, b) + PythagorasMethode(a, b);
        Debug.Log("Result: " + result);
    }

    private void OnValidate()
    {
        //Square(value);
    }


    int Square(int a)
    {
        Debug.Log("result Square: " + a * a);
        return a * a;
    }

    float PythagorasMethode(float a, float b)
    {
        float cSquare;
        cSquare = (a * a) + (b * b);
        float c = Mathf.Sqrt(cSquare);
        Debug.Log("cSquare " + cSquare);
        Debug.Log("c: " + c);
        return c; 

    }
}
