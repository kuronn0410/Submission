using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
    public Transform Camera;
    public float PlayerSpeed;
    public float RotationSpeed;


    void Start()
    {
       
    }

    void Update()
    {
        move();
        RotatePlayer();
        CameraFollow();
    }

    void move()
    {
        var speed = Vector3.zero;

        if (Input.GetKey(KeyCode.S))
        {
            speed.z -= PlayerSpeed;
        }
        if (Input.GetKey(KeyCode.W))
        {
            speed.z += PlayerSpeed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            speed.x += PlayerSpeed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            speed.x -= PlayerSpeed;
        }

        transform.Translate(speed * Time.deltaTime);
    }

    void RotatePlayer()
    {
        float rotationY = 0f;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rotationY -= RotationSpeed;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rotationY += RotationSpeed;
        }

        transform.Rotate(0f, rotationY * Time.deltaTime, 0f);  // ÉvÉåÉCÉÑÅ[é©ëÃÇâÒì]
    }

    void CameraFollow()
    {
        Camera.position = transform.position;
        Camera.rotation = transform.rotation;
    }

    
}
