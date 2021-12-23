using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChopYouTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator animator;
    private void OnTriggerEnter(Collider other)
    {
        if(other.name== "viking_Axes")
        {
            animator.SetBool("Choping",true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.name == "viking_Axes")
        {
            animator.SetBool("Choping", false);
        }
    }
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.isGameStart)
            Destroy(gameObject);
    }
}
