using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;
public class GlobalLightSwitch : MonoBehaviour
{
    Light2D light2D;
    // Start is called before the first frame update
    void Start()
    {
        light2D = GetComponent<Light2D>();
        light2D.enabled = !light2D.enabled;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
            light2D.enabled = !light2D.enabled;
    }
}
