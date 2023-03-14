using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AltPoolBehaviour : MonoBehaviour
{
    public static AltPoolBehaviour SharedInstance;
    public List<GameObject> pooledObjects;
    public GameObject objectToPool;
    public int amountToPool;
    public Vector3 spawn;
    GameObject tmp;
    public GameObject test;
    void Awake()
    {
        SharedInstance = this;
    }

    void Start()
    {
        pooledObjects = new List<GameObject>();
        
        for (int i = 0; i < amountToPool; i++)
        {
            tmp = Instantiate(objectToPool);
            tmp.SetActive(true);
            pooledObjects.Add(tmp);
        }
    }

    public GameObject GetPooledObject(GameObject prefab)
    {
        for (int i = 0; i < pooledObjects.Count; i++)
        {
            if (!pooledObjects[i].activeInHierarchy)
            {
                
                tmp.SetActive(true);
                //pooledObjects.Add(tmp);
                return pooledObjects[i];
            }
        }
        
       
        tmp.SetActive(true);
        pooledObjects.Add(tmp);
        return tmp;

    }

    public void ActivatePooling()
    {
        ActivateObj();
    }

    public void ActivateObj()
    {
        for (int i = 0; i < pooledObjects.Count; i++) 
        {
            pooledObjects[i].transform.position = spawn;
            if (pooledObjects.Count <= i)
            {
                i = 0;
            }
        }
        //if (pooledObjects.Count <= 0) return;
       // pooledObjects[i].transform.position = spawn;
       // pooledObjects[0].SetActive(true);
       // pooledObjects.RemoveAt(0);
    }

    public void StartOther()
    {
        GetPooledObject(objectToPool);
    }

    
}
