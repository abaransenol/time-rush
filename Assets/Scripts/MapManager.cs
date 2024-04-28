using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class MapManager : MonoBehaviour
{
    public GameObject startMap;
    public List<GameObject> maps;
    public GameObject onGame;

    private GameObject currentMap;
    private Transform spawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        loadMap();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void loadMap()
    {
        if (spawnPoint == null)
        {
            spawnPoint = startMap.transform.GetChild(1).gameObject.transform;

        } else
        {
            var child1 = currentMap.transform.GetChild(0).gameObject;

            var enterTransform = child1.transform.GetChild(0).gameObject.transform.position;
            var exitTransform = child1.transform.GetChild(1).gameObject.transform.position;

            var totalX = exitTransform.x - enterTransform.x;
            var totalY = exitTransform.y - enterTransform.y;

            var tempSpawnPointPosition = child1.transform.GetChild(1).gameObject.transform.position;
            tempSpawnPointPosition.x = spawnPoint.position.x + totalX;
            tempSpawnPointPosition.y = spawnPoint.position.y + totalY;
            spawnPoint.position = tempSpawnPointPosition;

        }
        
        generateRandomMap();
        Instantiate(currentMap, spawnPoint.position, spawnPoint.rotation, onGame.transform);
    }

    void generateRandomMap()
    {
        var random = new System.Random();
        int randomIndex = random.Next(0, maps.Count);

        currentMap = maps[randomIndex];
    }
}
