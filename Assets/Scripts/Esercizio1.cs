using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio1 : MonoBehaviour
{
    public int num = 0;
    private int index = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        while (index > 0)
        {
            Debug.Log(num);
            num++;
            index--;            
        }
    }
}
