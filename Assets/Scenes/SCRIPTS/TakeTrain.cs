using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeTrain : MonoBehaviour
{
    public SubwayTrain Train;
    public float takeTrainDistance = 0.5f;

    public void Start()
    {
        Train.GetComponent<Timer>().StartTimer();
    }

    public void Update()
    {
        if (Vector3.Distance(transform.position, Train.transform.position) < takeTrainDistance )
        {
            Train.isActive = true;
            gameObject.SetActive(false);
        }
    }
}
