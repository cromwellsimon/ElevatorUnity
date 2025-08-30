using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhettoTunnelScript : MonoBehaviour
{
    public GameObject ghettoTunnelAI;
    private GameObject elevator;
    private ElevatorSwap elevatorSwap;

    // Start is called before the first frame update
    void Start()
    {
        elevator = GameObject.Find("Elevator");
        elevatorSwap = elevator.GetComponent<ElevatorSwap>();
        elevatorSwap.SwapToElevator(ghettoTunnelAI, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
