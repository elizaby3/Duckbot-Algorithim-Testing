using System.Collections;
using System.Collections.Generic;
using UnityEditor.Callbacks;
using UnityEngine;

public class Re : MonoBehaviour
{   
    Rigidbody Duck1;
    Vector3 direction = Vector3.zero;

    float speed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
       Duck1 = GetComponent<Rigidbody>();   
    }

//Collision Handling

    void OnTriggerStay(Collider other) {
        if (other.gameObject.tag == "DuckBot") {
            //direction
            direction = (other.transform.position - Duck1.transform.position).normalized;

        }
    }

    // Update is called once per frame
    void Update()
    {
        if (direction == Vector3.zero)
        {
            //also need to add code to make sure the duckbots don't crash

            //insert code here to make duckbot keep rotating
        }
        else
        {
            transform.position=Vector3.MoveTowards(transform.position, direction, speed);
        }
    }
}
