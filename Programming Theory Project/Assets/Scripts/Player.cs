using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Player : Entity
{
    // POLYMORPHISM
    protected override float moveSpeed { get; set; } = 10.0f;
    protected override Vector3 lookDirection { get; set; }

    private float verticalInput;
    private float horizontalInput;

    private void Update()
    {
        PlayerInput();
    }

    // ABSTRACTION
    void PlayerInput() {

        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        if (Input.GetKey(KeyCode.UpArrow))
        {
            lookDirection = (Vector3.up * verticalInput);
            Move();
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            lookDirection = (-Vector3.down * verticalInput);
            Move();
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            lookDirection = (-Vector3.left * horizontalInput);
            Move();
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            lookDirection = (Vector3.right * horizontalInput);
            Move();
        }
    }

}
