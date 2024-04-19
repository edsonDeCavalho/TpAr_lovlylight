using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCode : MonoBehaviour
{
    public Transform[] spawnpoints;
    public GameObject[] balloons;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartSpawning());
    }

    IEnumerator StartSpawning()
    {
        yield return new WaitForSeconds(4);

        // Iterate over each balloon to spawn
        for (int i = 0; i < balloons.Length; i++)
        {
            // Get a random index for the spawn point
            int randomSpawnIndex = Random.Range(0, spawnpoints.Length);
            
            // Instantiate the balloon at the randomly selected spawn point
            Instantiate(balloons[i], spawnpoints[randomSpawnIndex].position, Quaternion.identity);
        }

        // Restart the coroutine to keep spawning balloons
        StartCoroutine(StartSpawning());
    }
}