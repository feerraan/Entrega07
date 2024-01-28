using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entrega07 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Exercise01();
       
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




}
