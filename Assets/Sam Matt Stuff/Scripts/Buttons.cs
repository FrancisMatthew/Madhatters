using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Buttons : MonoBehaviour
{
    public GameObject noteInTrigger = null;
    public NoteObject noteObjClassInTrigger = null;
    public bool isLeft = false;

    private MeshRenderer theMR;
    public Material defaultButton;
    public Material pressedButton;

    public KeyCode keyToPress;
    public KeyCode keyToPress2;

    // Sets material for the cube destroyers at the beginning
    void Start()
    {
        theMR = GetComponent<MeshRenderer>();
    }

    // When the notes go through the boxes they change colour
    private void OnTriggerEnter(Collider other)
    {
        noteInTrigger = other.gameObject;
        noteObjClassInTrigger = noteInTrigger.GetComponent<NoteObject>();
        if (other.tag == "Note" || other.tag == "NoteRight")
        {
            theMR.material = pressedButton;
        }
    }

    // Resets the boxes back to the original colour when no Note is inside
    private void OnTriggerExit(Collider other)
    {
        noteInTrigger = null;
        noteObjClassInTrigger = null;
        if (theMR.material = pressedButton)
        {
            ResetColour();
        }
    }


    public void NotePassthrough(string playerName)
    {
        // theMR.material = pressedButton;
        Invoke("ResetColour", 0.3f);
        if (noteObjClassInTrigger != null && isLeft) 
        {
            noteObjClassInTrigger.HitLeft(playerName);
        }
        else if (noteObjClassInTrigger != null && isLeft == false)
        {
            noteObjClassInTrigger.HitRight(playerName);
        }
        else 
        {
            return;
        }
    }

    // Resets the box colour to the original
    public void ResetColour()
    {
        theMR.material = defaultButton;
    }


}
