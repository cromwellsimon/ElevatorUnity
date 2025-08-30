using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class LowpassScript : MonoBehaviour
{
    public float lowpassFrequency = 400f;
    public float lowpassResonance = 2f;
    public AudioMixer masterMixer;
    //private GameObject elevator;
    //private ElevatorAudio elevatorAudio;
    // Start is called before the first frame update
    void Start()
    {
        //elevator = GameObject.Find("Elevator");
        //elevatorAudio = elevator.GetComponent<ElevatorAudio>();        
    }

    // Update is called once per frame
    void Update()
    {
        //print(elevatorAudio);
        masterMixer.SetFloat("lowpassFrequency", lowpassFrequency);
        masterMixer.SetFloat("lowpassResonance", lowpassResonance);
    }
}
