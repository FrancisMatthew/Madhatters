using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTrackerScript : MonoBehaviour
{
    public int team1Members = 3;
    public int team2Members = 3;

    void Update()
    {
        if (team1Members == 6)
        {
            //Victory
            //Show victory text
            //Victory sound
            //Move camera to team 1
            //After x seconds bring up victory menu
        }
        else if (team2Members == 6)
        {
            //Victory
            //Show victory text
            //Victory sound
            //Move camera to team 2
            //After x seconds bring up victory menu
        }
    }
}
