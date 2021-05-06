using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{

    [Header("Movement Configuration")]
    [Tooltip("Forward Speed")]
    [SerializeField] float speed = 10f;
    [Tooltip("Turn Speed")]
    [SerializeField] float turnSpeed = 25f;

    //Private variables
    float horizontalInput, forwardInput;
    CharacterController playerController;


    // Start is called before the first frame update
    void Start()
    {
        playerController = GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Getting player inputs
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        //Moving forward
        //transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //playerController.Move(transform.forward * Time.deltaTime * speed * forwardInput);
        playerController.SimpleMove(transform.forward * speed * forwardInput);
        
        //Rotates the car
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
