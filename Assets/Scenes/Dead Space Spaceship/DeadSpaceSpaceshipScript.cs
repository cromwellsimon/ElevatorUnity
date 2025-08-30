using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadSpaceSpaceshipScript : MonoBehaviour
{
    public float spaceAlarmDelay = 5f;
    public float spaceAlarmEndDelay = 32f;
    public float spaceAlarmLightEndDelay = 2f;
    //public float lowpassFrequency = 400f;
    //public float lowpassResonance = 2f;
    private GameObject elevator;
    private ElevatorAudio elevatorAudio;
    private AudioSource audioSource;
    private GameObject warningSign;
    private GameObject lightbulbPivot;
    // Start is called before the first frame update
    void Start()
    {
        lightbulbPivot = GameObject.Find("Lightbulb Pivot");
        lightbulbPivot.SetActive(false); 
        warningSign = GameObject.Find("warning");
        warningSign.SetActive(false);
        //elevator = GameObject.Find("Elevator");
        //elevatorAudio = elevator.GetComponent<ElevatorAudio>();
        audioSource = GetComponent<AudioSource>();
        //audioSource.volume = elevatorScript.getSoundEffectVolume();*/
        StartCoroutine(SpaceAlarm());
    }

    // Update is called once per frame
    void Update()
    {
        //elevatorAudio.SpaceDistortion(lowpassFrequency, lowpassResonance);
    }

    IEnumerator SpaceAlarm(){
        yield return new WaitForSeconds(spaceAlarmDelay);
        lightbulbPivot.SetActive(true);
        warningSign.SetActive(true);
        audioSource.Play();
        yield return new WaitForSeconds(spaceAlarmEndDelay);
        warningSign.SetActive(false);
        audioSource.loop = false;
        yield return new WaitForSeconds(spaceAlarmLightEndDelay);
        lightbulbPivot.SetActive(false);
    }
}
