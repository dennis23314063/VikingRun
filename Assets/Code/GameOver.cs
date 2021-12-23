using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameOver : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Text scoreAndTime;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        scoreAndTime.text = "SCORE:" + Convert.ToString(GameManager.Instance.score) + Environment.NewLine + "TIME:" + Convert.ToString(Convert.ToInt32(GameManager.Instance.time));    
    }
}
