using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    public float movementForce;
    public Rigidbody rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            //Move Right
            rigidbody.AddForce(Vector3.right * movementForce);
        }

        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            //Move Left
            rigidbody.AddForce(Vector3.left * movementForce);
        }

        if (Input.GetAxisRaw("Vertical") > 0)
        {
            //Move Foward
            rigidbody.AddForce(Vector3.forward * movementForce);
        }
        if (Input.GetAxisRaw("Vertical") < 0)
        {
            //Move Back
            rigidbody.AddForce(Vector3.back * movementForce);
        }
    }
}
