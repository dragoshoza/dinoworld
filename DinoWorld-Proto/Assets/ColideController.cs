using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColideController : MonoBehaviour
{
    public Text scoreText;
    public SimpleHealthBar healthBar;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            PlayerPrefs.SetInt("Score", PlayerPrefs.GetInt("Score") + 1);
            scoreText.text = PlayerPrefs.GetInt("Score").ToString();
        }
        else if (other.gameObject.CompareTag("Enemy"))
        {
            other.gameObject.SetActive(false);
            int health = PlayerPrefs.GetInt("Health");
            health = health - 5;
            PlayerPrefs.SetInt("Health", health);
            healthBar.UpdateBar(health, 100);
           
        }
    }


}