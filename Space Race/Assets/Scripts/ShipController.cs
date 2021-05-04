using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{

    float horizontal, vertical, desiredRotationSpeed, vel;

    CharacterController charController;

    // Start is called before the first frame update
    void Start()
    {
        charController = GetComponent<CharacterController>();
        desiredRotationSpeed = 3f;
        vel = 30f;
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(0, 0, vertical);
        transform.Rotate(Vector3.up, desiredRotationSpeed * horizontal);
        

        charController.Move(direction * vel * Time.deltaTime);
    }
}
