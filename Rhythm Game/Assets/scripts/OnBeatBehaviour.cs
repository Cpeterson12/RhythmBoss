using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

 public class OnBeatBehaviour : MonoBehaviour
 {
      public ID idObj;
      public UnityEvent startEvent, matchEvent, noMatchEvent, matchDelayedEvent;
      public bool onTime;
      public GameObject note;

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
              yield return new WaitForSeconds(0.1f);
              matchDelayedEvent.Invoke();
          }
          else
          {
              noMatchEvent.Invoke();
              yield return new WaitForSeconds(0.5f);
              
          }
      }

      public void OnTriggerExit(Collider other)
      {
          onTime = false;
      }
      
      public void MoveNote()
      {
          note.transform.position = new Vector3(13, 3, -7);
      }
      
      public void Movebossnotei()
      {
          note.transform.position = new Vector3(-1, 21, -7);
      }
      public void Movebossnoteii()
      {
          note.transform.position = new Vector3(-1, 47, -7);
      }
      public void Movebossnoteiii()
      {
          note.transform.position = new Vector3(-1, 72, -7);
      }
 }
