using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovement : MonoBehaviour
{
    public int MovementSpeed;
    public int RotationSpeed;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("a"))
        {
            transform.Rotate(0, 0, -RotationSpeed * Time.deltaTime, Space.Self);
        }

        if (Input.GetKey("d"))
        {
            transform.Rotate(0, 0, RotationSpeed * Time.deltaTime, Space.Self);
        }

        if (Input.GetKey("w"))
        {
            transform.position -= transform.up * Time.deltaTime * MovementSpeed;
        }

        if (Input.GetKey("s"))
        {
            transform.position += transform.up * Time.deltaTime * MovementSpeed;
        }
    }
}
