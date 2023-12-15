using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    public GameObject obj1;
    public GameObject obj2;

    void Update()
    {
        Vector2 position1 = obj1.transform.position;
        Vector2 position2 = obj2.transform.position;
        float radius1 = obj1.transform.localScale.x * 0.5f;
        float radius2 = obj2.transform.localScale.x * 0.5f;

        bool collision = CheckCollisionShapes(position1, radius1, position2, radius2);

        if (collision)
        {
            // If collision occurs, set the y position of obj1 to -4
            Vector3 newPosition = obj1.transform.position;
            newPosition.y = -4f;
            obj1.transform.position = newPosition;
        }
    }

    bool CheckCollisionShapes(Vector3 position1, float radius1, Vector3 position2, float radius2)
    {
        // Distance between position 1 and position 2
        float distance = (position1 - position2).magnitude;

        // Sum of radii
        float radiiSum = radius1 + radius2;

        // Collision if distance between circles is less than the sum of their radii!
        return distance < radiiSum;
    }
}
