using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScriptUninterpolated : MonoBehaviour
{
    /// <summary>
    /// This is the simplest way of moving the camera smoothly. If we want interpolation, we can handle that later.
    /// </summary>

    public Camera mainCamera;
    public ScoreTrackerScript scoreTracker;
    public float speed = 10;
    public float speedWin = 20;

    //How many characters team one has.
    public Transform characters0;          //Team 2 Win
    public Transform characters1;
    public Transform characters2;
    public Transform characters3;          //Default position
    public Transform characters6;          //Team 1 Win

    void Start()
    {
        mainCamera.transform.position = characters3.position;
    }

    void FixedUpdate()
    {
        switch(scoreTracker.team1Members)
        {
            case 0:
                mainCamera.transform.position = Vector3.MoveTowards(mainCamera.transform.position, characters0.position, speedWin * Time.deltaTime);
                break;
            case 1:
            case 5:
                mainCamera.transform.position = Vector3.MoveTowards(mainCamera.transform.position, characters1.position, speed * Time.deltaTime);
                break;
            case 2:
            case 4:
                mainCamera.transform.position = Vector3.MoveTowards(mainCamera.transform.position, characters2.position, speed * Time.deltaTime);
                break;
            case 3:
                mainCamera.transform.position = Vector3.MoveTowards(mainCamera.transform.position, characters3.position, speed * Time.deltaTime);
                break;
            case 6:
                mainCamera.transform.position = Vector3.MoveTowards(mainCamera.transform.position, characters6.position, speedWin * Time.deltaTime);
                break;
        }
    }

   
    
}
