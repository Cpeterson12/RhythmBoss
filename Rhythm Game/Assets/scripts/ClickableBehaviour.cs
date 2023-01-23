
using UnityEngine;
using UnityEngine.Events;

public class ClickableBehaviour : OnBeatBehaviour
{
   public UnityEvent onTimeEvent, offBeatEvent;
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
}
