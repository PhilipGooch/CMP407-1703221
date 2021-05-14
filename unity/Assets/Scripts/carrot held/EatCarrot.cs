using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatCarrot : MonoBehaviour
{
    public AK.Wwise.Event eatCarrotEvent;
    public ParticleSystem particleSystem;

    void Start()
    {
        
    }

    void Update()
    {
        // If right mouse button is pressed, eat the carrot.
        if(Input.GetMouseButtonDown(1))
        {
            MeshRenderer meshRenderer = gameObject.GetComponentInChildren<MeshRenderer>();
            if (meshRenderer.enabled)
            {
                // Disable mesh renderer for held carrot.
                meshRenderer.enabled = false;
                // Play particle system for carrot particles.
                particleSystem.Play();
                // Post carrot eating event to Wwise.
                eatCarrotEvent.Post(gameObject);
            }
        }
    }

}
