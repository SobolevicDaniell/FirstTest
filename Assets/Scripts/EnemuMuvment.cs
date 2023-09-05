using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemuMuvment : MonoBehaviour
{
    [SerializeField] private float speed = 2f;
    private bool isMoving = true;

    [SerializeField] private float PointTop;
    [SerializeField] private float PointDown;
 
    void FixedUpdate()
    {
        if (transform.position.y >= PointTop)
        {
            isMoving = false;
        }
        else if (transform.position.y <= PointDown)
        {
            isMoving = true;
        }
 
        if (isMoving)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + speed * Time.deltaTime);
        }
        else
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - speed * Time.deltaTime);
        }
    }
}
