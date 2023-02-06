using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LifeBehaviour : MonoBehaviour
{
    public UnityEvent OnGround;
    public UnityEvent OutOfLife;
    public FloatData lifeCount;
    public UnityEvent OnAwake;
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            OnGround.Invoke();
        }
    }

    public void Update()
    {
        if (lifeCount.value == 0)
        {
            OutOfLife.Invoke();
        }
    }

    public void Awake()
    {
        OnAwake.Invoke();
    }
}
