using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorManager : MonoBehaviour
{

    
    public Color LoseColor;
    public Color[] BackgroundColors = new Color[5];
    public GameData GameData;
    Camera _cam;
    void Start()
    {
        _cam = GetComponent<Camera>();
        if(GameData.CurrentLevel > 0){
            _cam.backgroundColor= BackgroundColors[GameData.CurrentLevel-1];
        }
    }

    // Update is called once per frame
    public void ChangeToLoseColor()
    {
        _cam.backgroundColor= LoseColor;
    }

    public void ChangeToStartColor()
    {
        if(GameData.CurrentLevel > 0){
            _cam.backgroundColor= BackgroundColors[GameData.CurrentLevel-1];
        }
    }
}

