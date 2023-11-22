using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTrackerScript : MonoBehaviour
{
    public int team1Members = 3;
    public int team2Members = 3;

    public ParticleSystem confettiTeam1;
    public ParticleSystem confettiTeam2;
    bool confettiPlayed = false;

    void Update()
    {
        if (team1Members == 6 && !confettiPlayed)
        {
            confettiTeam1.Play();
            confettiPlayed = true;
            //Show victory text
            //Victory sound
            //Move camera to team 1
            //After x seconds bring up victory menu
        }
        else if (team2Members == 6 && !confettiPlayed)
        {
            confettiTeam2.Play();
            confettiPlayed = true;
            //Show victory text
            //Victory sound
            //Move camera to team 2
            //After x seconds bring up victory menu
        }
    }
}
