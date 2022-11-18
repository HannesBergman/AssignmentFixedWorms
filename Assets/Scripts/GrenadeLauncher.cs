using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrenadeLauncher : MonoBehaviour
{
    [SerializeField] private GameObject projectilePrefab;
    [SerializeField] private Transform shootingStartPosition;
    
    
    private Transform myTransform;
    

    public float propulsionForce;

    //public void GrenadeLauncherShoot()
    //{
    //   Vector3 force = transform.forward * 700f + transform.up * 300f;

    //    GameObject newProjectile = Instantiate(projectilePrefab);
    //    newProjectile.transform.position = shootingStartPosition.position;
    //    newProjectile.GetComponent<Projectile>().Initialize(force);
        

    //}
    private void Start()
    {
        SetInitialReferences();
    }
    private void SetInitialReferences()
    {
        myTransform = transform;
    }
    public void ShootGrenadeLauncher()
    {
        GameObject grenade = (GameObject)Instantiate(projectilePrefab, myTransform.transform.TransformPoint(1f, 0, 0), myTransform.rotation);
        grenade.GetComponent<Rigidbody>().AddForce(myTransform.right * propulsionForce, ForceMode.Impulse);
    }
}
