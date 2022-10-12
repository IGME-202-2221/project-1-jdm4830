using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float speed = 1f;
    public Vector2 direction = Vector2.right;
    public Vector3 velocity = Vector2.zero;

    // Start is called before the first frame update
    void Start(){}

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3)velocity;
    }

    public void Shoot(float speed, Vector3 velocity, Vector2 direction)
    {
        this.speed = speed;
        this.velocity = velocity;
        this.direction = direction;
    }
}
