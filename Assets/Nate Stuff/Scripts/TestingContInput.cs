using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TestingContInput : MonoBehaviour
{
    public PlayerInput playerInput;

    [SerializeField] private Gamepad currentGamepadDevice;
    [SerializeField] private Keyboard currentKeyboardDevice;

    public Material b4Test, afterTest;

    private void Awake()
    {
        

        playerInput = GetComponent<PlayerInput>();

        currentKeyboardDevice = playerInput.GetDevice<Keyboard>();
        currentGamepadDevice = playerInput.GetDevice<Gamepad>();

        

    }




    public void ActivateLeft(InputAction.CallbackContext context) 
    {
        if (context.performed) 
        { 
            Debug.Log("Activate Left! " + context.phase + " - " + context.control);
        }

        Renderer objRend = this.gameObject.GetComponent<Renderer>();
        objRend.material = afterTest;
        
    }
     public void ActivateRight(InputAction.CallbackContext context) 
    {
        if (context.performed) 
        { 
            Debug.Log("Activate Right! " + context.phase + " - " +context.control);
        }

        Renderer objRend = this.gameObject.GetComponent<Renderer>();
        objRend.material = b4Test;
    }

}
