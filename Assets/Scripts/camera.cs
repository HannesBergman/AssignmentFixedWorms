using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    [SerializeField] private Camera player1Camera;
    [SerializeField] private Camera player2Camera;
    [SerializeField] private PlayerTurn playerTurn;

    void Update()
    {
        if (playerTurn.IsPlayerTurn())
        {
            player1Camera.enabled = true;
            player2Camera.enabled = false;
        }
    }
}
