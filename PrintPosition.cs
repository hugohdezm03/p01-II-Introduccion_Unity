using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintPosition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Debug.Log($"Terrain Position: {GameObject.FindWithTag("Terrain").transform.position}");
        Debug.Log($"{tag} Position: {transform.position}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}