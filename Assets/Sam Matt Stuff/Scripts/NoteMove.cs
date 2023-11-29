using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class NoteMove : MonoBehaviour
{

    public float beatTempo;

    public bool hasStarted;

    // Sets the speed of which the notes move
    void Start()
    {
        beatTempo = beatTempo / 60f;
    }

    // This lowers the notes
    void Update()
    {
        if(!hasStarted)
        {
            hasStarted = true;
        }
        else
        {
            transform.position -= new Vector3(0f, beatTempo * Time.deltaTime, 0f);
        }
    }
}
