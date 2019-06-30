using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DotSpawner : MonoBehaviour
{
    public AnchoredMotor Motor;
    public GameObject DotPrefab;
    public GameData GameData;
    
    void Start()
    {
        SpawnDot();
    }
    public void SpawnDot()
    {
        RemoveDuplicates();

        var dot = GameObject.FindWithTag("Dot");
        if (dot) { GameObject.Destroy(dot); }

        var angle = Random.Range(GameData.MinSpawnAngle, GameData.MaxSpawnAngle);
        var go = Instantiate(DotPrefab, Motor.transform.position, Quaternion.identity, Motor.transform.parent);
        go.transform.RotateAround(transform.position, Vector3.forward, angle*(int)Motor.Direction);
    }

    void RemoveDuplicates() {

        var dots = GameObject.FindGameObjectsWithTag("Dot");
        foreach (var dot in dots){
            Destroy(dot);
        }
    }

}
