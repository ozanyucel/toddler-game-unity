using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalManager : MonoBehaviour {

    public Sprite[] spriteList;

    public Transform[] spawnLocations;

    public GameObject animalPrefab;
    private const float SPAWN_PERIOD = 5;
    private const float SPAWNS_PER_SECOND = 1 / SPAWN_PERIOD;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (isTimeToSpawn())
        {
            Spawn();
        }
	}

    private void Spawn()
    {
        var location = spawnLocations[UnityEngine.Random.Range(0, spawnLocations.Length)];

        GameObject animal = Instantiate(animalPrefab, location);
        animal.transform.position = location.position;

        var sprite = spriteList[UnityEngine.Random.Range(0, spriteList.Length)];

        animal.GetComponentInChildren<SpriteRenderer>().sprite = sprite;

    }

    private bool isTimeToSpawn()
    {
        float threshold = SPAWNS_PER_SECOND * Time.deltaTime;

        return (UnityEngine.Random.value < threshold);
    }
}
