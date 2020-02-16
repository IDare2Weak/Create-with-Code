using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    //Will become private variables
    public float speed = 5f;
    public float rotationSpeed = 5f;
    public float verticalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input (move the plane up/down based on arrow keys)
        verticalInput = Input.GetAxis("Vertical");


        // move the plane forward at a constant rate (like flappy bird). No Input needed
        transform.Translate(Vector3.forward * Time.deltaTime * speed);


        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.left * rotationSpeed * verticalInput * Time.deltaTime);
    }
}
