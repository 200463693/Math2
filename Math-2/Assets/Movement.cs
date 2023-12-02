using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public KeyCode MoveUp;
    public KeyCode MoveDown;
    public KeyCode MoveLeft;
    public KeyCode MoveRight;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(MoveUp))
        transform.Translate(Vector3.up*speed*Time.deltaTime);
        if (Input.GetKey(MoveDown))
            transform.Translate(-Vector3.up * speed * Time.deltaTime);
        if (Input.GetKey(MoveLeft))
            transform.Translate(-Vector3.right * speed * Time.deltaTime);
        if (Input.GetKey(MoveRight))
            transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
}
