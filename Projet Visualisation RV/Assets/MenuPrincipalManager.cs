using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPrincipalManager : MonoBehaviour
{
    public void QuitOnClick()
    {
        print("1");
        Application.Quit();
    }

    public List<OrganeController> organsList = new List<OrganeController>();

    public void ResetAll()
    {
        foreach(OrganeController organ in organsList)
        {
            organ.ResetPos(0.3f);
        }
    }
}
