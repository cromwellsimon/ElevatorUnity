using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LobbyScript : MonoBehaviour
{
/*Not sure if it's best for me to put this on the Lobby prefab, or if it'd be better to combine this with the
LobbyTriggerBoxScript given that it's basically a level script of its own. Idk, whatevs :) */
    public GameObject character;
    public GameObject triggerBox;
    public GameObject elevator;
    private ElevatorScript elevatorScript;

    void Awake(){
        //Load the Elevator level when the game starts
        SceneManager.LoadSceneAsync("Elevator", LoadSceneMode.Additive);
    }
    // Start is called before the first frame update
    void Start()
    {
        elevator = GameObject.Find("Elevator");
        print(elevator);
        elevatorScript = elevator.GetComponent<ElevatorScript>();
        print(elevatorScript);
        elevatorScript.ElevatorOpen();
        elevatorScript.setDoorCollider(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CloseDoor(){
        elevatorScript.setDoorCollider(true);
        StartCoroutine(SwapToElevator());
    }

    IEnumerator SwapToElevator(){
        yield return new WaitForSeconds(1);
        SceneManager.MoveGameObjectToScene(character, SceneManager.GetSceneByName("Elevator"));
        elevatorScript.StartSwap("Lobby");
    }
}
