using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    /// <summary>
    /// This movement system is only for testing purposes
    /// </summary>
    void Update()
    {
        if (Input.GetKeyDown("a") || (Input.GetKeyDown("left")))
        {
            transform.position += new Vector3(0, 0, -2);
        }
        else if (Input.GetKeyDown("d") || (Input.GetKeyDown("right")))
        {
            transform.position += new Vector3(0, 0, 2);
        }
        
    }
}
