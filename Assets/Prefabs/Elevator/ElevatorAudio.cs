using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class ElevatorAudio : MonoBehaviour
{
    [Range(0.001f,1f)]
    public float masterVolume = 0.5f;
    [Range(0.001f,1f)]
    public float soundEffectVolume = 0.5f;
    [Range(0.001f,1f)]
    public float musicVolume = 0.5f;
    public AudioSource elevatorSoundEffectAudioSource;
    public AudioSource elevatorMusicAudioSource;
    public AudioClip[] soundEffectAudioClips;
    public AudioClip[] musicAudioClips;
    public AudioMixer masterMixer;

    void Awake(){

    }

    // Start is called before the first frame update
    void Start()
    {
        /*soundEffectVolume = masterVolume * soundEffectVolume;
        musicVolume = masterVolume * musicVolume;
        elevatorSoundEffectAudioSource.volume = soundEffectVolume;
        elevatorMusicAudioSource.volume = musicVolume;*/
    }

    // Update is called once per frame
    void Update()
    {
        SetSound();
    }

    public void ElevatorStart(){
        elevatorSoundEffectAudioSource.clip = soundEffectAudioClips[2];
       //elevatorSoundEffectAudioSource.volume = soundEffectVolume;
        elevatorSoundEffectAudioSource.Play();
        elevatorMusicAudioSource.clip = musicAudioClips[Random.Range(0, 20)];
       //elevatorMusicAudioSource.volume = musicVolume;
        elevatorMusicAudioSource.Play();
    }

    public void ElevatorStop(){
        elevatorSoundEffectAudioSource.clip = soundEffectAudioClips[0];
        //elevatorSoundEffectAudioSource.volume = soundEffectVolume;
        elevatorSoundEffectAudioSource.Play();
        elevatorMusicAudioSource.clip = soundEffectAudioClips[3];
        //elevatorMusicAudioSource.volume = soundEffectVolume;
        elevatorMusicAudioSource.Play();
    }

    public void SetSound(){
        masterMixer.SetFloat("MasterVolume", Mathf.Log(masterVolume) * 20);
        masterMixer.SetFloat("SFXVolume", Mathf.Log(soundEffectVolume) * 20);
        masterMixer.SetFloat("MusicVolume", Mathf.Log(musicVolume) * 20);
    }

    public void SpaceDistortion(float frequency, float resonance){
        masterMixer.SetFloat("lowpassFrequency", frequency);
        masterMixer.SetFloat("lowpassResonance", resonance);
    }
}
