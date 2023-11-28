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

    // Start is called before the first frame update
    void Start()
    {
        theMR = GetComponent<MeshRenderer>();
    }


    private void OnTriggerEnter(Collider other)
    {
        noteInTrigger = other.gameObject;
        noteObjClassInTrigger = noteInTrigger.GetComponent<NoteObject>();
    }

    private void OnTriggerExit(Collider other)
    {
        noteInTrigger = null;
        noteObjClassInTrigger = null;
    }

    public void NotePassthrough(string playerName)
    {
        theMR.material = pressedButton;
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


    public void ResetColour()
    {
        theMR.material = defaultButton;
    }


}
