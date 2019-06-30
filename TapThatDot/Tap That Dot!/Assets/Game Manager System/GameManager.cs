using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameData GameData;
    public bool _isFirstTap = true;

    
    void Start()
    {
        GameData.ResetLevel();
    }

    void Update(){
        if(Input.GetMouseButtonDown(0) && !GameData.IsRunning){
            _isFirstTap = false;
        }
        if(!_isFirstTap){
            GameData.Countdown -= Time.deltaTime;
        }

        if(GameData.Countdown < 0.05f && GameData.Countdown > -0.05f){ //Can't just set it to 0 because sometimes it'll miss it.
            GameData.IsRunning = true;
            _isFirstTap = false;
        }


    }

    public void LoadLevel(){
        GameData.ResetLevel();
        _isFirstTap = true;
    }

}
