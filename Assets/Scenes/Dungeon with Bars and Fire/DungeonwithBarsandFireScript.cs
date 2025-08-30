using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungeonwithBarsandFireScript : MonoBehaviour
{
    public GameObject dungeonWithBarsAndFireAI;
    private GameObject elevator;
    private ElevatorSwap elevatorSwap;

    // Start is called before the first frame update
    void Start()
    {
        elevator = GameObject.Find("Elevator");
        elevatorSwap = elevator.GetComponent<ElevatorSwap>();
        elevatorSwap.SwapToElevator(dungeonWithBarsAndFireAI, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
