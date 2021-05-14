using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Rigidbody rigid_body;
    public Vector3 anchor;
    public float leash;
    public Vector3 acceleration;
    public Vector3 velocity;
    public Vector3 desired;
    public Vector3 steering;
    public float max_speed = 0.0f;
    public float max_force = 0.0f;

    void Start()
    {
        rigid_body = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Steering behaviour for bee following player.
        desired = player.gameObject.transform.position - transform.position;
        desired.Normalize();
        desired *= max_speed;
        steering = desired - velocity;
        if ((steering.x * steering.x + steering.y + steering.y + steering.z * steering.z) > max_force * max_force)
        {
            steering.Normalize();
            steering *= max_force;
        }
        acceleration = steering;
        velocity += acceleration;
        if ((player.transform.position - anchor).magnitude < leash)
        {
            rigid_body.MovePosition(transform.position + velocity * Time.deltaTime);
        }
        rigid_body.MoveRotation(Quaternion.LookRotation(-velocity));
    }
}
