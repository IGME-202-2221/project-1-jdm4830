using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class CollisionManager : MonoBehaviour
{
    //Store all of the collidable objects in my scene
    public List<CollisionDetection> collidableObjects = new List<CollisionDetection>();

    private SpriteRenderer spriteRenderer;

    private SpawnManager spawnManager;

    // Start is called before the first frame update
    void Start()
    {
        
        foreach(GameObject collidable in GameObject.FindGameObjectsWithTag("Object"))
        {
            collidableObjects.Add(collidable.GetComponent<CollisionDetection>());
        }
        collidableObjects.Add(GameObject.FindGameObjectWithTag("Player").GetComponent<CollisionDetection>());
        
    }

    // Update is called once per frame
    void Update()
    {
        foreach(CollisionDetection collidableObject in collidableObjects)
        {
            //reset the collision
            collidableObject.ResetCollision();
        }
        
        //Check to see if any objects are colliding with one another, adn tell the objects what they're colliding with
        for(int i = 0; i < collidableObjects.Count; i++)
        {
            for(int y = i+1; y < collidableObjects.Count; y++)
            {
                if(CircleCollision(collidableObjects[i], collidableObjects[y]))
                {
                    collidableObjects[i].isCurrentlyColliding = true;
                    collidableObjects[y].isCurrentlyColliding = true;
                }
                /*
                if(CircleCollision(collidableObjects[i], collidableObjects[y]))
                {
                    Destroy(collidableObjects[i]);
                    Destroy(collidableObjects[y]);
                    spawnManager.Spawn();
                }
                */
            }
        }
    }

    private bool CircleCollision(CollisionDetection num1, CollisionDetection num2)
    {
        float r1 = num1.radius;
        float r2 = num2.radius;
        float distance = Mathf.Sqrt
            ((Mathf.Pow(num1.transform.position.x - num2.transform.position.x, 2) + 
            Mathf.Pow(num1.transform.position.y - num2.transform.position.y, 2)));
            if(distance <= (r1+r2))
            {
                return true;
            }
            else
            {
                return false;
            }
    }
}
