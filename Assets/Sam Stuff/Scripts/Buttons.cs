using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
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

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(keyToPress))
        {
            theMR.material = pressedButton;
        }

        if(Input.GetKeyUp(keyToPress))
        {
            theMR.material = defaultButton;
        }

        
        if (Input.GetKeyDown(keyToPress2))
        {
            theMR.material = pressedButton;
        }

        if (Input.GetKeyUp(keyToPress2))
        {
            theMR.material = defaultButton;
        }
        
    }
}
