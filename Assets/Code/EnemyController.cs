using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator animator;
    private vikingController viking;
    void Start()
    {
        viking = FindObjectOfType<vikingController>();
        animator = GetComponent<Animator>();
        animator.SetBool("Running",true);
        animator.SetBool("Choping",false);
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(transform.GetComponent<vikingController>().isDie);
        //.Log(transform.localPosition.z);

        if (viking.isDie&&transform.localPosition.z<-1)
        {
            transform.localPosition += new Vector3(0,0,0.01f);
        }
        if (transform.localPosition.z >= -1.8f) {
            animator.SetBool("Running",false);
            animator.SetBool("Choping",true);
        }
    }
}
