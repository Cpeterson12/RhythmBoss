using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class PoolingBehaviour : MonoBehaviour
{
    public List<Transform> poolList;
    
    private WaitForSeconds wfsObj;
    public FloatData seconds;
    private int i;
    public int num;
    private int randObj;
    public Vector3Data obj;



    public void BeginPool()
    {
        
       // num = Random.Range(0, obj.vector3DList.Count - 1);
        randObj = Random.Range(0, poolList.Count - 1);
        poolList[randObj].position = obj.value;
        //poolList[randObj].gameObject.SetActive(true);

        for (num = 0; num < poolList.Count; num++)
        {
         poolList[num].gameObject.SetActive(true);
         Debug.Log("please");
        }


    }

  
}