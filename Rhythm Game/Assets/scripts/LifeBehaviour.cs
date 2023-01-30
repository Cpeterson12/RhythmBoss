using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LifeBehaviour : MonoBehaviour
{
    public UnityEvent OnGround;
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            OnGround.Invoke();
        }
    }

    
}
