using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlaygroundSceneManager : MonoBehaviour
{
    public Text uiScore;
    public Text uiTextbullet;
     
    public void GoToHome()
    {
        SceneManager.LoadScene("Home");
    }
    public void SetScore(int amount)
    {
        uiScore.text = amount.ToString();
    }
    public void SetTextbullet(int amount)
    {
        uiTextbullet.text = amount.ToString();
    }

}
