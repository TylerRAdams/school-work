using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class SelectLevelMenu : MonoBehaviour
{


    public void GoToLevelOne(bool LoadScene) {

        GameData.SetLevel(5,1,25);

        if (LoadScene) {
            SceneManager.LoadScene("Tap-That-Dot");

        }

    }
    public void GoToLevelTwo(bool LoadScene)
    {

        GameData.SetLevel(7, 2, 50);
        if (LoadScene)
        {
            SceneManager.LoadScene("Tap-That-Dot");

        }
    }
    public void GoToLevelThree(bool LoadScene)
    {

        GameData.SetLevel(9, 3, 75);
        if (LoadScene)
        {
            SceneManager.LoadScene("Tap-That-Dot");

        }

    }
    public void GoToLevelFour(bool LoadScene)
    {

        GameData.SetLevel(11, 4, 100);
        if (LoadScene)
        {
            SceneManager.LoadScene("Tap-That-Dot");

        }

    }
    public void GoToLevelFive(bool LoadScene)
    {

        GameData.SetLevel(15, 5, 125);
        if (LoadScene==true)
        {
            SceneManager.LoadScene("Tap-That-Dot");

        }

    }

    
    public void check()
    {
        Debug.Log("Clicked");
    }

    public void GoBack() {

        SceneManager.LoadScene("MainMenu");

    }

}
