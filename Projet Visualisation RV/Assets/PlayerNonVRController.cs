using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerMovement))]
public class PlayerNonVRController : MonoBehaviour
{

    [SerializeField]
    private float playerSpeed;
    [SerializeField]
    private float mouseSensibility;

    //Variables de deplacement au sol
    private float xMovPlayer;
    private float zMovPlayer;

    private Vector3 movHorizontalPlayer;
    private Vector3 movVerticalPlayer;
    private Vector3 velocity;
    private PlayerMovement movement;


    //Variables de rotation camera + joueur.
    private float _yRotPlayer;
    private float _xRotCam;

    private Vector3 _playerRotation;
    private float _cameraRotation;

    private void Start()
    {
        movement = GetComponent<PlayerMovement>();
    }

    private void FixedUpdate()
    {
        //Calcul de la velocité de deplacement du joueur.
        xMovPlayer = Input.GetAxisRaw("Horizontal");
        zMovPlayer = Input.GetAxisRaw("Vertical");

        movHorizontalPlayer = transform.right * xMovPlayer;
        movVerticalPlayer = transform.forward * zMovPlayer;
        velocity = (movHorizontalPlayer + movVerticalPlayer).normalized * playerSpeed;

        movement.Move(velocity);
     


        //Calcul de la rotation du joueur.
        _yRotPlayer = Input.GetAxisRaw("Mouse X");
        _playerRotation.Set(0, _yRotPlayer * mouseSensibility, 0);

        movement.RotationPlayer(_playerRotation);

        //Calcul de la rotation de la camera.
        _xRotCam = Input.GetAxisRaw("Mouse Y");
        _cameraRotation = _xRotCam * mouseSensibility;

        movement.RotationCamera(_cameraRotation);

        if (Input.GetMouseButtonDown(0))
        {
            Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out RaycastHit hit);
            Debug.Log(hit.collider.name);// mettre if ici
        }
    }
}
