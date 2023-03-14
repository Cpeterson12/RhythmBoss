
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolBehaviour : MonoBehaviour
{
  public List<Transform> poolList;
  public float seconds = 0.2f;
  private WaitForSeconds wfsObj;
  private int i;
  public bool canRun = false;
  public Vector3 spawn;
 // public int amountToPool;
 // GameObject tmp;
//  public GameObject objectToPool;

public void Start()
{
  canRun = true;
}

public void CanRunSetTrue()
  {
    canRun = true;
    StartCoroutine(Pooling());
  }
  
  public void CanRunSetFalse()
  {
    canRun = false;
    StopCoroutine(Pooling());
  }
  
  public IEnumerator Pooling()
  {
    
    wfsObj = new WaitForSeconds(seconds);
    while (canRun == true)
    {
      poolList[i].transform.position = spawn;
      poolList[i].gameObject.SetActive(true);
      i++;
      yield return wfsObj;
      if (i > poolList.Count - 1)
      {
        i = 0;
      }
    }
  }
  
}
 