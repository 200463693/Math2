using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mass : MonoBehaviour
{
    public float mass = 0f; 

    private Vector3 velocity; 

    void Update()
    {
        
        transform.position += velocity * Time.deltaTime;
    }

    
    public void ApplyForce(Vector3 force)
    {
        
        Vector3 acceleration = force / mass;

        
        velocity += acceleration * Time.deltaTime;
    }
}
