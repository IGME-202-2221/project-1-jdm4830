using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [Range(0f, 5f)]
    public float health = 5;

    public float maxHealth = 5;

    [Min(0)]
    public int score = 0;

    public Text scoreCounter;

    public Slider healthBar;

    private int finalScore = 0;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        health = 5;
    }

    // Update is called once per frame
    void Update()
    {
        scoreCounter.text = $"SCORE: {score.ToString("00000")}";

        healthBar.value = health / maxHealth;

        finalScore += score;

        if(health == 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
