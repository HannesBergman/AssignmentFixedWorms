using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sniper : MonoBehaviour
{
    
    [SerializeField] private GameObject projectilePrefab;
    [SerializeField] private Transform shootingStartPosition;
    
    
    public void SniperShoot()
    {
        Vector3 force = transform.right * 700f + transform.up * 100f;

        GameObject newProjectile = Instantiate(projectilePrefab);
        newProjectile.transform.position = shootingStartPosition.position;
        newProjectile.GetComponent<Projectile>().Initialize(force);

    }
}
