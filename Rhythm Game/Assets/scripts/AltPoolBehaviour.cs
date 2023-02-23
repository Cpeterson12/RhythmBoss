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
            tmp.SetActive(false);
            pooledObjects.Add(tmp);
        }
    }

    public GameObject GetPooledObject()
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
        if (pooledObjects.Count <= 0) return;
        pooledObjects[0].transform.position = spawn;
        pooledObjects[0].SetActive(true);
        //pooledObjects.RemoveAt(0);
    }

    public void StartOther()
    {
        GetPooledObject();
    }

    
}
