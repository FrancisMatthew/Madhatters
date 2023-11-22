using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarlyTrigger : MonoBehaviour
{
    public bool canBePressed;

    public KeyCode keyToPress;
    public KeyCode keyToPress2;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(Input.GetKeyDown(keyToPress))
        {
            if(canBePressed)
            {
                Destroy(other.gameObject);
            }
        }

        if (Input.GetKeyDown(keyToPress2))
        {
            if (canBePressed)
            {
                Destroy(other.gameObject);
            }
        }

    }
}
