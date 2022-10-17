using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private Transform[] enemyPath;

    [SerializeField]
    private float moveSpeed = 0.3f;

    [SerializeField]
    private int enemyPathIndex;

    // Start is called before the first frame update
    void Start()
    {
        //transform.position = enemyPath[enemyPathIndex].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.position = Vector2.MoveTowards(transform.position, 
            enemyPath[enemyPathIndex].transform.position, 
            moveSpeed * Time.deltaTime);
    }
}
