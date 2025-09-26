using UnityEngine;
using UnityEngine.SocialPlatforms;

public class ContadorDeEspacios : MonoBehaviour
{
    int vecesPulsado = 0;
    Rigidbody rb;
    public float hoberfloat = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp (KeyCode.Space) == true)
        {
            rb.AddForce(Vector3.up * hoberfloat, ForceMode.Impulse);
            //aumentar las veces pulsadas
            vecesPulsado = vecesPulsado + 1;
            if (vecesPulsado == 5)
            {
                Debug.Log("pulsado 5 veces");
                vecesPulsado = 0;
            }

            else
            {
                Debug.Log("veces pulsado =" + vecesPulsado);
            }
            
        }
    }
    private void OnCollisinExit (Collision collision)
    {
        Debug.Log("sale de la colision");
    }
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("Mantiene en colision");
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("entra en la colisión");
    }
}
