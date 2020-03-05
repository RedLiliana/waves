using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject currentCheckpoint;

    private PlayerController player;

    public static LevelManager Instance;

    void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

    public void RespawnPlayer()
    {
        Debug.Log("Player Respawn");
        if (currentCheckpoint)
        {
            player.transform.position = currentCheckpoint.transform.position;
        }
    }

    
 

}
