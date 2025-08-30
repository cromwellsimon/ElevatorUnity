using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwapToElevator : MonoBehaviour
{
    public GameObject whatToSwap;
    public float whenToSwap = 5f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("SwapToElevator");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator SwapToScene(){
        yield return new WaitForSeconds(whenToSwap);
        SceneManager.MoveGameObjectToScene(whatToSwap, SceneManager.GetSceneByName("Elevator"));
    }
}
