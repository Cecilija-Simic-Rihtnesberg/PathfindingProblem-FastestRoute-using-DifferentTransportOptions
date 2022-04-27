using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubwayTrain : MonoBehaviour
{
    public SubwayStation StartingStation;

    private SubwayStation TargetStation;
    public float Speed;

    private bool isStopt;
    private SubwayStation LastStation;

    private Timer trainTimer;

    public bool isActive = false;
    private void Start()
    {
        trainTimer = GetComponent<Timer>();
        TargetStation = StartingStation.NextStation;
        LastStation = StartingStation;
    }

    private void Update()
    {
        if(isActive == false) return;
        
        transform.position = Vector3.MoveTowards(transform.position, TargetStation.transform.position, Speed * Time.deltaTime);
        
        if (Vector3.Distance(transform.position, TargetStation.transform.position) < 0.001f )
        {
            LastStation = TargetStation;
            if (!TargetStation.isFinalStation)
            {
                TargetStation = TargetStation.NextStation;
            }

            
            if (LastStation.isFinalStation && !isStopt)
            {
                trainTimer.StopTimer();
                isStopt = true;
            }
        }
    }
}
