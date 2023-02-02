
using System;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider))]
public class TriggerEventBehaviour : MonoBehaviour
{
    public UnityEvent triggerEvent;
    private Collider colliderObj;
  
    public void Start()
    {
        colliderObj = GetComponent<Collider>();
        colliderObj.isTrigger = true;
    }

    public void OnTriggerEnter(Collider other)
    {
        triggerEvent.Invoke();
    }
}
