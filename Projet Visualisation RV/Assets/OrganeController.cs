using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrganeController : MonoBehaviour
{

    private GameObject organe;
    public Transform reset;

    private bool rotate = true;

    // Start is called before the first frame update
    void Start()
    {
        organe = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {

        if(rotate)
        {
            this.transform.Rotate(new Vector3(0, 0, 1));
        }
        if(this.GetComponent<OVRGrabbable>().isGrabbed && rotate)
        {
            rotate = false;
        }
    }

    public void ResetPos(float scaleValue)
    {
        organe.transform.position = reset.transform.position;
        organe.transform.rotation = reset.transform.rotation;
        organe.transform.localScale = new Vector3(scaleValue, scaleValue, scaleValue);
        rotate = true;
    }

    public void ScaleChange(float scaleValue)
    {
        organe.transform.localScale = new Vector3(scaleValue, scaleValue, scaleValue);

    }

}
