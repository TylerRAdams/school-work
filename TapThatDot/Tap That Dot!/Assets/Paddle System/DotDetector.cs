using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DotDetector : MonoBehaviour
{
    GameObject _currentDot;
    GameObject _lastEnteredDot;
    public GameData GameData;
    public float LoseThreshold = 0.5f; 
    public GameEvent DotMissedEvent;
    public GameEvent DotScoredEvent;
    public GameEvent OnWinEvent;

    public AudioSource popSound; //Sets audio
    public AudioSource loseSound; //Sets audio

    //Gets audio in start
    void Start()
    {
        AudioSource[] sounds = GetComponents<AudioSource>();
        popSound = sounds[0];
        loseSound = sounds[1];
    }

  

    void Update()
    {
        if (GameData.IsRunning) {


            if (_lastEnteredDot && GetDistanceFromLastDot() > LoseThreshold) {

                TxtHandler Reader = new TxtHandler();                   
                if (Reader.getIsMuted() == 0)
                {
                    //Triggers the sound

                    loseSound.Play();
                }

                DotMissedEvent.Raise();
            }



            if (_didTap)
            {
                GameData.IsRunning = true;
                if (_currentDot != null)
                {
                    Destroy(_currentDot);
                    GameData.DotsRemaining--;


                    // Plays with the pitch of the sound so it does not get repetitive
                    popSound.pitch = Random.Range(1, 3);


                    TxtHandler Reader = new TxtHandler();

                    if (Reader.getIsMuted() == 0) {

                        //Triggers the sound
                        popSound.Play();
                       
                    }
      


                    if (GameData.DotsRemaining <= 0)
                    {
                       

                        int nextLevel = GameData.CurrentLevel+1;

                        Reader.writeLevel(nextLevel);

                        OnWinEvent.Raise();

                        SelectLevelMenu selector = new SelectLevelMenu();
                        //Read text file to see the current level
                        if (Reader.getLevel() == 1)
                        {
                            selector.GoToLevelOne(false);
                        }

                        if (Reader.getLevel() == 2)
                        {
                            selector.GoToLevelTwo(false);
                        }

                        if (Reader.getLevel() == 3)
                        {
                            selector.GoToLevelThree(false);
                        }

                        if (Reader.getLevel() == 4)
                        {
                            selector.GoToLevelFour(false);
                        }

                        if (Reader.getLevel() == 5)
                        {
                            selector.GoToLevelFive(false);
                        }
                        if (Reader.getLevel() == 6)
                        {
                            SceneManager.LoadScene("VictoryScreen");
                        }

                        GameData.DotsRemaining = 0;
                        //GameData.CurrentLevel = GameData.CurrentLevel+1;


                    }
                    else
                    {
                        DotScoredEvent.Raise();
                    }

                }
                else
                {
 
                    DotMissedEvent.Raise();

                }
            }
        }
     
    }

    float GetDistanceFromLastDot() {

        return (transform.position - _lastEnteredDot.transform.position).magnitude;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        _currentDot = other.gameObject;
    }

    void OnTriggerExit2D(Collider2D other)
    {
        _lastEnteredDot = _currentDot;
        _currentDot = null;

    }

    bool _didTap{
        get {

           return Input.GetMouseButtonDown(0);
        }
    
    }

}
