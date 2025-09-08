using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehavior : MonoBehaviour
{
    [SerializeField]
    private Vector3 StartForce = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().AddForce(StartForce);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
