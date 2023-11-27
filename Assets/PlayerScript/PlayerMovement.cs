using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public void MoveLeft()
    {
        transform.position += new Vector3(0, 0, -2);
    }

    public void MoveRight()
    {
        transform.position += new Vector3(0, 0, 2);
    }
}
