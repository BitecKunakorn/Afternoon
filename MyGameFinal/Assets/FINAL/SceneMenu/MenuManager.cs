using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    // Start is called before the first frame update
    //หนุ้าเมนูหลัก
    public void GoToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    //หนุ้าเล่าเรื่องหน้าที่ 1
    public void GoToStoryTellingScene1()
    {
      
        SceneManager.LoadScene("StoryTellingScene 1");
    }
    //หนุ้าเล่าเรื่องหน้าที่ 2
    public void GoToP2_StoryTellingScene()
    {
    
        SceneManager.LoadScene("P2_StoryTellingScene");
    }
    //หนุ้าเล่าเรื่องหน้าที่ 3
    public void GoToP3_StoryTellingScene()
    {
       
        SceneManager.LoadScene("P3_StoryTellingScene");
    }
    //หนุ้าผู้จัดทำ
    public void GoToCreditSceen()
    {
        SceneManager.LoadScene("CreditSceen");
    }
    //หนุ้าเลือกเลเวล
    public void GoToChooselevelScene()
    {
      
        SceneManager.LoadScene("ChooselevelScene");
    }

    //หนุ้าเลือกเลเวล 1
    public void GoTolevel1()
    {

        SceneManager.LoadScene("level1");
    }

    //หนุ้าเลือกเลเวล 2
    public void GoTolevel2()
    {

        SceneManager.LoadScene("level2");
    }
    //หนุ้าเลือกเลเวล 3
    public void GoToleve3()
    {

        SceneManager.LoadScene("level3");
    }

    //หนุ้าเลือกเลเวล 4
    public void GoToleve4()
    {

        SceneManager.LoadScene("leve4");
    }


    // Update is called once per frame
    void Update()
    {
        
    }
   //ออกโปรเเกรม
    public void ExitGame()
    {
        Application.Quit();
    }
}
