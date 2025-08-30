using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BeachScript : MonoBehaviour
{
    public GameObject beachAI;
    private GameObject elevator;
    private ElevatorSwap elevatorSwap;
    // Start is called before the first frame update
    void Start()
    {
        elevator = GameObject.Find("Elevator");
        elevatorSwap = elevator.GetComponent<ElevatorSwap>();
        elevatorSwap.SwapToElevator(beachAI, 5f);        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /*IEnumerator SwapToElevator(){
        yield return new WaitForSeconds(5);
        SceneManager.MoveGameObjectToScene(beachAI, SceneManager.GetSceneByName("Elevator"));
    }*/
}
