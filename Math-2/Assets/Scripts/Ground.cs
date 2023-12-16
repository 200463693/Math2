using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle
{
    public Vector2 position;
    public Vector2 direction;
    public float radius;

    public Vector2 Bottom()
    {
        return position - direction * radius;
    }
}

public class Rectangle
{
    public Vector2 position;
    public Vector2 direction;
    public float halfWidth;
    public float halfHeight;

    public Vector2 Bottom()
    {
        return position - direction * halfHeight;
    }
}

public class Capsule
{
    public Vector2 position;
    public Vector2 direction;
    public float radius;
    public float halfLength;

    public Vector2 Bottom()
    {
        return position - direction * (halfLength + radius);
    }
}

public class Ground:MonoBehaviour
{
    public GameObject circle1;
    public GameObject rectangle1;
    public GameObject capsule1;

    public GameObject rectangleBottom;
    public GameObject capsuleBottom;
    public GameObject circleBottom;

    Rectangle rectangle = new Rectangle();
    Circle circle = new Circle();
    Capsule capsule = new Capsule();

    Vector2 vel = Vector2.zero;

    private void Update()
    {
        Vector2 acc = new Vector2 (0.0f, Physics.gravity.y);
        float dt = Time.deltaTime;
        vel = vel + acc * dt;
        Vector2 positionDelta = vel * dt;
        rectangle1.transform.position += new Vector3(positionDelta.x, positionDelta.y);
        circle1.transform.position += new Vector3(positionDelta.x, positionDelta.y);
        capsule1.transform.position += new Vector3(positionDelta.x, positionDelta.y);

        rectangle.position = rectangle1.transform.position;
        rectangle.direction = rectangle1.transform.up;
        rectangle.halfWidth = rectangle1.transform.localScale.x * 0.5f;
        rectangle.halfHeight = rectangle1.transform.localScale.y * 0.5f;
        rectangleBottom.transform.position = rectangle.Bottom();

        circle.position = circle1.transform.position;
        circle.direction = circle1.transform.up;
        circle.radius = circle1.transform.localScale.x * 0.5f;
        circleBottom.transform.position = circle.Bottom();

        capsule.position = capsule1.transform.position;
        capsule.direction = capsule1.transform.up;
        capsule.radius = capsule1.transform.localScale.x * 0.5f;
        capsule.halfLength = capsule1.transform.localScale.y * 0.5f;
        capsuleBottom.transform.position = capsule.Bottom();
    }



}
