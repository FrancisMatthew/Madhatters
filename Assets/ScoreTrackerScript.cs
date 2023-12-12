using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTrackerScript : MonoBehaviour
{
    public int characterSetActive = 1;
    public float tempVariable = 0;

    public int team1Members = 3;
    public int team2Members = 3;

    public int teamWon;

    public ParticleSystem confettiTeam1;
    public ParticleSystem confettiTeam2;

    bool confettiPlayed = false;

    public GameObject team1GameOver;
    public GameObject team2GameOver;

    public GameObject rope;

    [Header("Notes")]
    public NoteMove noteA;
    public NoteMove noteD;
    public NoteMove noteL;
    public NoteMove noteR;


    //There's probably a simpler way to do this but it works.
    [Header("OriginalCharacters")]
    public Animator player1Animator;
    public Animator player2Animator;
    public Animator player3Animator;
    public Animator player4Animator;
    public Animator player5Animator;
    public Animator player6Animator;

    public GameObject player1;
    public GameObject player2;
    public GameObject player3;
    public GameObject player4;
    public GameObject player5;
    public GameObject player6;

    [Header("New Characters")]

    public Animator player7Animator;
    public Animator player8Animator;
    public Animator player9Animator;
    public Animator player10Animator;
    public Animator player11Animator;
    public Animator player12Animator;

    public GameObject player7;
    public GameObject player8;
    public GameObject player9;
    public GameObject player10;
    public GameObject player11;
    public GameObject player12;

    public AudioSource stopAudio;

    void Awake()
    {
        tempVariable = Random.Range(0, 2);

        if (tempVariable == 0)
        {
            characterSetActive = 1;
        }
        else
        {
            characterSetActive = 2;
        }

        CharactersSetActive();
    }

    public void CharactersSetActive()
    {
        if (characterSetActive == 1)
        {
            player1.SetActive(true);
            player2.SetActive(true);
            player3.SetActive(true);
            player4.SetActive(true);
            player5.SetActive(true);
            player6.SetActive(true);

            player7.SetActive(false);
            player8.SetActive(false);
            player9.SetActive(false);
            player10.SetActive(false);
            player11.SetActive(false);
            player12.SetActive(false);

        }
        else if (characterSetActive == 2)
        {
            player1.SetActive(false);
            player2.SetActive(false);
            player3.SetActive(false);
            player4.SetActive(false);
            player5.SetActive(false);
            player6.SetActive(false);

            player7.SetActive(true);
            player8.SetActive(true);
            player9.SetActive(true);
            player10.SetActive(true);
            player11.SetActive(true);
            player12.SetActive(true);
        }
    }

    void Update()
    {
        NoteSpeedChange();
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

    public void NoteSpeedChange()
    {
        switch(team1Members)
        {
            case 1:
                noteA.beatTempo = 700;
                noteD.beatTempo = 700;

                noteL.beatTempo = 1400;
                noteR.beatTempo = 1400;
                break;
            case 2:
                noteA.beatTempo = 700;
                noteD.beatTempo = 700;

                noteL.beatTempo = 950;
                noteR.beatTempo = 950;
                break;
            case 3:
                noteA.beatTempo = 700;
                noteD.beatTempo = 700;

                noteL.beatTempo = 700;
                noteR.beatTempo = 700;
                break;
            case 4:
                noteA.beatTempo = 950;
                noteD.beatTempo = 950;

                noteL.beatTempo = 700;
                noteR.beatTempo = 700;
                break;
            case 5:
                noteA.beatTempo = 1400;
                noteD.beatTempo = 1400;

                noteL.beatTempo = 700;
                noteR.beatTempo = 700;
                break;
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
        if (characterSetActive == 1)
        {
            player1Animator.SetTrigger("Victory");
            player2Animator.SetTrigger("Victory");
            player3Animator.SetTrigger("Victory");
            player4Animator.SetTrigger("Victory");
            player5Animator.SetTrigger("Victory");
            player6Animator.SetTrigger("Victory");
        }
        else
        {
            player7Animator.SetTrigger("Victory");
            player8Animator.SetTrigger("Victory");
            player9Animator.SetTrigger("Victory");
            player10Animator.SetTrigger("Victory");
            player11Animator.SetTrigger("Victory");
            player12Animator.SetTrigger("Victory");
        }
    }

    public void Team1Rotate()
    {
        if (characterSetActive == 1)
        {
            player1.transform.RotateAround(player1.transform.position, player1.transform.up, 180f);
            player2.transform.RotateAround(player2.transform.position, player2.transform.up, 180f);
            player3.transform.RotateAround(player3.transform.position, player3.transform.up, 180f);
            player4.transform.RotateAround(player4.transform.position, player4.transform.up, 180f);
            player5.transform.RotateAround(player5.transform.position, player5.transform.up, 180f);
            player6.transform.RotateAround(player6.transform.position, player6.transform.up, 180f);
        }
        else
        {
            player7.transform.RotateAround(player7.transform.position, player1.transform.up, 180f);
            player8.transform.RotateAround(player8.transform.position, player2.transform.up, 180f);
            player9.transform.RotateAround(player9.transform.position, player3.transform.up, 180f);
            player10.transform.RotateAround(player10.transform.position, player4.transform.up, 180f);
            player11.transform.RotateAround(player11.transform.position, player5.transform.up, 180f);
            player12.transform.RotateAround(player12.transform.position, player6.transform.up, 180f);
        }
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
