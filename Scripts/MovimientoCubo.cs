using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCubo : MonoBehaviour
{
    public float speed = 5f;

    //Usamos en evento FixedUpdate para hacer más solidas las interacciones con las físicas
    void FixedUpdate()
    {
        // Si el objeto tiene la tag "Cubo", lo movemos con las flechas del teclado
        if (CompareTag("Cubo"))
        {
            float horizontal = 0f;
            float vertical = 0f;

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                horizontal = -1f;  
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                horizontal = 1f;   
            }

            if (Input.GetKey(KeyCode.UpArrow))
            {
                vertical = 1f;     
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                vertical = -1f;   
            }  

            Vector3 moveDirection = new Vector3(horizontal, 0, vertical);

            transform.Translate(moveDirection * speed * Time.deltaTime, Space.World);
        }
    
    }
}
