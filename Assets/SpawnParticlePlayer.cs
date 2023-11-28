using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnParticlePlayer : MonoBehaviour
{
    public ParticleSystem spawnParticlesTeam1;
    public ParticleSystem spawnParticlesTeam2;
    public Transform otherParticleLocation;


    public void SpawnParticlePlayerTeam1()
    {
        spawnParticlesTeam1.Play();
        StartCoroutine(Team1ParticleMove());
    }

    public void SpawnParticlePlayerTeam2()
    {
        spawnParticlesTeam2.Play();
        StartCoroutine(Team2ParticleMove());
    }

    public IEnumerator Team2ParticleMove()
    {
        yield return new WaitForSeconds(3);

        transform.position += new Vector3(0, 0, -5);
        otherParticleLocation.transform.position += new Vector3(0, 0, -5);

    }

    public IEnumerator Team1ParticleMove()
    {
        yield return new WaitForSeconds(3);

        transform.position += new Vector3(0, 0, 5);
        otherParticleLocation.transform.position += new Vector3(0, 0, 5);
    }
}
