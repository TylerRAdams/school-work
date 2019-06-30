using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{


    public void PlayGame()
    {
        TxtHandler CurrentDataInTxtFile = new TxtHandler();

        SelectLevelMenu selector = new SelectLevelMenu();


        //Read text file to see the current level
        if (CurrentDataInTxtFile.getLevel() == 1)
        {
            selector.GoToLevelOne(true);
        }

        if (CurrentDataInTxtFile.getLevel() == 2)
        {
            selector.GoToLevelTwo(true);
        }

        if (CurrentDataInTxtFile.getLevel() == 3)
        {
            selector.GoToLevelThree(true);
        }

        if (CurrentDataInTxtFile.getLevel() == 4)
        {
            selector.GoToLevelFour(true);
        }

        if (CurrentDataInTxtFile.getLevel() == 5) {
            selector.GoToLevelFive(true);
        }

        SceneManager.LoadScene("Tap-That-Dot");

    }

    public void SelectLevel()
    {

        SceneManager.LoadScene("Level Selection");

    }

    void Update()
    {
        if (Input.GetKey("escape"))
            Application.Quit();
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void MuteOrUnmute(){

        TxtHandler Reader = new TxtHandler();

        if (Reader.getIsMuted() == 0) {

            Reader.writeIsMuted(1);
        }
        else if (Reader.getIsMuted() == 1)
        {

            Reader.writeIsMuted(0);
        }
    }
}
