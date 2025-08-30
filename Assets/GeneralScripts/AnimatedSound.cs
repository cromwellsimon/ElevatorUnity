using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatedSound : MonoBehaviour
{
    public AudioClip[] audioClips;
    public float[] audioClipsDelays;
    private int audioClipsCounter = 0;
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

    IEnumerator AudioClips(){
        while (audioClipsCounter < audioClipsDelays.Length) {
        yield return new WaitForSeconds(audioClipsDelays[audioClipsCounter]);
        audioSource.clip = audioClips[audioClipsCounter];
        audioSource.Play();
        audioClipsCounter = audioClipsCounter + 1;
        }
    }
}