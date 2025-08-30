using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ElevatorScript : MonoBehaviour
{
    public float minimumTimeWait = 60f;
    public float maximumTimeWait = 120f;
    public int minimumFloor = 2;
    public int maximumFloor = 28;
    public int floorsToGo = 27;
    private bool[] floorVisited = new bool[28];
    private int levelCounter = 0;
    private MeshCollider elevatorDoorFrameCollider;
    private ElevatorAudio elevatorAudio;
    private ElevatorDoorAnimation elevatorDoorAnimation;
    // Start is called before the first frame update
    void Start()
    {
        elevatorDoorFrameCollider = GameObject.Find("Elevator Door Frame").GetComponent<MeshCollider>();
        elevatorAudio = GetComponent<ElevatorAudio>();
        elevatorDoorAnimation = GetComponent<ElevatorDoorAnimation>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartSwap(string sceneName){
        elevatorDoorAnimation.ElevatorClose();
        StartCoroutine(MiddleSwap(sceneName));
    }

    IEnumerator MiddleSwap(string sceneName){
        yield return new WaitForSeconds(3f);
        elevatorAudio.ElevatorStart();
        SceneManager.UnloadSceneAsync(sceneName);
        StartCoroutine(LevelSwap());
    }

    IEnumerator LevelSwap(){
        levelCounter = levelCounter + 1;
        yield return new WaitForSeconds(Random.Range(minimumTimeWait,maximumTimeWait));
        if(levelCounter < floorsToGo){
        SceneManager.LoadSceneAsync(getNextFloorNumber(), LoadSceneMode.Additive);
        } else {
            SceneManager.LoadSceneAsync(28, LoadSceneMode.Additive);
        }
        elevatorAudio.ElevatorStop();
        elevatorDoorAnimation.ElevatorOpen();
    }

    int getNextFloorNumber(){
        /* This function checks to see if the next floor has already been gone to. It'd be very awkward to go to the same floor
        27 or however many times in a row ;) */
        int floorToGoTo;
        floorToGoTo = Random.Range(minimumFloor,maximumFloor);
        while (floorVisited[floorToGoTo] == true){
            floorToGoTo = Random.Range(minimumFloor,maximumFloor);
        }
        floorVisited[floorToGoTo] = true;
        return floorToGoTo;
    }
    public float getSoundEffectVolume(){
    return elevatorAudio.soundEffectVolume;
}

    public float getMusicVolume(){
        return elevatorAudio.musicVolume;
    }

    public void setDoorCollider(bool enabled){
        elevatorDoorFrameCollider.enabled = enabled;
    }

    public void ElevatorClose(){
        elevatorDoorAnimation.ElevatorClose();
    }

    public void ElevatorOpen(){
        elevatorDoorAnimation.ElevatorOpen();
    }
}
