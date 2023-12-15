using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.Rendering;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject obj1;
    public GameObject obj2;
  
    
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position1 = obj1.transform.position;
        Vector2 position2 = obj2.transform.position;
        float radius1 = obj1.transform.localScale.x * 0.5f;
        float radius2 = obj2.transform.localScale.x * 0.5f;


        bool Collision = CheckCollisionShapes(position1, radius1,
              position2, radius2);
        
        if (Collision)
        {
            obj1.GetComponent<SpriteRenderer>().color = UnityEngine.Color.green;
            obj2.GetComponent<SpriteRenderer>().color = UnityEngine.Color.green;
        }
        else
        {
            obj1.GetComponent<SpriteRenderer>().color = UnityEngine.Color.red;
            obj2.GetComponent<SpriteRenderer>().color = UnityEngine.Color.red;
        }

    }
    bool CheckCollisionShapes(Vector3 position1, float radius1, Vector3 position2, float radius2)
    {
        // Distance between position 1 and position 2
        float distance = (position1 - position2).magnitude;

        // Direction from to position 2 to position 1
        Vector3 direction = (position1 - position2).normalized;

        // Sum of radii
        float radiiSum = radius1 + radius2;

        // Collision if distance between circles is less than the sum of their radii!
        bool collision = distance < radiiSum;
        if (collision)
        {
            // Calculate mtv only if there's a collision
            float depth = radiiSum - distance;
            
        }
       
        return collision;
    }
}
