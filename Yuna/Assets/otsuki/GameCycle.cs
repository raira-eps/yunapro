using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameCycle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void goToPlayScreen()
    {
        SceneManager.LoadScene("Game");
    }
    public void GoToTheResultsScreen()
    {
        SceneManager.LoadScene("end");
    }
    public void goToTitleScreen()
    {
        SceneManager.LoadScene("Title");
    }
}
