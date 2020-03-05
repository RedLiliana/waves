﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public LevelManager levelManager;

    // Start is called before the first frame update
    void Start()
    {
        levelManager = FindObjectOfType<LevelManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
      
        if (other.tag == "Player")
        {
            Debug.Log("hit trigger");
            if (levelManager)
            {
                levelManager.currentCheckpoint = gameObject;
            }
            Debug.Log("Activate Checkpoint " + transform.position);
        }
    }
}
