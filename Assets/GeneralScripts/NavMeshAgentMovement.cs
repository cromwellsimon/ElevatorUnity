using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshAgentMovement : MonoBehaviour
{
    private bool isWalking = false;
    private bool toElevator = true;
    private float agentSpeed;
    public Vector3 destination;
    public Vector3 elevatorDestination;
    public Vector3 apartmentDestination;
    private GameObject elevatorDoor;
    private Vector3 lookAtTarget;
    private Animator animator;
    private NavMeshAgent agent;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        elevatorDoor = GameObject.Find("Elevator Door Frame");
        agentSpeed = agent.speed;
    }

    // Update is called once per frame
    void Update()
    {
        if (destination != transform.position){
            agent.SetDestination(destination);
            //isWalking = true;
            //animator.speed = ((agent.velocity.x + agent.velocity.z)/agent.speed);
            if(agent.isOnOffMeshLink){
                agent.speed = agentSpeed / 2;
            }
            else{
                agent.speed = agentSpeed;
            }
        }
        /*else{
            isWalking = false;
        }*/
        if(Mathf.Abs(agent.velocity.x + agent.velocity.z) > 0.2f){
            Walk();
            if (toElevator == true){
                if(agent.remainingDistance < 0.1f){
                    lookAtTarget = new Vector3(elevatorDoor.transform.position.x , transform.position.y, elevatorDoor.transform.position.z);
                    transform.LookAt(lookAtTarget);
                }
            }
        }
        else{
            Idle();
        }
        animator.SetBool("isWalking", isWalking);
    }

    void Walk(){
            isWalking = true;
            animator.speed = (Mathf.Abs(agent.velocity.x + agent.velocity.z)/agent.speed);
            if(agent.isOnOffMeshLink){
            animator.speed = 1f;
            }
            else {
            animator.speed = (Mathf.Abs(agent.velocity.x + agent.velocity.z)/agent.speed);
            }
    }

    void Idle(){
            isWalking = false;
            animator.speed = 1;
    }

    public void ToElevator(){
        destination = elevatorDestination;
    }
    public void ToApartment(){
        destination = apartmentDestination;
    }
}
