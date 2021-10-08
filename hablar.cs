using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hablar : MonoBehaviour
{


    public int id;
    private int contador = 0;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Soy " + gameObject.name + " identificador: " + id);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Soy " + gameObject.name + " identificador: " + id + " contador: " + contador);
        contador++;
    }
}
