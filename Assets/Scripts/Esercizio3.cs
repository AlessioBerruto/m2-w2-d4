using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio3 : MonoBehaviour
{
    public int numero = 0;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 1; i <= 30; i++)
        {
            if (numero % 3 == 0 && numero % 5 == 0)
            {
                Debug.Log("FizzBuzz");
            }
            else if (numero % 5 == 0)
            {
                Debug.Log("Buzz");
            }
            else if (numero % 3 == 0)
            {
                Debug.Log("Fizz");
            }
            else
            {
                Debug.Log(i);
            }            
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
