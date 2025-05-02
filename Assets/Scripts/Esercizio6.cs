using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio6 : MonoBehaviour
{
    int[] array = null;
    
    // Start is called before the first frame update
    void Start()
    {
        GeneraArray();
        StampaArray();
        SommaArray();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void GeneraArray()
    {
        array = new int[20];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Random.Range(1, 101);            
        }

    }

    void SommaArray()
    {
        int risultato = 0;

        for (int i = 0; i < array.Length; i++)
        {
            risultato += array[i];
        }

        Debug.Log("La somma è: " + risultato);
    }

    void StampaArray()
    {
        string stampa = string.Join(", ", array);
        Debug.Log(stampa);
    }
}
