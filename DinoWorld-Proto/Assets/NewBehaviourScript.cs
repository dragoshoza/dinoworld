using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Reference to the Prefab. Drag a Prefab into this field in the Inspector.
    public GameObject myPrefab;
    public Camera camera;

    // This script will simply instantiate the Prefab when the game starts.
    void Start()
    {
        // Instantiate at position (0, 0, 0) and zero rotation.
        Instantiate(myPrefab,camera.transform.position + new Vector3(0, 0, 0), Quaternion.identity);
    }

    void Update()
    {
        Instantiate(myPrefab, camera.transform.position + new Vector3(0, 0, 0), Quaternion.identity);
    }
}
