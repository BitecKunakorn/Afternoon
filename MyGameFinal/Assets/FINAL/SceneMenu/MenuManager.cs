using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    // Start is called before the first frame update
    //˹���������ѡ
    public void GoToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    //˹�����������ͧ˹�ҷ�� 1
    public void GoToStoryTellingScene1()
    {
      
        SceneManager.LoadScene("StoryTellingScene 1");
    }
    //˹�����������ͧ˹�ҷ�� 2
    public void GoToP2_StoryTellingScene()
    {
    
        SceneManager.LoadScene("P2_StoryTellingScene");
    }
    //˹�����������ͧ˹�ҷ�� 3
    public void GoToP3_StoryTellingScene()
    {
       
        SceneManager.LoadScene("P3_StoryTellingScene");
    }
    //˹��Ҽ��Ѵ��
    public void GoToCreditSceen()
    {
        SceneManager.LoadScene("CreditSceen");
    }
    //˹������͡�����
    public void GoToChooselevelScene()
    {
      
        SceneManager.LoadScene("ChooselevelScene");
    }

    //˹������͡����� 1
    public void GoTolevel1()
    {

        SceneManager.LoadScene("level1");
    }

    //˹������͡����� 2
    public void GoTolevel2()
    {

        SceneManager.LoadScene("level2");
    }
    //˹������͡����� 3
    public void GoToleve3()
    {

        SceneManager.LoadScene("level3");
    }

    //˹������͡����� 4
    public void GoToleve4()
    {

        SceneManager.LoadScene("leve4");
    }


    // Update is called once per frame
    void Update()
    {
        
    }
   //�͡������
    public void ExitGame()
    {
        Application.Quit();
    }
}
