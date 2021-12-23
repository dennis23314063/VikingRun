using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;
public class Bridge : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject road;
    [SerializeField] GameObject obstacle;
    [SerializeField] GameObject shield;
    public Vector3 nextBridge;
    private GameObject currentTile = null;
    private GameObject[] prevTile = new GameObject[3];
    private bool first = true;
    Random rand = new Random();
    public void Spawn()
    {
        for(int i = 0; i < 2; i++)
        {
            prevTile[i] = prevTile[i + 1];
        }
        prevTile[2] = currentTile;
        int direction = rand.Next(3);
        int hole = rand.Next(2);
        int isObstacle = rand.Next(2);
        GameObject temp;
        if (first) temp = Instantiate(road, nextBridge, Quaternion.identity);
        else
        {
            temp = Instantiate(road, nextBridge + currentTile.transform.forward * 5 * hole, Quaternion.Euler(0, currentTile.transform.eulerAngles.y + (direction - 1) * 90, 0));
            if (isObstacle == 1)
                Instantiate(obstacle, temp.transform.GetChild(1).position, Quaternion.Euler(0, temp.transform.eulerAngles.y, 0), temp.transform);
        }
        for (int i = 0; i < 12; i++)
        {
            Debug.Log(temp.transform.GetChild(3).localPosition);
            int shieldHeight = rand.Next(3) - 1;
            temp.transform.GetChild(3).localPosition += new Vector3(0f, shieldHeight, 3f);
            if (temp.transform.GetChild(3).localPosition.y < 1.5)
                temp.transform.GetChild(3).localPosition += new Vector3(0f, 1f, 0f);
            if (temp.transform.GetChild(3).localPosition.y > 3.5)
                temp.transform.GetChild(3).localPosition += new Vector3(0f, -1f, 0f);
            Instantiate(shield, temp.transform.GetChild(3).position, Quaternion.Euler(0, temp.transform.eulerAngles.y - 90, 90), temp.transform);
        }
        nextBridge = temp.transform.GetChild(0).transform.position;
        currentTile = temp;
    }
    public void BreaklastTile() {
        Destroy(prevTile[0]);
    }
    void Start()
    {
        Spawn();
        first = false;
        Spawn();
        Spawn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
