using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeSceenManager : MonoBehaviour
{
    public void GoToMygame()
    {
        PlayerPrefs.SetInt("CoinCount", 0);
        SceneManager.LoadScene("Mygame");
    }
    public void ContinuePlay()
    {
        if (PlayerPrefs.HasKey("PrevScene"))
        {
            string prevSceneName =PlayerPrefs.GetString("PrevScene");
            SceneManager.LoadScene(prevSceneName);
        }
        
    }
    public void GoToHome()
    {
       
        SceneManager.LoadScene("Home");
    }

    public void GoToCreditScene()
    {
        SceneManager.LoadScene("CreditScene");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
