using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarlyTrigger : MonoBehaviour
{
    public bool canBePressed;

    public KeyCode keyToPress;
    public KeyCode keyToPress2;
    

    void OnTriggerEnter(Collider other)
    {
        if(Input.GetKeyDown(keyToPress))
        {
            if(canBePressed)
            {
                if (other.tag == "Note")
                {
                     Destroy(other.gameObject);
                }
            }
        }

        if (Input.GetKeyDown(keyToPress2))
        {
            if (canBePressed)
            {
                if (other.tag == "Note")
                {
                    Destroy(other.gameObject);
                }
            }
        }

    }
}
