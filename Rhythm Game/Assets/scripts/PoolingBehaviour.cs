using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class PoolingBehaviour : MonoBehaviour
{
    public List<GameObject> poolList;
    
    private WaitForSeconds wfsObj;
    public FloatData seconds;
    private int i;
    public int num;
    private int randObj;
    public Vector3Data obj;



    public GameObject ReturnPool()
    {
        
       
       // randObj = Random.Range(0, poolList.Count - 1);
        //poolList[randObj].position = obj.value;
       

        for (int i = 0; i < poolList.Count; i ++)
        {
            if (!poolList[i].activeInHierarchy)
            {
                return poolList[i];
            }
            poolList[num].gameObject.SetActive(true);
        }

        return null;


    }

  
}