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

    void loadMap()
    {
        if (spawnPoint == null)
        {
            spawnPoint = startMap.transform.GetChild(1).gameObject.transform;

        } else
        {
            spawnPoint = currentMap.transform.GetChild(1).gameObject.transform;
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
