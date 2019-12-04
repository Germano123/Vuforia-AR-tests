using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementWithJoystick : MonoBehaviour
{
    // variable to control move
    private bool isMoving = false;

    // variable to control movement direction
    private Vector3 direction;
    // variable to control speed
    public float speed = 10f;

    // reference to the joystick
    public Joystick joystick;

    void Update()
    {
        CheckMove();
    }

    void FixedUpdate()
    {
        if (isMoving)
        {
            transform.position += direction;
        }
        Debug.Log(isMoving);
    }

    private void CheckMove()
    {
        float moveHorizontal = joystick.Horizontal * speed * Time.deltaTime;
        float moveVertical = joystick.Vertical * speed * Time.deltaTime;

        isMoving = (moveHorizontal != 0 || moveVertical != 0) ? true : false;

        direction = new Vector3(moveHorizontal, 0.0f, moveVertical);
    }
}