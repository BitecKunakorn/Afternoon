using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WarpController : MonoBehaviour
{
     public string sceneName;
     public AudioSource warpsound;
    private void OnTriggerEnter(Collider other)
    {    // print(other.)
        if (other.gameObject.tag == "Player")
        {
            Invoke("LoadNextScene", 0.6f);
            PlayerPrefs.SetString("PrevScene",sceneName);
            
            var player = other.gameObject.GetComponent<PlayerControllersRigidbody>();
           // PlayerPrefs.SetInt("CoinCount", player.coinCount);
            warpsound?.Play();
           // SceneManager.LoadScene(sceneName);
        }
    }
    void LoadNextScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
