using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio5 : MonoBehaviour
{
    //Ho seguito la consegna dell'esercizio e ho provato a modificare il codice.
    //Ho simulato il lancio di un dado a 6 facce

    public int find = 0;
    int[] array = new int[6];

    // Start is called before the first frame update
    void Start()
    {
        find = Random.Range(1, array.Length + 1);
        Debug.Log("Il numero scelto è: " + find);
        Debug.Log("Lancio un dado...");

        for (int i = 0; i < array.Length; i++)
        {
            
            int num = Random.Range(1, array.Length+1);

            if (num == find)
            {               
                Debug.Log("Il risultato del lancio è: " + num + " (found)");
            }
            else
            {                
                Debug.Log("Il risultato del lancio è: " + num + " (not found)");
            }
        }
        Debug.Log("iterations finished");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
