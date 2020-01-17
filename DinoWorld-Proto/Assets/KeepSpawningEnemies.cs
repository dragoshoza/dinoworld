using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepSpawningEnemies : MonoBehaviour
{
    public GameObject ground;
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player"); 
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectsWithTag("Enemy").Length < 2)
        {
           
        } 
    }
}
