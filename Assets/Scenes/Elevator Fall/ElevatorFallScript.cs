using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ElevatorFallScript : MonoBehaviour
{
    public float timeToFall = 25f;
    public float timeToLand = 3f;
    public Vector3 heightToLand = new Vector3(0f, 45f, 0f);
    private int playerCounter = 0;
    private int AICounter = 0;
    public GameObject roomMesh;
    private GameObject elevator;
    private GameObject elevatorMesh;
    private GameObject elevatorFloor;
    private GameObject elevatorCeiling;
    private GameObject[] players;
    private GameObject[] AIs;
    private NavMeshAgent[] navMeshAgents;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ElevatorFall());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator ElevatorFall(){
        yield return new WaitForSeconds(timeToFall);
        Fall();
        GameObject[] players = GameObject.FindGameObjectsWithTag("Player");
        GameObject[] AIs = GameObject.FindGameObjectsWithTag("AI");
        while(AICounter < AIs.Length){
            print(AIs[AICounter]);
            AIs[AICounter].gameObject.transform.GetChild(0).GetComponent<NavMeshAgent>().enabled = false;
            //navMeshAgents[AICounter].enabled = false;
            //print(navMeshAgents[AICounter].enabled);
            AICounter++;
        }
        AICounter = 0;
        yield return new WaitForSeconds(timeToLand);
        while(AICounter < AIs.Length){
            print(AIs[AICounter].transform.position);
            AIs[AICounter].transform.position += (heightToLand);
            print(AIs[AICounter].transform.position);
            AIs[AICounter].gameObject.transform.GetChild(0).GetComponent<NavMeshAgent>().enabled = true;
            AICounter++;
        }
        Land();
        playerCounter = 0;
        while(playerCounter < players.Length){
            players[playerCounter].transform.position = (heightToLand);
            print(players[playerCounter]);
            playerCounter++;
        }
        yield return new WaitForSeconds(2.5f);
        elevatorCeiling.GetComponent<BoxCollider>().enabled = true;
    }

    void Fall(){
        elevator = GameObject.Find("Elevator");
        elevatorMesh = elevator.transform.Find("Elevator Mesh").gameObject;
        elevatorFloor = elevatorMesh.transform.Find("Floor").gameObject;
        elevatorCeiling = elevatorMesh.transform.Find("Ceiling").gameObject;
        print(elevatorFloor);
        print(elevatorCeiling);
        elevatorFloor.SetActive(false);
        elevatorCeiling.GetComponent<BoxCollider>().enabled = false;
    }

    void Land(){
        roomMesh.SetActive(false);
        elevatorFloor.SetActive(true);
    }
}
