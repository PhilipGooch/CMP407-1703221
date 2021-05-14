using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupCarrot : MonoBehaviour
{
    public AK.Wwise.Event pullCarrotEvent;
    public GameObject player;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        // Sending event to Wwise.
        pullCarrotEvent.Post(gameObject);

        // Enabling mesh renderer for held carrot when clicked on.
        Camera camera = player.GetComponentInChildren<Camera>();
        MeshRenderer carrotHeldMeshRenderer = camera.GetComponentInChildren<MeshRenderer>();
        carrotHeldMeshRenderer.enabled = true;

        // Spawning particle system for soil.
        gameObject.GetComponentInChildren<MeshRenderer>().enabled = false;
        ParticleSystem particleSystem = gameObject.GetComponentInChildren<ParticleSystem>();
        particleSystem.Play();
        // Destroys itself after 2 seconds.
        StartCoroutine(DestroySelf(2));
    }

    IEnumerator DestroySelf(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        Destroy(gameObject);
    }
}
