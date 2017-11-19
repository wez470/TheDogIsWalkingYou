using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CactusSpawner : MonoBehaviour {
    public List<GameObject> cacti = new List<GameObject>();
    public float LowestTimeBetweenSpawns = 1f;
    public float HightestTimeBetweenSpawns = 3f;

    private float nextSpawnTime = 0f;

	void Start () {
        this.nextSpawnTime = 1f;
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.timeSinceLevelLoad > nextSpawnTime) {
            GameObject cactusPrefab = cacti[Random.Range(0, cacti.Count)];
            GameObject newCactus = (GameObject)Instantiate(cactusPrefab);
            newCactus.transform.position = this.transform.position;
            this.nextSpawnTime = Time.timeSinceLevelLoad + Random.Range(LowestTimeBetweenSpawns, HightestTimeBetweenSpawns);
        }

    }
}
