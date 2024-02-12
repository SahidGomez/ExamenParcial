using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverPersonaje : MonoBehaviour
{

    public float Speed;
    private Rigidbody2D rb;
    private Vector2 Control;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();   
    }


    void Update()
    {
        Vector2 mover = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        Control = mover.normalized * Speed;
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position +  Control * Time.deltaTime);
    }

}
