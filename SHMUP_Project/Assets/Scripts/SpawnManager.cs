using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private List<SpriteRenderer> creatures = new List<SpriteRenderer>();

    public int numCreatures;
    public int maxCreatures = 15;
    public int minCreatures = 5;

    public SpriteRenderer enemyPrefab1;
    public SpriteRenderer enemyPrefab2;
    public SpriteRenderer enemyPrefab3;


    private Vector3 minPosition;
    private Vector3 maxPosition;

    // Start is called before the first frame update
    void Start()
    {
        minPosition = Camera.main.ScreenToWorldPoint(Vector3.zero);
        maxPosition = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0f));
        //Spawn in first wave of creatures
        Spawn();
    }

    /// Generate a new wave of creatures, placed randomyl throughout the world
    public void Spawn()
    {
        //make sure screen is clear before spawning in more new creatures
        CleanUp();
        //Create a set number of creatures in the world
        for(int i = 0; i < numCreatures; i++)
        {
            //Place a creature at a random position
            //Add that creatures to the creatures list
            creatures.Add(SpawnCreature());
        }

    }

    private SpriteRenderer ChooseRandomCreature()
    {
        //Pick a random creature from the prefabs that we have
        float r = Random.Range(0.00f, 1.00f);

        if(r < .33)
        {
            return enemyPrefab1;
        }
        else if(r < .67)
        {
            return enemyPrefab2;
        }
        else
        {
            return enemyPrefab3;
        }

    }

    //Spawns an individual creature at a random location in the world
    private SpriteRenderer SpawnCreature()
    {
        //Implement Gaussian distribution for spawn position
        float spawnPositionX = Gaussian(((minPosition.x + maxPosition.x) / 2), ((maxPosition.x - ((minPosition.x + maxPosition.x) / 2)) / 4));
        float spawnPositionY = Gaussian(((minPosition.y + maxPosition.y) / 2), ((maxPosition.y - ((minPosition.y + maxPosition.y) / 2)) / 4));
        Vector3 spawnPosition = new Vector3(Random.Range(minPosition.x, maxPosition.x), 
                                            Random.Range(minPosition.y, maxPosition.y),
                                            0);

        SpriteRenderer spawnedCreature = Instantiate(ChooseRandomCreature(), spawnPosition, Quaternion.identity);

        return spawnedCreature;
    }

    private void CleanUp()
    {
        foreach(SpriteRenderer creature in creatures)
        {
            Destroy(creature.gameObject);
        }
        creatures.Clear();
        numCreatures = Random.Range(minCreatures, maxCreatures);
    }

    private float Gaussian(float mean, float stdDev)
    {
        float val1 = Random.Range(0f, 1f);
        float val2 = Random.Range(0f, 1f);

        float gaussValue =
            Mathf.Sqrt(-2.0f * Mathf.Log(val1)) *
            Mathf.Sin(2.0f * Mathf.PI * val2);

        return mean + stdDev * gaussValue;
    }
}
