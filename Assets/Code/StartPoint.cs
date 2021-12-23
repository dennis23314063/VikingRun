using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPoint : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "viking_Axes") {
            other.GetComponent<vikingController>().GameStart();
            GameManager.Instance.isGameStart = true;
            GameManager.Instance.slogan.text = "";
            
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
