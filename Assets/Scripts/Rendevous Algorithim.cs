using System.Collections;
using System.Collections.Generic;
using UnityEditor.Callbacks;
using UnityEngine;

public class Re : MonoBehaviour
{   
    //Rigidbody Duck1;
    Vector3 direction = Vector3.zero;

    float speed = 0.01f;
    float min_dist = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
       //Duck1 = GetComponent<Rigidbody>();   
    }

//Collision Handling

    void OnTriggerStay(Collider other) {
        if (other.gameObject.tag == "DuckBot") {
            //direction
            direction = (other.transform.position - transform.position).normalized;

            if(direction.y < 0) {
                direction.y = 0;
            }

            if(Vector3.Distance(other.transform.position, transform.position) < min_dist) {
                direction = Vector3.zero;
            }
        }
    }

    void OnTriggerExit(Collider other) {
        direction = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        if (direction == Vector3.zero)
        {
            //also need to add code to make sure the duckbots don't crash

            //insert code here to make duckbot keep rotating
            transform.Rotate(Vector3.forward, 1, Space.Self);
        }
        else
        {
            transform.position=Vector3.MoveTowards(transform.position, direction, speed);
        }
    }
}
