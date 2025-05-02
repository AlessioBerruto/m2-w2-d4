using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio4 : MonoBehaviour
{
    public int start = 5;
    public int amount = 3;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = start; i <= (start + amount); i++)
        {
            Debug.Log(i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
