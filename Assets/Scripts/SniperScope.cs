using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SniperScope : MonoBehaviour
{
    [SerializeField] public Camera player1Camera;
    [SerializeField] public Camera player1SniperCamera;
    [SerializeField] public Camera player2Camera;
    [SerializeField] public Camera player2SniperCamera;
    [SerializeField] private Image player1SniperScope;
    [SerializeField] private PlayerTurn playerTurn;
    [SerializeField] public GameObject player;
    [SerializeField] private CharacterWeapon characterWeaponScript;


    private void Start()
    {
        
        
        
        player1Camera.enabled = true;
        player2Camera.enabled = false;
        player1SniperCamera.enabled = false;
        player1SniperScope.enabled = false;
        player2SniperCamera.enabled = false;
    }

    void Update()
    {
        

        if (playerTurn.IsPlayerTurn())
        {
            player1Camera.enabled = true;
            player2Camera.enabled = false;
            player1SniperCamera.enabled = false;
            player1SniperScope.enabled = false;
            player2SniperCamera.enabled = false;
            
            if (characterWeaponScript.currentWeapon == 0)
            {
                    if (Input.GetButton("CameraSwitch"))
                    {
                        player1Camera.enabled = !player1Camera.enabled;
                        player1SniperCamera.enabled = !player1SniperCamera.enabled;
                        player1SniperScope.enabled = !player1SniperScope.enabled;
                    }
            }    
        }
    }
}
