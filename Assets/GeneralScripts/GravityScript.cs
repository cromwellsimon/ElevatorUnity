using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityScript : MonoBehaviour
{
    private Vector3 gravity;
    public Vector3 gravityDirection = new Vector3(0f, -9.8f, 0f);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gravity = gravityDirection;
        Physics.gravity = gravityDirection;        
    }
}
