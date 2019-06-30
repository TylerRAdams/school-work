using UnityEngine;

[CreateAssetMenu]
public class GameData : ScriptableObject
{
    static public int CurrentLevel;
    static public int DotsRemaining;
    public bool IsRunning = false;
    public int MinSpawnAngle = 30;
    public int MaxSpawnAngle = 90;
    public int CurrentMotorSpeed = 60;
    public int MaxMotorSpeed = 500;
    static public int MinMotorSpeed = 50;

    public float Countdown = 3.0f; //Countdown to start a level


    public static void SetLevel(int dots,int lvl,int speed) {

        DotsRemaining = dots;

        CurrentLevel = lvl;

        MinMotorSpeed = speed;
    }



    public void ResetLevel() {
        IsRunning = false;
        DotsRemaining = CurrentLevel;
        Countdown = 3;
        CurrentMotorSpeed = MinMotorSpeed;
    }

    public void ResetData(){
        CurrentLevel = 1;
        DotsRemaining = CurrentLevel;
    }

    public void IncreaseMotorSpeed(int increaseValue){
        if(increaseValue > 0){
            CurrentMotorSpeed = Mathf.Min(CurrentMotorSpeed + increaseValue, MaxMotorSpeed);    
        }
        else{
            Debug.LogError("Error. Increase speed value must be greater than 0.");
        }
    }

    public void DecreaseMotorSpeed (int decreaseValue){
        if(decreaseValue > 0){
            CurrentMotorSpeed = Mathf.Max(CurrentMotorSpeed - decreaseValue, MinMotorSpeed);    
        }
        else{
            Debug.LogError("Error. Decrease speed value must be greater than 0.");
        }
    }

    public void StopGame(){
        IsRunning = false;
    }




}
