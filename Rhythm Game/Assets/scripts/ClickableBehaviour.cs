
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class ClickableBehaviour : OnBeatBehaviour
{
   public FloatData timerShake;
   public UnityEvent onTimeEvent, offBeatEvent, offBeatDelayEvent;
   public void OnMouseDown()
   {
      if(onTime == true)
      {
         onTimeEvent.Invoke();
         Debug.Log("Ya");
      }
      else
      {
         offBeatEvent.Invoke();
      }
      
   }

   public IEnumerator DelayBeat()
   {
      while (timerShake.value > 0)
      {
         Debug.Log("help");
         yield return new WaitForSeconds(1.0f);
         timerShake.value--;
      }
      offBeatDelayEvent.Invoke();
   }

   public void CallEvent()
   {
      StartCoroutine(DelayBeat());
   }
}


