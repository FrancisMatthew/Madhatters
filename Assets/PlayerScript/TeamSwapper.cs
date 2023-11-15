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

    public ParticleSystem spawnParticlesTeam1;
    public ParticleSystem spawnParticlesTeam2;

    public ParticleSystem deathParticlesTeam1;
    public ParticleSystem deathParticlesTeam2;

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
        DeathParticlePlayer();

        scoreTracker.team1Members++;
        scoreTracker.team2Members--;
        playerTeam = 1;

        //Change models + Turn 180 degrees (Once art assets are in)

        SpawnParticlePlayer();

        transform.position = team1DropLocation.transform.position;
        transform.rotation = originalRotation;

        StartCoroutine(Team1SpawnMove());

    }

    public void JoinTeam2()
    {
        DeathParticlePlayer();

        scoreTracker.team2Members++;
        scoreTracker.team1Members--;
        playerTeam = 2;

        //Change models + Turn 180 degrees (Once art assets are in)

        SpawnParticlePlayer();

        transform.position = team2DropLocation.transform.position;
        transform.rotation = originalRotation;

        StartCoroutine(Team2SpawnMove());
    }

    /// <summary>
    /// Delays the moving of the spawn locations. May cause issues if game is played too fast. Keep an eye on this.
    /// </summary>
    /// <returns></returns>
    public IEnumerator Team2SpawnMove()
    {
        yield return new WaitForSeconds(3);
        team2DropLocation.transform.position += new Vector3(0, 0, -5);
        team1DropLocation.transform.position += new Vector3(0, 0, -5);
    }

    public IEnumerator Team1SpawnMove()
    {
        yield return new WaitForSeconds(3);
        team1DropLocation.transform.position += new Vector3(0, 0, 5);
        team2DropLocation.transform.position += new Vector3(0, 0, 5);
    }

    public void SpawnParticlePlayer()
    {
        if (playerTeam == 1)
        {
            spawnParticlesTeam1.Play();
        }
        else
        {
            spawnParticlesTeam2.Play();
        }
    }

    public void DeathParticlePlayer()
    {
        if (playerTeam == 1)
        {
            deathParticlesTeam1.Play();
        }
        else
        {
            deathParticlesTeam2.Play();
        }
    }
}
