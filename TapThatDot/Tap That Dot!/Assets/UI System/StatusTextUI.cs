using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusTextUI : MonoBehaviour
{
    public GameData GameData;
    public TMPro.TextMeshProUGUI Text;
    public bool _isFirstTap = true;

    void Start()
    {
        Text = GetComponent<TMPro.TextMeshProUGUI>();
        Text.text = "Tap to Start!";
    }

    void Update() //This is messy at the moment but it works. "Indeed, it is... and I just made it worst. -Javier"
    {
        if(Input.GetMouseButtonDown(0) && !GameData.IsRunning){
            _isFirstTap = false;
        }

        if(!_isFirstTap && GameData.Countdown > 0){
            Text.text = Mathf.Round(GameData.Countdown).ToString();
        }
        
        if(GameData.Countdown >= 3){
            Text.text = "Tap to Start!";
        }
        if(GameData.Countdown < 0 && GameData.Countdown > -2)
        {
            Text.text = "GO!";
            
        }
        if(GameData.DotsRemaining == 0)
        {
            Text.text = "YOU WIN!"; 
        }

        if (GameData.Countdown < -2 && GameData.Countdown > -4) {
                Text.text = "";
            }
        }

    }
