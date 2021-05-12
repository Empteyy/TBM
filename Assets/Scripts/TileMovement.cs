using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileMovement : MonoBehaviour
{
    float speed = 5;
    public Vector3 currentPos;
    Vector3 targetPos;
    bool moving;

    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        if (moving)
        {
            if (Vector3.Distance(currentPos, transform.position) > 1f)
            {
                transform.position = targetPos;
                moving = false;
                return;
            }

            transform.position += (targetPos - currentPos) * Time.deltaTime;
            return;
        }

        if (Input.GetKey(KeyCode.W))
        {
            targetPos = transform.position + Vector3.up;
            currentPos = transform.position;
            moving = true;
        }

        if (Input.GetKey(KeyCode.S))
        {
            targetPos = transform.position + Vector3.down;
            currentPos = transform.position;
            moving = true;
        }

        if (Input.GetKey(KeyCode.A))
        {
            targetPos = transform.position + Vector3.left;
            currentPos = transform.position;
            moving = true;
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            targetPos = transform.position + Vector3.right;
            currentPos = transform.position;
            moving = true;
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
    }
}
