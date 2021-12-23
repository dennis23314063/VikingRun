using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ObstacleTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    private vikingController viking;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "viking_Axes")
        {
            viking.Die();
            Invoke("GameOver",3f);
        }
    }
    private void GameOver() {
        SceneManager.LoadScene(3);
    } 
    void Start()
    {
        viking = FindObjectOfType<vikingController>();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
