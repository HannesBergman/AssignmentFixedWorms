using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterWeapon : MonoBehaviour
{
    [SerializeField] private PlayerTurn playerTurn;
    [SerializeField] private Sniper gunSniper;
    [SerializeField] private GrenadeLauncher gunGranadeLauncher;
    public int currentWeapon;
    public Transform[] weapons;
    



    private void Update()
    {
        bool IsPlayerTurn = playerTurn.IsPlayerTurn();
        
        if (IsPlayerTurn)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                changeWeapon(0);
            }
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                changeWeapon(1);
            }
            if(currentWeapon == 0)
            {
                if (Input.GetKeyDown(KeyCode.Mouse0))
                {
                    TurnManager.GetInstance().TriggerChangeTurn();
                    gunSniper.SniperShoot();
                }
            }
            if (currentWeapon == 1)
            {
                if (Input.GetKeyDown(KeyCode.Mouse0))
                {
                    gunGranadeLauncher.ShootGrenadeLauncher();
                    TurnManager.GetInstance().TriggerChangeTurn();
                    
                }
                
            }
        }
    }
    public void changeWeapon(int num)
    {
        currentWeapon = num;
        for(int i = 0; i < weapons.Length; i++)
        {
            if(i == num)
            {
                weapons[i].gameObject.SetActive(true);
            }
            else
            {
                weapons[i].gameObject.SetActive(false);
            }
        }
    }
}
