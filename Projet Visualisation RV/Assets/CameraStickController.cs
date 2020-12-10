using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraStickController : MonoBehaviour
{

    [SerializeField] private GameObject light;
    private bool bLight;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GetComponent<OVRGrabbable>().isGrabbed && OVRInput.GetDown(OVRInput.Button.One))
        {
            if(bLight)
            {
                bLight = false;
                light.GetComponent<Light>().enabled = false;
            }
            else
            {
                bLight = true;
                light.GetComponent<Light>().enabled = true;
            }
        }
    }
}
