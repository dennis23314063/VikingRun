using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    private vikingController viking;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "viking_Axes")
        {
            viking.Die();
        }
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
