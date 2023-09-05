using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muvment : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float forse;

    [SerializeField] private Rigidbody2D _rb;
    private bool IsPaused ;
    void Start()
    {   
        
        
    }

    void Update()
    {
        transform.Translate(speed * Time.deltaTime, 0f, 0f);
        
        UpDown();
        
        
    }

   

    void UpDown()
    {
        if (Input.GetButton("Jump") || Input.GetButton("Fire1"))
        {
            _rb.AddForce(transform.up * forse);
        }
    }
}
