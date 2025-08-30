using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapLevelInSeconds : MonoBehaviour
{
    public int secondsToWait;
    public string levelName;
    private GameObject elevator;
    private ElevatorScript elevatorScript;
    // Start is called before the first frame update
    void Start()
    {
        elevator = GameObject.Find("Elevator");
        if (elevator != null){
        elevatorScript = elevator.GetComponent<ElevatorScript>();
        StartCoroutine(SwapLevel());
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SwapLevel(){
        yield return new WaitForSeconds(secondsToWait);
        elevatorScript.StartSwap(levelName);
    }
}