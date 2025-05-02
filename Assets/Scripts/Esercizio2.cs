using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Esercizio2 : MonoBehaviour
{
    public int a = 2;
    public int b = 3;
    public int c = 4;
    public int d = 5;

    // Start is called before the first frame update
    void Start()
    {

        int[] num = new int[10];
        int Somma = 0;
        int Prodotto = 1;

        for (int i = 0; i < num.Length; i++)
        {
            num[i] = i + 1;

            Somma += num[i];
            Prodotto *= num[i]; 
        }

        Debug.Log(Somma);
        Debug.Log(Prodotto);



        //int[] numeri = { a, b, c, d };

        //for (int i = 0; i < numeri.Length; i++)
        //{
        //    int Somma = numeri[0] + numeri[1] + numeri[2] + numeri[3];
        //    int Prodotto = numeri[0] * numeri[1] * numeri[2] * numeri[3];

        //    Debug.Log(Somma);
        //    Debug.Log(Prodotto);

        //    break;

        //}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
