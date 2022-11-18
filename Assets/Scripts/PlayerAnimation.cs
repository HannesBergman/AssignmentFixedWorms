using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{

    [SerializeField] private Animator animator;
    [SerializeField] private PlayerTurn playerTurn;

    void Update()
    {
        if (playerTurn.IsPlayerTurn())
        {
            

            if (Input.GetKeyDown(KeyCode.W))
            {
                animator.SetBool("Moving", true);
            }
            if (Input.GetKeyUp(KeyCode.W))
            {
                animator.SetBool("Moving", false);
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                animator.SetBool("MovingR", true);
            }
            if (Input.GetKeyUp(KeyCode.D))
            {
                animator.SetBool("MovingR", false);
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                animator.SetBool("MovingL", true);
            }
            if (Input.GetKeyUp(KeyCode.A))
            {
                animator.SetBool("MovingL", false);
            }

            if (Input.GetKeyDown(KeyCode.S))
            {
                animator.SetBool("MovingBack", true);
            }
            if (Input.GetKeyUp(KeyCode.S))
            {
                animator.SetBool("MovingBack", false);
            }
        }
    }
}
