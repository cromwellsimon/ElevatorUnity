using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LobbyTriggerBoxScript : MonoBehaviour
{
    public GameObject lobby;
    private LobbyScript lobbyScript;
    void Awake(){
        lobbyScript = lobby.GetComponent<LobbyScript>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "Player"){
            lobbyScript.CloseDoor();
            Destroy(gameObject);
        }
    }
}
