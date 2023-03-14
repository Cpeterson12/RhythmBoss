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
    yield return new WaitForSeconds(numbers.value);
    GoNow.Invoke();
  }
}