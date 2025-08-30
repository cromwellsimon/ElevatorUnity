using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApartmentScript : MonoBehaviour
{
    private GameObject elevator;
    private GameObject[] AIs;
    private NavMeshAgentMovement[] navMeshAgentMovements;
    private int AICounter = 0;
    private ElevatorScript elevatorScript;
    // Start is called before the first frame update
    void Start()
    {
        elevator = GameObject.Find("Elevator");
        elevatorScript = elevator.GetComponent<ElevatorScript>();
        elevatorScript.setDoorCollider(false);
        GetAIs();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GetAIs(){
        AIs = GameObject.FindGameObjectsWithTag("AI");
        if(AIs != null){
            while(AICounter < AIs.Length){
                //navMeshAgentMovements[AICounter] = AIs[AICounter].gameObject.transform.GetChild(0).GetComponent<NavMeshAgentMovement>();
                //navMeshAgentMovements[AICounter].ToApartment();
                AIs[AICounter].gameObject.transform.GetChild(0).GetComponent<NavMeshAgentMovement>().ToApartment();
            }
        }
    }
}
