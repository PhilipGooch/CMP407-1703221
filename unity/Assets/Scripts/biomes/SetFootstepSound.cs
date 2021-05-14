using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetFootstepSound : MonoBehaviour
{
    public GameObject player;

    public int biomeID;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        // Switching type of footstep event to send to Wwise depending on the surface the player is walking on.
        PlayerMovement pm = other.gameObject.GetComponent<PlayerMovement>();
        if (pm)
        {
            pm.footstepSound = pm.footstepSounds[biomeID];
        }
    }
}
