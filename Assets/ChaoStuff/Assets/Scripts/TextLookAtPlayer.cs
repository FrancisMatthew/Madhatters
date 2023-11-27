using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextLookAtPlayer : MonoBehaviour
{
    [SerializeField] Camera TextTracker;

    // Start is called before the first frame update
    void Start()
    {
        TextTracker = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(TextTracker.transform);
        transform.rotation = Quaternion.LookRotation(TextTracker.transform.forward);
        transform.rotation = Quaternion.Euler(0, 180, 0);
    }
}
