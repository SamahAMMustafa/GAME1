using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject [] collectPrefabs;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
        	int collectIndex = Random.Range(0, collectPrefabs.Length);
        	Vector3 spawnPos = new Vector3(Random.Range(-5, 5), 0, 5);

        	// spawn objects from the distance -7 and 7 on the screen. Also in different locations.
        	Instantiate(collectPrefabs[collectIndex], new Vector3(Random.Range(-5, 5), 0, 5), collectPrefabs[collectIndex].transform.rotation);
        }
    }
}
