using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorDoorAnimation : MonoBehaviour
{
    public GameObject[] elevatorDoors;
    private Animator[] elevatorAnimatorController = new Animator[2];
    private int elevatorLength = 0;
    [HideInInspector]
    public bool elevatorOpen = false;
    public bool elevatorColliderOn = false;
    public MeshCollider doorFrameCollider;
    
    void Awake(){
    }

    // Start is called before the first frame update
    void Start()
    {
        while(elevatorLength < elevatorDoors.Length){
            elevatorAnimatorController[elevatorLength] = elevatorDoors[elevatorLength].GetComponent<Animator>();
            elevatorLength += 1;
        }
        elevatorLength = 0;
        while(elevatorLength < elevatorDoors.Length){
            print(elevatorAnimatorController[elevatorLength]);
            elevatorLength += 1;
        }
        elevatorLength = 0;
        doorFrameCollider.enabled = elevatorColliderOn;
        ElevatorOpen();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ElevatorOpen(){
        print("Door open");
        elevatorOpen = true;
        while (elevatorLength < elevatorDoors.Length){
            elevatorAnimatorController[elevatorLength].SetBool("doorBranch", elevatorOpen);
            elevatorAnimatorController[elevatorLength].SetBool("doorOpen", elevatorOpen);
            elevatorLength += 1;
        }
        elevatorLength = 0;
    }

    public void ElevatorClose(){
        print("Door close");
        elevatorOpen = false;
        while(elevatorLength < elevatorDoors.Length){
            elevatorAnimatorController[elevatorLength].SetBool("doorOpen", elevatorOpen);
            elevatorLength += 1;
        }
        elevatorLength = 0;
    }
}
