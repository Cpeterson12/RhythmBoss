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
    private int num;
    private int randObj;
    public Vector3Data obj;

    

    public void BeginPool()
    {
        
       // num = Random.Range(0, obj.vector3DList.Count - 1);
        randObj = Random.Range(0, poolList.Count - 1);
        poolList[randObj].position = obj.value;
        poolList[randObj].gameObject.SetActive(true);

     
    }
   
   // IEnumerator BeginPoolii()
   // {
        
       // while (true)
      //  {
           // wfsObj = new WaitForSeconds(seconds.value);
           // num = Random.Range(0, obj.vector3DList.Count - 1);
           // poolList[randObj].position = obj.vector3DList[num].value;
           // i++;
           // if (i > poolList.Count - 1)
           // {
           //     i = 0;
           // }
           // yield return wfsObj;

    //   }
   // }
    
  

  //  public void ActivatePoolii()
   // {
    //    StartCoroutine(BeginPoolii());
   // }
}