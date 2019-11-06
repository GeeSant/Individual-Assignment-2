using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// TODO: Bonus - make this class a Singleton!

[System.Serializable]
public class BulletPoolManager : MonoBehaviour
{
    public GameObject bullet;
    public List<GameObject> poolObjects; //ADDED
    public int amountPool = 50; //ADDED
  
    
    

    //Store 50 bullets
    //TODO: create a structure to contain a collection of bullets

    // Start is called before the first frame update
    void Start()
    {
        // TODO: add a series of bullets to the Bullet Pool
        poolObjects = new List<GameObject>(); //ADDED
        for (int i = 0; i<amountPool; i++) //ADDED
        {
            GameObject _bullet = Instantiate(bullet, Vector3.zero, Quaternion.identity);
            _bullet.SetActive(false);
            poolObjects.Add(_bullet);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //TODO: modify this function to return a bullet from the Pool
    public GameObject GetBullet()
    {
        GameObject _bullet = poolObjects[poolObjects.Count - 1];
        poolObjects.RemoveAt(poolObjects.Count - 1);
        
        _bullet.SetActive(true); //ADDED
        return _bullet; //ADDED
    }

    //TODO: modify this function to reset/return a bullet back to the Pool 
    public void ResetBullet(GameObject bullet)
    {
        poolObjects.Insert(poolObjects.Count, bullet);

        bullet.SetActive(false); //ADDED
    }
}
