using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFlicker : MonoBehaviour
{
    public float flickerIntensityMinimum;
    public float flickerIntensityMaximum;
    private Light thisLight;
    // Start is called before the first frame update
    void Start()
    {
        thisLight = gameObject.GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        thisLight.intensity = Random.Range(flickerIntensityMinimum, flickerIntensityMaximum);
    }
}
