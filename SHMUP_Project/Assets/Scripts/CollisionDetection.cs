using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CollisionDetection : MonoBehaviour
{
    public bool isCurrentlyColliding = false;
    public float radius = 1f;
    public SpriteRenderer mSpriteRenderer;
    public SpriteRenderer SpriteRenderer{ get { return SpriteRenderer; } }
    public Color mNewColor;
    public CollisionManager collisionManager;
    public Player playerHealth;

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
        if(isCurrentlyColliding)
        {
            mSpriteRenderer.color = Color.red;
            Destroy(mSpriteRenderer);
        }
        else
        {
            mSpriteRenderer.color = Color.white;
        }
    }

    public void ResetCollision()
    {
        isCurrentlyColliding = false;
    }
}
