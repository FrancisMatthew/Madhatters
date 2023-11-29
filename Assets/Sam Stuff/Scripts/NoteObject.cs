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

    void Update()
    {
        if (Input.GetKeyDown("a"))
        {
            HitLeft("Player1");
        }
        else if (Input.GetKeyDown("d"))
        {
            HitRight("Player1");
        }
        else if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            HitLeft("Player2");
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            HitRight("Player2");
        }

    }
    
    public void HitLeft(string playerName) 
    { 
        if(playerName == "Player1") 
        {
            if (canBePressed)
            {

                particlePlayScript.AKeyHit();
                playerScript.MoveLeft();
                Destroy(gameObject);

            }
            else if (canBePressedEarly)
            {
                Destroy(gameObject);
            }
        }
        else if (playerName == "Player2")
        {
            if (canBePressed)
            {
                particlePlayScript.LeftArrowHit();
                playerScript.MoveRight();
                Destroy(gameObject);

            }
            else if (canBePressedEarly)
            {
                Destroy(gameObject);
            }
        }
    }

    public void HitRight(string playerName) 
    {
        if (playerName == "Player1")
        {
            if (canBePressed)
            {
                particlePlayScript.DKeyHit();
                playerScript.MoveLeft();
                Destroy(gameObject);

            }
            else if (canBePressedEarly)
            {
                Destroy(gameObject);
            }
        }
        else if(playerName == "Player2")
        {
            if (canBePressed)
            {
                particlePlayScript.RightArrowHit();
                playerScript.MoveRight();
                Destroy(gameObject);

            }
            else if (canBePressedEarly)
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
