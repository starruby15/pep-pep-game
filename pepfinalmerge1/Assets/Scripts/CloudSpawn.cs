using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawn : MonoBehaviour {

    public int arraySize = 5;
    public GameObject cloudPrefab1;
    public GameObject cloudPrefab2; 
    public float SpawnRate = 5f;
    public float cloudMin = -1f;
    public float cloudMax = 3.5f; 

    private GameObject[] angryclouds;
    private Vector2 objectPoolPosition = new Vector2(-25f, -35f);
    private float timeSinceLastSpawned;
    private float SpawnXPosition = 10f;
    private int currentCloud = 0;


    private GameObject[] happyclouds;
    private int currenthCloud = 0;
    float offsetMin = -1f;
    float offSetMax = 1f; 


    // Use this for initialization
    void Start () {
        angryclouds = new GameObject[arraySize];
        happyclouds = new GameObject[arraySize];
        for (int i = 0; i < arraySize; i++)
        {
            angryclouds[i] = (GameObject)Instantiate(cloudPrefab1, objectPoolPosition, Quaternion.identity);
            happyclouds[i] = (GameObject)Instantiate(cloudPrefab2, objectPoolPosition, Quaternion.identity);
        }
	}
	
	// Update is called once per frame
	void Update () {
        timeSinceLastSpawned += Time.deltaTime; 
        if(GameControl.instance.gameOver == false && timeSinceLastSpawned >= SpawnRate)
        {
            timeSinceLastSpawned = 0; 
            float SpawnYPosition1 = Random.Range(cloudMin, cloudMax);
            float SpawnYPosition2 = Random.Range(cloudMin, cloudMax);
            float randomOffSet = Random.Range(offsetMin, offSetMax);
            angryclouds[currentCloud].transform.position = new Vector2(SpawnXPosition, SpawnYPosition1);
            happyclouds[currentCloud].transform.position = new Vector2(SpawnXPosition + randomOffSet, SpawnYPosition1);
            currentCloud++; 
            if(currentCloud >= arraySize)
            {
                currentCloud = 0; 
            }
        }
	}
}
