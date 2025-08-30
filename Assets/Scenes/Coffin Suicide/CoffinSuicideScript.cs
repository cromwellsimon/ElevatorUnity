using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffinSuicideScript : MonoBehaviour
{
    private GameObject elevator;
    private ElevatorScript elevatorScript;
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        /*elevator = GameObject.Find("Elevator");
        elevatorScript = elevator.GetComponent<ElevatorScript>();
        audioSource = GetComponent<AudioSource>();
        audioSource.volume = elevatorScript.getSoundEffectVolume();*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
