

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio7 : MonoBehaviour
{
    int[] array = new int[20];

    void Start()
    {

        GeneraArray(array, 1, 100);
        StampaArray();
        SommaArray();
    }

    void Update()
    {

    }

    public int[] GeneraArray(int[] array, int min, int max)
    {

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Random.Range(min, max + 1);
        }

        return array;

    }

    void StampaArray()
    {
        string stampa = string.Join(", ", array);
        Debug.Log(stampa);
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
}
