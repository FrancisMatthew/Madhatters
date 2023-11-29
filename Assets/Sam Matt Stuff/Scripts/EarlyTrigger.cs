using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarlyTrigger : MonoBehaviour
{
    public bool canBePressed;

    public KeyCode keyToPress;
    
    // The same as the trigger but for if the player presses the key early
    void OnTriggerEnter(Collider other)
    {
        if(Input.GetKeyDown(keyToPress))
        {
            if(canBePressed)
            {
                if (other.tag == "Note" || other.tag == "NoteRight")
                {
                     Destroy(other.gameObject);
                }
            }
        }
    }
}
