using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteObject : MonoBehaviour
{
    public bool canBePressed;
    public bool canBePressedEarly;

    public int keyType;             //1 = A, 2 = D, 3 = Left Arrow, 4 = Right Arrow
    public KeyCode keyToPress;
    public KeyCode keyToPress2;

    public PlayerMovement playerScript;
    public NoteHitParticlePlayer particlePlayScript;

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
                if (keyType == 1)
                {
                    particlePlayScript.AKeyHit();
                    Debug.Log("ArrowHit");
                    playerScript.MoveLeft();
                    Destroy(gameObject);
                }
                else if (keyType == 2)
                {
                    particlePlayScript.DKeyHit();
                    playerScript.MoveLeft();
                    Destroy(gameObject);
                }
                else if (keyType == 3)
                {
                    particlePlayScript.LeftArrowHit();
                    playerScript.MoveRight();
                    Destroy(gameObject);
                }
                else if (keyType == 4)
                {
                    particlePlayScript.RightArrowHit();
                    playerScript.MoveRight();
                    Destroy(gameObject);
                }
            }
            else if (canBePressedEarly)
            {
                Destroy(gameObject);
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
            canBePressedEarly = true;
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
            canBePressedEarly = false;
        }
        else if (other.tag == "Late")
        {
            canBePressed = false;
        }
    }
}
