using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTrackerScript : MonoBehaviour
{
    public int team1Members = 3;
    public int team2Members = 3;

    public int teamWon;

    public ParticleSystem confettiTeam1;
    public ParticleSystem confettiTeam2;

    bool confettiPlayed = false;

    public GameObject team1GameOver;
    public GameObject team2GameOver;

    public GameObject rope;

    //There's probably a simpler way to do this but it works.
    public Animator player1Animator;
    public Animator player2Animator;
    public Animator player3Animator;
    public Animator player4Animator;
    public Animator player5Animator;
    public Animator player6Animator;

    public Transform player1;
    public Transform player2;
    public Transform player3;
    public Transform player4;
    public Transform player5;
    public Transform player6;

    public AudioSource stopAudio;

    void Update()
    {
        if (team1Members == 6 && !confettiPlayed)
        {
            confettiTeam1.Play();
            GeneralVictory();
            Team1Rotate();
            teamWon = 1;
            StartCoroutine(VictoryScreen());
        }
        else if (team2Members == 6 && !confettiPlayed)
        {
            confettiTeam2.Play();
            GeneralVictory();
            teamWon = 2;
            StartCoroutine(VictoryScreen());
        }
    }

    public void GeneralVictory()
    {
        confettiPlayed = true;
        VictoryAnimations();
        stopAudio.Play();
        Destroy(rope);
    }

    public void VictoryAnimations()
    {
        player1Animator.SetTrigger("Victory");
        player2Animator.SetTrigger("Victory");
        player3Animator.SetTrigger("Victory");
        player4Animator.SetTrigger("Victory");
        player5Animator.SetTrigger("Victory");
        player6Animator.SetTrigger("Victory");
    }

    public void Team1Rotate()
    {
        player1.RotateAround(player1.transform.position, player1.transform.up, 180f);
        player2.RotateAround(player2.transform.position, player2.transform.up, 180f);
        player3.RotateAround(player3.transform.position, player3.transform.up, 180f);
        player4.RotateAround(player4.transform.position, player4.transform.up, 180f);
        player5.RotateAround(player5.transform.position, player5.transform.up, 180f);
        player6.RotateAround(player6.transform.position, player6.transform.up, 180f);
    }

    public IEnumerator VictoryScreen()
    {
        yield return new WaitForSeconds(3);
        
        if (teamWon == 1)
        {
            team1GameOver.SetActive(true);
        }
        else if (teamWon == 2)
        {
            team2GameOver.SetActive(true);
        }

    }
}
