using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera2 : MonoBehaviour
{

    [SerializeField] private Camera player1Camera;
    [SerializeField] private Camera player2Camera;
    [SerializeField] private PlayerTurn playerTurn;

    void Update()
    {
        if (playerTurn.IsPlayerTurn())
        {
            player1Camera.enabled = false;
            player2Camera.enabled = true;
        }
    }
}
