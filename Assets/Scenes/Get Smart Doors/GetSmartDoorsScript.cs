using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GetSmartDoorsScript : MonoBehaviour
{
    public GameObject getSmartAI;
    private GameObject elevator;
    private ElevatorSwap elevatorSwap;
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine("SwapToElevator");  
        elevator = GameObject.Find("Elevator");
        elevatorSwap = elevator.GetComponent<ElevatorSwap>();
        /*audioSource = GetComponent<AudioSource>();
        audioSource.volume = elevatorScript.getMusicVolume();*/
        elevatorSwap.SwapToElevator(getSmartAI, 5f);
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
