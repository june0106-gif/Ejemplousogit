using UnityEngine;

public class ejemploscript : MonoBehaviour  
{
 public string nombreDelObjeto = "texto Cualquiera";
   //Variable de tipo entero
    int miVariableNumerica = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(nombreDelObjeto + gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        //Aumentar en una unidad
        miVariableNumerica = miVariableNumerica + 1;
        //mostramos
        Debug.Log(nombreDelObjeto + " en el udate " + miVariableNumerica);  

    }
}
