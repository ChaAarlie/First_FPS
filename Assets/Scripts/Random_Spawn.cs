using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Random_Spawn : MonoBehaviour
{
    [SerializeField] private GameObject prefab; 
    private float timer = 5f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        timer -= Time.deltaTime;
        if (timer <= 0 ){
            GameObject instantiatedEnemy = Instantiate(prefab,
                                                        Random.insideUnitSphere * 25 + transform.position,  // area of spawn 
                                                        transform.rotation)
                as GameObject;
            timer +=3;  // spawn enemy every 5 seconds
        }
    }
}
