using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Entrega07 : MonoBehaviour
{
    [SerializeField] private string[] letras;

   private int totalrandom = 0;
   private int contadorcinco = 0;

    // Start is called before the first frame update
    void Start()
    {
        Exercise01();
        Exercise02();
        Exercise04();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Exercise01()
    {
        int sum = 0;

        for (int i = 2; i <= 100; i += 2)
        {
            sum += i;
        }
        Debug.Log("La suma de los numeros pares del 1 al 100 es: " + sum);
    }


    private void Exercise02()
    {
        int count = 0;

        foreach (string letra in letras)
        {
            if (letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u")
            {
                count++;
            }
        }
        Debug.Log(count);
    }


    private void Exercise04()
    {
        

        while (totalrandom <= 100)
        {
            int numrandom = Random.Range(1, 11);

            totalrandom = totalrandom + numrandom;

            Debug.Log(totalrandom);


            if (numrandom == 5)
            {
                contadorcinco++;
            }

        }

        Debug.Log("El número total de 5 es: " + contadorcinco);


    }



}
