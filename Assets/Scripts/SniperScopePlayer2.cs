using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SniperScopePlayer2 : MonoBehaviour
{
    [SerializeField] public Camera player2Camera;
    [SerializeField] public Camera player2SniperCamera;
    [SerializeField] public Camera player1Camera;
    [SerializeField] public Camera player1SniperCamera;
    [SerializeField] public Image player2SniperScope;
    [SerializeField] private PlayerTurn playerTurn;
    [SerializeField] public GameObject player;
    [SerializeField] private CharacterWeapon characterWeaponScript;

    
    


    void Update()
    {
        if (playerTurn.IsPlayerTurn())
        {
            player2Camera.enabled = true;
            player1Camera.enabled = false;
            player2SniperCamera.enabled = false;
            player2SniperScope.enabled = false;
            player1SniperCamera.enabled = false;
            
            if(characterWeaponScript.currentWeapon == 0)
            {
                if (Input.GetButton("CameraSwitch"))
                {
                    player2Camera.enabled = !player2SniperCamera.enabled;
                    player2SniperCamera.enabled = !player2SniperCamera.enabled;
                    player2SniperScope.enabled = !player2SniperScope.enabled;
                }
            }
        }
    }
}
