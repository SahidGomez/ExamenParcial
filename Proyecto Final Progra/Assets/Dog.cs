using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
    [Header("CLASE DERIVADA")]
    public string Raza;
    // Start is called before the first frame update
    void Start()
    {
        Display();
        //int edad = 99;
        //int hasgh = edad.GetHashCode();
    }

    public override void move ()
    {
        
            posicionMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            posicionMouse.z = 0f;
        
        Vector3 direccion = (posicionMouse - transform.position).normalized;

        transform.Translate(direccion * speed * Time.deltaTime);

    }    
    // Update is called once per frame
    void Update()
    {
        move();
    }



}
