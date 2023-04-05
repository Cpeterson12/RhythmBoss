
using System;
using System.Collections;
using System.Threading;
using UnityEngine;
using UnityEngine.Events;

public class TimerBehaviour : MonoBehaviour
{
  public UnityEvent startEvent, countdownEvent;
  public float currCountdownValue;
  public IntData time;
  public int maxTime;

  public void Start()
  {
    time.value = maxTime;
  }

  public void StartCountdown()
  {
    StartCoroutine(Countdown());
  }

  public IEnumerator Countdown()
  {
    while (time.value > 0)
    {
      
      yield return new WaitForSeconds(1);
      time.value--;
    }
    countdownEvent.Invoke();
    
  }
  
  
}
