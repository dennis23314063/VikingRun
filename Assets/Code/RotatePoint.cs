using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePoint : MonoBehaviour
{
    // Start is called before the first frame update
    
    private void OnTriggerStay(Collider other)
    {
        if(other.name== "viking_Axes"&&other.GetComponent<vikingController>().canRotate)
        {
            other.GetComponent<vikingController>().inRotatePoint = true;
            other.GetComponent<vikingController>().Rotate();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.name == "viking_Axes")
        {
            other.GetComponent<vikingController>().inRotatePoint = false;
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
