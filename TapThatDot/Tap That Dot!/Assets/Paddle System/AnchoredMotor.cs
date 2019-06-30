using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnchoredMotor : MonoBehaviour
{
    public GameData GameData;
    public Direction Direction = Direction.Clockwise;
    public GameEvent OnPaddleReset;
    Vector3 _initialPos;

    Transform _anchor;
    // Start is called before the first frame update
    void Start()
    {
        _anchor = GameObject.FindWithTag("Anchor").transform;
        _initialPos = GetComponent<Transform>().localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        //If motor has started
        if (GameData.IsRunning) {
            transform.RotateAround(_anchor.position, Vector3.forward, GameData.CurrentMotorSpeed * Time.deltaTime * (int)Direction);
        }
        if (_didTap && GameData.IsRunning) {
            ChangeDirection();
        }
    }


    bool _didTap{
        get {
           return Input.GetMouseButtonDown(0);
        }
    
    }


    void ChangeDirection() //Switches direction of paddle
    {
        switch(Direction)
        {
            case Direction.Clockwise:
                Direction = Direction.AntiClockwise;
                break;
            case Direction.AntiClockwise:
                Direction = Direction.Clockwise;
                break;
        }
    }



    public void ResetPosition()
    {
        transform.localPosition = new Vector3(0, _initialPos.y,0);
        transform.localRotation = Quaternion.identity;

        OnPaddleReset.Raise();
    }
}

public enum Direction //Values were modified to remove redundant extra negative
{
    Clockwise = -1,
    AntiClockwise = 1
}
