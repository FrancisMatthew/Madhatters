using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeamSwapper : MonoBehaviour
{
    public Quaternion originalRotation;
    public int playerTeam;
    public ScoreTrackerScript scoreTracker;

    public GameObject team1DropLocation;
    public GameObject team2DropLocation;

    void Start()
    {
        originalRotation = transform.rotation;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Pit")
        {
            if (playerTeam == 1)
            {
                JoinTeam2();
            }
            else if (playerTeam == 2)
            {
                JoinTeam1();
            }
        }
    }

    /// <summary>
    /// Adjusts the score tracker variables accordingly.
    /// Assigns the correct team label.
    /// Resets the object's rotation so it remains fixed after spawning.
    /// Moves the spawn location left and right so it remains firmly in front of the line of characters at all times.
    /// Moving them by 5 may need to be adjusted.
    /// </summary>
    public void JoinTeam1()
    {
        scoreTracker.team1Members++;
        scoreTracker.team2Members--;
        playerTeam = 1;

        //Change models + Turn 180 degrees (Once art assets are in)

        transform.position = team1DropLocation.transform.position;
        transform.rotation = originalRotation;
        team1DropLocation.transform.position += new Vector3(0, 0, 5);
        team2DropLocation.transform.position += new Vector3(0, 0, 5);
    }

    public void JoinTeam2()
    {
        scoreTracker.team2Members++;
        scoreTracker.team1Members--;
        playerTeam = 2;

        //Change models + Turn 180 degrees (Once art assets are in)

        transform.position = team2DropLocation.transform.position;
        transform.rotation = originalRotation;
        team2DropLocation.transform.position += new Vector3(0, 0, -5);
        team1DropLocation.transform.position += new Vector3(0, 0, -5);
    }
}
