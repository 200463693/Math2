using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Impulse_Force : MonoBehaviour
{
    public GameObject obj1;

    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            Vector3 newPosition = obj1.transform.position;
            newPosition.y = 5;
            obj1.transform.position = newPosition;
        }
      
    }
}
