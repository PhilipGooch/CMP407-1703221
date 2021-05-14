using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeakerOcclusion : MonoBehaviour
{
    public GameObject player;
    public AK.Wwise.Event occlusionEvent;
    public AK.Wwise.Event noOcclusionEvent;
    public float range;

    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        // If the player is behind the wall, send "occlusion" event to Wwise.
        if(other.gameObject.tag == "player")
        {
            occlusionEvent.Post(gameObject);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // If the player is NOT behind the wall, send "no occlusion" event to Wwise.
        if (other.gameObject.tag == "player")
        {
            noOcclusionEvent.Post(gameObject);
        }
    }
}
