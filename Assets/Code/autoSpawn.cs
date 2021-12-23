using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class autoSpawn : MonoBehaviour
{
    // Start is called before the first frame update

    private Bridge bridge;
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "viking_Axes") {
            bridge.BreaklastTile();
            bridge.Spawn();
        }

    }
    void Start()
    {
        bridge = FindObjectOfType<Bridge>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
