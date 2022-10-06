using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    public bool isCurrentlyColliding = false;

    SpriteRenderer mSpriteRenderer;
    Color mNewColor;

    // Start is called before the first frame update
    void Start()
    {
        mSpriteRenderer = GetComponent<SpriteRenderer>();
        mSpriteRenderer.color = Color.white;
    }

    // Update is called once per frame
    void Update()
    {
        //if currently colliding, turn me red
        if(GameObject.position.x )
        {
            mSpriteRenderer.color = Color.red;
        }
    }

    public void ResetCollision()
    {
        isCurrentlyColliding = false;
    }

    public bool AABBCollision(CollisionDetection otherCollider)
    {
        //Check to see if this object and the other are colliding
        return false;
    }
}
