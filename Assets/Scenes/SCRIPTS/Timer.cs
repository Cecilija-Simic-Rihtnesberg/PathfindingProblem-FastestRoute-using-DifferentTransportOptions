using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
   private float time;
   private bool timerIsActive;

   public void Update()
   {
      if (timerIsActive)
      {
         time += Time.deltaTime;
      }
   }

   public void StartTimer()
   {
      timerIsActive = true;
   }

   public void StopTimer()
   {
      timerIsActive = false;
      Debug.Log($"{gameObject.name} time is = {time}");
   }
}
