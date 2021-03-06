using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Continua : MonoBehaviour
{
    public Transform inicio;
    public List<Transform> lista = new List<Transform>();
    Vector3 direction;
    public float speed;
    int contador;
    bool teste;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Vector3.Distance(inicio.position, lista[contador].position) > 0.02)
        {
            direction = lista[contador].position - inicio.position;
            inicio.Translate(direction.normalized * speed * Time.deltaTime);
            
        }
        else
        {
          
            if (teste)
            {
                if (contador == 0)
                {
                    teste = false;
                }
                else
                {
                    contador--;
                }
                
            }
            else
            {   
                if (contador>=lista.Count-1)
                {
                    teste = true;
                }
                else
                {
                    contador++;
                }
                
            }  

        }
    }
}
