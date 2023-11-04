using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeamSwapper : MonoBehaviour
{
    public int playerTeam;
    public ScoreTrackerScript scoreTracker;

    public GameObject team1DropLocation;
    public GameObject team2DropLocation;

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

    public void JoinTeam1()
    {
        scoreTracker.team1Members++;
        scoreTracker.team2Members--;
        playerTeam = 1;

        //Change models + Turn 180 degrees

        transform.position = team1DropLocation.transform.position;
    }

    public void JoinTeam2()
    {
        scoreTracker.team2Members++;
        scoreTracker.team1Members--;
        playerTeam = 2;

        transform.position = team2DropLocation.transform.position;
    }
}
