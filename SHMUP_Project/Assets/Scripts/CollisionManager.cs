using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionManager : MonoBehaviour
{
    //Store all of the collidable objects in my scene
    public List<CollisionDetection> collidableObjects = new List<CollisionDetection>();

    //Keeps track of circle collision
    public bool isUsingCircleCollision = false;

    

    // Start is called before the first frame update
    void Start()
    {
        
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
                if(isUsingCircleCollision)
                {
                    //do circle collision check
                }
                else
                {
                    if(AABBCollision(collidableObjects[i], collidableObjects[y]))
                    {
                        collidableObjects[i].isCurrentlyColliding = true;
                        collidableObjects[y].isCurrentlyColliding = true;
                        //do my collision resolution
                    }
                }
                
            }
        }
    }

    private bool AABBCollision(CollisionDetection objectA, CollisionDetection objectB)
    {
        //Use AABB collision detection to see if object a and object B are colliding

        //return true if yes, return false if no
        return false;
    }

    public void SwitchToCircleCollision()
    {
        isUsingCircleCollision = true;
    }

    public void SwitchToAABBCollision()
    {
        isUsingCircleCollision = false;
    }
}
