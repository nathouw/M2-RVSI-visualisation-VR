using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuOrganeManager : MonoBehaviour
{
    public GameObject organe;
    public Transform reset;
    public Slider scaleSlider;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetPos()
    {
        
    }
    
    public void ScaleChange()
    {
        organe.transform.localScale = new Vector3(scaleSlider.value, scaleSlider.value, scaleSlider.value);
    }
}
