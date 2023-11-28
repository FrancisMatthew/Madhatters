using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundManager : MonoBehaviour
{
    public NoteMove noteA;
    public NoteMove noteD;
    public NoteMove noteL;
    public NoteMove noteR;

    public int team1Victories;
    public int team2Victories;

    public ScoreTrackerScript scoreTracker;

    public GameObject team1VictoryScreen;
    public GameObject team2VictoryScreen;

    public GameObject timerRound2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextRound()
    {
        VictoryTally();
        NoteSpeedAdjuster();
        scoreTracker.teamWon = 0;

        team1VictoryScreen.SetActive(false);
        team2VictoryScreen.SetActive(false);
        timerRound2.SetActive(true);
    }

    public void VictoryTally()
    {
        if (scoreTracker.teamWon == 1)
        {
            team1Victories++;
        }
        else if (scoreTracker.teamWon == 2)
        {
            team2Victories++;
        }

        if (team1Victories == 3)
        {
            //Team 1 ultimate victory
        }
        else if (team2Victories == 3)
        {
            //Team 2 ultimate victory

        }
    }

    public void NoteSpeedAdjuster()
    {
        if (scoreTracker.teamWon == 1)
        {
            noteA.beatTempo = noteA.beatTempo + 5000;
            noteD.beatTempo = noteA.beatTempo + 5000;
        }
        else if (scoreTracker.teamWon == 2)
        {
            noteL.beatTempo = noteA.beatTempo + 5000;
            noteR.beatTempo = noteA.beatTempo + 5000;
        }
    }
}
