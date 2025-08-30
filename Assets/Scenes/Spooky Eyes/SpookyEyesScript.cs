using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpookyEyesScript : MonoBehaviour
{
    private GameObject[] characterAIs;
    private int characterAIsCounter;
    // Start is called before the first frame update
    void Start()
    {
        characterAIs = GameObject.FindGameObjectsWithTag("AI");
        StartCoroutine("TheSnap");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator TheSnap(){
        yield return new WaitForSeconds(5f);
        while (characterAIsCounter < characterAIs.Length){
            if(Random.value > 0.5f){
                Destroy(characterAIs[characterAIsCounter]);
            }
            characterAIsCounter++;
        }
    }
}
