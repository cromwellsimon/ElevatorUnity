using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureScroll : MonoBehaviour
{
    public float repeatRate = 0.5f;
    public float xScrollMultiplier = -0.25f;
    public float yScrollMultiplier = 0f;
    private float xOffset = 0f;
    private float yOffset = 0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("ScrollTexture", 0f, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void ScrollTexture(){
        xOffset += xScrollMultiplier;
        yOffset += yScrollMultiplier;
        for(int i = 0; i < GetComponent<Renderer>().materials.Length; i++){
        //GetComponent<Renderer>().materials[i].mainTextureOffset = new Vector2 (xOffset, yOffset);
        GetComponent<Renderer>().materials[i].SetTextureOffset("_UnlitColorMap", new Vector2 (xOffset, yOffset));
        }
    }
}
