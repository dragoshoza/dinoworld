using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManagerScript : MonoBehaviour
{

    public GameObject objPrefab;
    public GameObject player;
    public GameObject ground;
   

    public void Start()
    {
        //player = GameObject.FindWithTag("Player");
    }

    public void spawnObject()
    {
        Instantiate(objPrefab,ground.transform.position, Quaternion.identity, ground.transform);
    }
}
