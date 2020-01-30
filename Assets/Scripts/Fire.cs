using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public List<GameObject> bullets;
    [SerializeField] private GameObject prefab; 
    Rigidbody rb ;
 
    public float speed = 150;

    // Start is called before the first frame update
    void Start()
    {
        bullets = new List<GameObject>();
        rb = prefab.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetButtonDown("Fire1"))
        {
            Rigidbody instantiatedProjectile = Instantiate(rb,
                                                           transform.position,
                                                           transform.rotation)
                as Rigidbody;
            bullets.Add(instantiatedProjectile);
            instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0, 0,speed));
        }
        */
         if (Input.GetButtonDown("Fire1"))  // instentiate a new GameObject each time M1 is pressed 
        {
            GameObject instantiatedProjectile = Instantiate(prefab,
                                                           transform.position,
                                                           transform.rotation) //angle doesn't follow gun 
                as GameObject;
            bullets.Add(instantiatedProjectile);
            instantiatedProjectile.GetComponent<Rigidbody>().velocity = transform.TransformDirection(new Vector3(0, 0,speed));
        }

        if (Input.GetButtonDown("Fire2"))   // M2 to destroy all GameObjects "bullets" created 
        {
            foreach(var nextBullet in bullets){
                Destroy(nextBullet);
            }
            bullets.Clear();
        }
    }
}
