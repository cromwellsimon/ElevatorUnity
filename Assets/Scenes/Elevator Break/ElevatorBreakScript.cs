using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorBreakScript : MonoBehaviour
{
    public float[] soundDelays;
    public float secondsToWait = 20f;
    public AudioClip[] audioClips;
    private GameObject elevator;
    private ElevatorScript elevatorScript;
    private Animator elevatorBreakController;
    private AudioSource audioSource;
    private AudioSource audioSourceSFX;
    // Start is called before the first frame update
    void Start()
    {
        elevator = GameObject.Find("Elevator");
        elevatorBreakController = elevator.GetComponent<Animator>();
        //elevatorScript = elevator.GetComponent<ElevatorScript>();
        audioSource = GetComponents<AudioSource>()[0];
        audioSourceSFX = GetComponents<AudioSource>()[1];
        //audioSource.volume = elevatorScript.getMusicVolume();
        StartCoroutine(LevelTimer());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator LevelTimer(){
        yield return new WaitForSeconds(soundDelays[0]);
        audioSource.Play();
        elevatorBreakController.SetTrigger("ElevatorBreakAnimation");
        yield return new WaitForSeconds(soundDelays[1]);
        audioSourceSFX.Play();
        yield return new WaitForSeconds(soundDelays[2]);
        audioSourceSFX.Play();
        yield return new WaitForSeconds(soundDelays[3]);
        audioSource.clip = audioClips[1];
        audioSource.loop = false;
        audioSource.Play();
    }
}
