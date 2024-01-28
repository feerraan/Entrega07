using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entrega07 : MonoBehaviour
{
    [SerializeField] private string[] letras;

    // Start is called before the first frame update
    void Start()
    {
        Exercise01();
        Exercise02();
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



    }
