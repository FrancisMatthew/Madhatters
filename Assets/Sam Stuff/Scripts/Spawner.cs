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

    // Start is called before the first frame update
    void Start()
    {
        randomSpawn = Random.Range(1f,7f);
        StartCoroutine(spawnNote(randomSpawn, noteToSpawn));
    }

    private IEnumerator spawnNote(float interval, GameObject note)
    {
        yield return new WaitForSeconds(interval);
        GameObject newNote = Instantiate(note, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
        StartCoroutine(spawnNote(interval, note));
    }
}
