using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class test : MonoBehaviour
{
    Light2D testo;
    // Start is called before the first frame update
    void Start()
    {
        
        testo = GetComponentInChildren<Light2D>();
        Debug.Log(testo.pointLightOuterRadius);
        Debug.Log(testo.transform.position );
        Debug.Log(testo.transform.position * testo.pointLightOuterRadius);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
