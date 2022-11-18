using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControlls : MonoBehaviour
{
    [SerializeField] private PlayerTurn playerTurn;
    [SerializeField] private Rigidbody characterBody;
    [SerializeField] private Camera characterCamera;
    [SerializeField] public float speedH = 2.0f;
    [SerializeField] public float speedV = 2.0f;
    [SerializeField] public float speed = 5f;
    [SerializeField] private float jumpForce = 200f;

    [SerializeField] private float _raycastLenght;
    [SerializeField] private LayerMask _ground;

    private bool _canJump;
    
    

    private float yaw = 0.0f;
    private float pitch = 0.0f;

    [SerializeField] private float pitchClamp = 90;

    private void Start()
    {
        Cursor.visible = false;
    }

    void Update()
    {
        _canJump = Physics.Raycast(transform.position + new Vector3(0f, 0.1f, 0f), Vector3.down, _raycastLenght, _ground);


        if (playerTurn.IsPlayerTurn())
        {

            

            if (Input.GetAxis("Horizontal") != 0)
            {
                transform.Translate(transform.right * speed * Time.deltaTime * Input.GetAxis("Horizontal"), Space.World);
            }

            if (Input.GetAxis("Vertical") != 0)
            {
                transform.Translate(transform.forward * speed * Time.deltaTime * Input.GetAxis("Vertical"), Space.World);
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (_canJump)
                {
                    Jump();

                }
            }
            if (Input.GetKeyDown(KeyCode.Mouse1))
            {
                speed = 1f;
                speedH = 1f;
                speedV = 1f;
            }
            if (Input.GetKeyUp(KeyCode.Mouse1))
            {
                speed = 5f;
                speedH = 2.0f;
                speedV = 2.0f;
            }

            ReadRotationInput();

            
            
        }
    }

    private void Jump()
    {
        
        characterBody.AddForce(Vector3.up * jumpForce);
    }
    public void ReadRotationInput()
    {
        yaw += speedH * Input.GetAxis("Mouse X");
        pitch -= speedV * Input.GetAxis("Mouse Y");
        pitch = Mathf.Clamp(pitch, -pitchClamp, pitchClamp);

        characterCamera.transform.localEulerAngles = new Vector3(pitch, 0.0f, 0.0f);
        transform.eulerAngles = new Vector3(0.0f, yaw, 0.0f);
    }
}
