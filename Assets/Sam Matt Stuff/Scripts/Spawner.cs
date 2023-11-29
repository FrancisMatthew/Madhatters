using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net.Mime;
using System.Security.Cryptography;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private GameObject noteToSpawn;
    [SerializeField]
    float randomSpawn;

    // Sets the random at the beginning of the game and starts the spawning of the notes
    void Start()
    {
        randomSpawn = Random.Range(1f,7f);
        StartCoroutine(spawnNote(randomSpawn, noteToSpawn));
    }

    // Spawns the notes at the spawn point at random
    private IEnumerator spawnNote(float interval, GameObject note)
    {
        yield return new WaitForSeconds(interval);
        GameObject newNote = Instantiate(note, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
        StartCoroutine(spawnNote(interval, note));
    }
}
