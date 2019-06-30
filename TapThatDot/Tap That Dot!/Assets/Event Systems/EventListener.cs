using UnityEngine;
using UnityEngine.Events;


public class EventListener : MonoBehaviour
{
    public GameEvent[] Events;
    public UnityEvent Response;

    void OnEnable(){
        foreach(GameEvent e in Events){
            e.Register(this);
        }
    }

    void OnDisable(){
        foreach(GameEvent e in Events){
            e.DeRegister(this);
        }
    }
    public void OnEventRaised(){Response.Invoke();}

}
