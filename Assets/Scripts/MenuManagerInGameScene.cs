using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManagerInGameScene : MonoBehaviour
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

    public void HomeButton()
    {
        SceneManager.LoadScene(0);
    }

    public void PlayerDied()
    {
        Time.timeScale = 0;
        this.onGameScreen.SetActive(false);
        this.dieScreen.SetActive(true);
    }
}
