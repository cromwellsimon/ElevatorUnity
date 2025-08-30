using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotScript : MonoBehaviour
{
    public float moveSpeed = 1f;
    public float teleportPosition = -3.5f;
    public bool reverseDirection = false;
    private Vector3 robotPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        robotPosition = gameObject.transform.position;
        RobotMove();
    }

    void RobotMove(){
        gameObject.transform.Translate(-(Time.deltaTime * moveSpeed), 0, 0);
        if (reverseDirection){
            if(robotPosition.x < -teleportPosition){
            gameObject.transform.position = new Vector3(teleportPosition, robotPosition.y, robotPosition.z);
            }
        } else if(robotPosition.x > -teleportPosition){
            gameObject.transform.position = new Vector3(teleportPosition, robotPosition.y, robotPosition.z);
        }
    }
}
