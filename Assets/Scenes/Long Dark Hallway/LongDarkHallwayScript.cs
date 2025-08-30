using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LongDarkHallwayScript : MonoBehaviour
{
    public float[] audioClipsDelays;
    private int audioClipsCounter = 0;
    public AudioClip[] audioClips;
    private GameObject elevator;
    private ElevatorScript elevatorScript;
    private AudioSource audioSource;

    void Awake(){
        audioSource = GetComponent<AudioSource>();

    }
    // Start is called before the first frame update
    void Start()
    {
        /*elevatorScript = elevator.GetComponent<ElevatorScript>();
        audioSource.volume = elevatorScript.getSoundEffectVolume();*/
        StartCoroutine(AudioClips());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetElevatorClip(){
        //This finds Elevator and sets it to play the little song that plays during this portion.
        elevator = GameObject.Find("Elevator");
        if (elevator != null){
        elevator.GetComponent<AudioSource>().clip = audioClips[4];
        elevator.GetComponent<AudioSource>().Play();
        }
    }

    IEnumerator AudioClips(){
        while (audioClipsCounter < audioClipsDelays.Length) {
        yield return new WaitForSeconds(audioClipsDelays[audioClipsCounter]);
        audioSource.clip = audioClips[audioClipsCounter];
        audioSource.Play();
        audioClipsCounter = audioClipsCounter + 1;
        }
    }
}
