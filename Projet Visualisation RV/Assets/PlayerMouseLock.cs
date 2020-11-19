using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script qui bloque ou non la souris si on appuis sur e avec le changement d'état est aussi en public
public class PlayerMouseLock : MonoBehaviour
{
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

}