using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muvment : MonoBehaviour
{
    [SerializeField] private float forse;

    [SerializeField] private Rigidbody2D _rb;
    void Start()
    {
        //_rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        UpDown();
    }

    void UpDown()
    {
        if (Input.GetButton("Jump") || Input.GetButton("Fire1"))
        {
            _rb.velocity = Vector2.up * forse;
        }
    }
}
