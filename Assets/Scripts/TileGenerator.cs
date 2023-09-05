using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.WSA;

public class TileGenerator : MonoBehaviour
{
    [SerializeField] private GameObject[] Tiles;

    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            Instantiate(Tiles[Random.Range(0, 3)], new Vector3(i * 20f, 0, 0), Quaternion.identity);
        }
    }

    void Update()
    {
        
        
    }

  
    
}