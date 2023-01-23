using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

 public class OnBeatBehaviour : MonoBehaviour
 {
      public ID idObj;
      public UnityEvent startEvent, matchEvent, noMatchEvent, noMatchDelayedEvent;
      public bool onTime;

      public void Start()
      {
          onTime = false;
      }

      public IEnumerator OnTriggerEnter(Collider other)
      {
          onTime = true;
          var tempObj = other.GetComponent<IDcontainerBehaviour>();
          
          if (tempObj == null)
              yield break;
          
          var otherID = tempObj.idObj;
         
          if (otherID == idObj)
          {
              matchEvent.Invoke();
          }
          else
          {
              noMatchEvent.Invoke();
              yield return new WaitForSeconds(0.5f);
              noMatchDelayedEvent.Invoke();
          }
      }

      public void OnTriggerExit(Collider other)
      {
          onTime = false;
      }
 }
