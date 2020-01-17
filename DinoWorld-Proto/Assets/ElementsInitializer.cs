using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementsInitializer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("Health", 100);
        PlayerPrefs.SetInt("Score", 0);
    }
}
