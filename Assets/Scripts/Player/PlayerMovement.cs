using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public VariableJoystick joystickVariable;
    public Animator animatorController;

    public float speed = 5f;
    public float rotationSpeed = 10f;

    void Update()
    {
        Vector2 myDirection = joystickVariable.Direction;
        Vector3 movementVector = new Vector3(myDirection.x, 0, myDirection.y);

        movementVector = movementVector * Time.deltaTime * speed;
        transform.position += movementVector;

        if (movementVector.magnitude != 0)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(movementVector, Vector3.up), Time.deltaTime * rotationSpeed);
        }

        bool isWalking = myDirection.magnitude > 0;
        animatorController.SetBool("isWalking", isWalking);
        animatorController.SetFloat("Pace", myDirection.magnitude);

    }
}
