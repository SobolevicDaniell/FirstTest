using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class Restart : MonoBehaviour
{
    [SerializeField] private GameObject player;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Respawn")
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
