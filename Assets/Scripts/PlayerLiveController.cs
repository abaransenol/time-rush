using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLiveController : MonoBehaviour
{
    public GameObject dieScreen, onGameScreen;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayerDied()
    {
        Time.timeScale = 0;
        this.onGameScreen.SetActive(false);
        this.dieScreen.SetActive(true);
    }
}
