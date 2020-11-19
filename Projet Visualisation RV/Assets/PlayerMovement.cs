using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{

    [SerializeField]
    private Camera camPlayer;
    [SerializeField]
    private GameObject player;
    [SerializeField]
    private float cameraRotationLimit;

    private Rigidbody rbPlayer;

    private Vector3 velocity;
    private Vector3 playerRotation;

    private float cameraRotationX = 0f;
    private float currentCameraRotationX = 0f;
    private void Start()
    {
        //Recuperation des scripts
        rbPlayer = GetComponent<Rigidbody>();
    }

    //Procedure de "mise a jour de la velocite"
    public void Move(Vector3 _velocity)
    {
        velocity = _velocity;
    }

    //Procedure de "mise a jour de la rotaion du joueur"
    public void RotationPlayer(Vector3 _playerRotation)
    {
        playerRotation = _playerRotation;
    }

    //Procedure de "mise a jour de la rotation de camera"
    public void RotationCamera(float _cameraRotationX)
    {
        cameraRotationX = _cameraRotationX;
    }

    //Procedure de update.
    private void FixedUpdate()
    {
        PerformMovement();
        PerformRotation();
    }

    //Procedure qui effectue le deplacement du joueur
    private void PerformMovement()
    {
        if (velocity != Vector3.zero)
        {
            rbPlayer.MovePosition(rbPlayer.position + velocity * Time.fixedDeltaTime);
        }
    }

    //Procedure qui effectue la rotation du joueur et de la camera
    private void PerformRotation()
    {
        //RotationCamera objet player
        rbPlayer.MoveRotation(rbPlayer.rotation * Quaternion.Euler(playerRotation));

        //Clamp la rotation (Angle max de camera)
        currentCameraRotationX = currentCameraRotationX - cameraRotationX;
        currentCameraRotationX = Mathf.Clamp(currentCameraRotationX, -cameraRotationLimit, cameraRotationLimit);

        //Applique les changements à la camera apres clamp.
        camPlayer.transform.localEulerAngles = new Vector3(currentCameraRotationX, 0f, 0f);
    }
}