using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour
{
   public Transform inicio;
    public Transform fim;
    Vector3 direction;
    public float speed;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(inicio.position,fim.position) > 0.02)
        {
            direction = fim.position - inicio.position;
            inicio.Translate(direction.normalized * speed *Time.deltaTime ); 
        }


        print(Time.deltaTime);
    }
}
