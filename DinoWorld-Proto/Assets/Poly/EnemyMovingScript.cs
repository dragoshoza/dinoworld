using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovingScript : MonoBehaviour
{
   
    public float speed;

    // Update is called once per frame
    void Update()
    {
        GameObject player = GameObject.FindWithTag("Player");
        float step = speed * Time.deltaTime;
        GameObject enemy = this.gameObject; 
        enemy.transform.position = Vector3.MoveTowards(enemy.transform.position,player.transform.position,step);
    }
}
