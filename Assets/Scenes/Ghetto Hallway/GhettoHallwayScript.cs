using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhettoHallwayScript : MonoBehaviour
{
    public GameObject ghettoHallwayAI;
    private GameObject elevator;
    private ElevatorSwap elevatorSwap;

    // Start is called before the first frame update
    void Start()
    {
        elevator = GameObject.Find("Elevator");
        elevatorSwap = elevator.GetComponent<ElevatorSwap>();
        elevatorSwap.SwapToElevator(ghettoHallwayAI, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
