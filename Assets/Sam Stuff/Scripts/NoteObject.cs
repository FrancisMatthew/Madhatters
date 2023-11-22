using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteObject : MonoBehaviour
{
    public bool canBePressed;
    public bool isTeam1;
    public KeyCode keyToPress;
    public KeyCode keyToPress2;

    public PlayerMovement playerScript;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if(Input.GetKeyDown(keyToPress))
        {
            if(canBePressed)
            {
                Destroy(gameObject);

                if (isTeam1 == true)
                {
                    playerScript.MoveLeft();
                }
                else
                {
                    playerScript.MoveRight();
                }
            }
        }

        if (Input.GetKeyDown(keyToPress2))
        {
            if (canBePressed)
            {
                Destroy(gameObject);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Activator")
        {
            canBePressed = true;
        }
        else if(other.tag == "Early")
        {
            canBePressed = true;
        }
        else if(other.tag == "Late")
        {
            canBePressed = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Activator")
        {
            canBePressed = false;
        }
        else if (other.tag == "Early")
        {
            canBePressed = false;
        }
        else if (other.tag == "Late")
        {
            canBePressed = false;
            Debug.Log("Late");
        }
    }
}
