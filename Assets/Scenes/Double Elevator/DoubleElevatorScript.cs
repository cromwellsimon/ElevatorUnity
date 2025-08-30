using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoubleElevatorScript : MonoBehaviour
{
    public GameObject doubleElevatorAI;
    private GameObject elevator;
    private ElevatorSwap elevatorSwap;

    // Start is called before the first frame update
    void Start()
    {
        elevator = GameObject.Find("Elevator");
        elevatorSwap = elevator.GetComponent<ElevatorSwap>();
        elevatorSwap.SwapToElevator(doubleElevatorAI, 5f);
        //StartCoroutine("SwapToElevator");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /*IEnumerator SwapToElevator(){
        yield return new WaitForSeconds(5);
        SceneManager.MoveGameObjectToScene(getSmartAI, SceneManager.GetSceneByName("Elevator"));
    }*/
}
