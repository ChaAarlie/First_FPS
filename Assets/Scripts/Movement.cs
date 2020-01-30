using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// PROBLEM: if the body's player is not kinematic, the player flies in the air infinitly
public class Movement : MonoBehaviour
{
    [SerializeField] private float speed = 10f;

    void awake()
    {
        //playerTransform = transform;
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 currentPosition = playerTransform.position;
        Vector3 deltaPosition = new Vector3(
             Input.GetAxis("Horizontal") * speed * Time.deltaTime,
             0f,
             Input.GetAxis("Vertical")* speed * Time.deltaTime
        ) ;
        deltaPosition.y = 0f;
        transform.Translate(deltaPosition);
    }
}
