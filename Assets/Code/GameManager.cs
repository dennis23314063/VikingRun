using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public int score;
    public float time;
    [SerializeField] Text scoreText;
    [SerializeField] Text timeText;
    public Text slogan;
    public static GameManager Instance;
    public bool isGameStart;
    public bool isDie;
    private void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        score = 0;
        time = 0;
        isGameStart = false;
        isDie = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (isGameStart && !isDie)
        {
            time += Time.deltaTime;
            scoreText.text = "SCORE:" + Convert.ToString(score);
            timeText.text = "TIME:" + Convert.ToString(Convert.ToInt32(time));
        }
        
    }
}
