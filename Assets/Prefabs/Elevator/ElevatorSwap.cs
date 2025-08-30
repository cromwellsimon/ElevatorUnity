using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ElevatorSwap : MonoBehaviour
{
    public GameObject whatToSwap;
    public float whenToSwap = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SwapToElevator(GameObject swappingObject, float swappingTime){
        StartCoroutine("SwapToScene");
        whatToSwap = swappingObject;
        whenToSwap = swappingTime;
    }
    IEnumerator SwapToScene(){
        yield return new WaitForSeconds(whenToSwap);
        SceneManager.MoveGameObjectToScene(whatToSwap, SceneManager.GetSceneByName("Elevator"));
    }
}
