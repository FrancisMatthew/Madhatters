using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    // This destroys the notes if the go below the threshold to save memory
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Note" || other.tag == "NoteRight")
        {
            Destroy(other.gameObject);
        }
    }
}
