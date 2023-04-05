using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class DelayBehaviour : MonoBehaviour
{
  public FloatData numbers;
  public UnityEvent GoNow;
  public void DelayStart()
  {
    StartCoroutine(WaitForFunction());
  }
  
  public IEnumerator WaitForFunction()
  {
    while (numbers.value > 0)
    {
      yield return new WaitForSeconds(1.0f);
      numbers.value --;
    }
    GoNow.Invoke();
  }
}