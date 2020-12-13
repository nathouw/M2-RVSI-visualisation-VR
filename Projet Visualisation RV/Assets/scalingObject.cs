using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scalingObject : MonoBehaviour
{
    private GameObject Organe1;
    private Slider ScaleSlider;
    public float size;
    //[SerializeField] 
    public float currentScale = 20.0f;
    // Start is called before the first frame update
    void Start()
    {
        //ScaleSlider = GameObject.Find("ScaleSlider").GetComponent<Slider>();
       Organe1 = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        //size = GetComponent<MeshRenderer>().bounds;
        Organe1.transform.localScale = new Vector3(currentScale, currentScale, currentScale);


    }
    /*public void onGUI()
    {
        Organe1.transform.localScale = new Vector3(currentScale, currentScale, currentScale);
    }*/
    public void resize( float newSize)

    {
        currentScale = newSize;
       
        //Organe1.transform.localScale = new Vector3(ScaleSlider.value, ScaleSlider.value, ScaleSlider.value);
    }
}
