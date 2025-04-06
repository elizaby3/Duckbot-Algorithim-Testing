using System.Collections;
using System.Collections.Generic;
using UnityEditor.Callbacks;
using UnityEngine;

public class Re : MonoBehaviour
{   
    GameObject Duck1;
    Rigidbody rb;
    GameObject Duck2;
    Vector3 direction;
    float speed = 0.5f;
    
    // Start is called before the first frame update
    void Start()
    {
        Duck1 = GetComponent<GameObject>();
        rb = GetComponent<Rigidbody>();   
    }

//Collision Handling

    void OnTriggerStay(Collider other) {
        if (other.gameObject.tag == "DuckBot") {
            Duck2 = other.gameObject;
            print("Detected");
        }

        direction = Duck2.transform.position - Duck1.transform.position;
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
            rb.velocity = direction * speed;
        }
    }
}
