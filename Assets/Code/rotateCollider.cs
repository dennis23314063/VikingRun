using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateCollider : MonoBehaviour
{
    // Start is called before the first frame update
    //private vikingController viking;
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "viking_Axes")
        {
            other.GetComponent<vikingController>().canRotate = true;
            other.GetComponent<vikingController>().fixDirection = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.name == "viking_Axes")
        {
            other.GetComponent<vikingController>().canRotate = false;
            //other.GetComponent<vikingController>().fixDirection = false;

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
