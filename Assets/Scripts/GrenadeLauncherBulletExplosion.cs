using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrenadeLauncherBulletExplosion : MonoBehaviour
{
    public float blastRadius;
    public float explosionForce;

    private Collider[] hitColliders;
    private float weaponDamage = 20;
    [SerializeField] private GrenadeLauncher grenadeLauncher;


    private void OnCollisionEnter(Collision collision)
    {
        DoExplosion(collision.contacts[0].point);
        Destroy(gameObject);
    }

    private void DoExplosion(Vector3 explosionPoint)
    {
        hitColliders = Physics.OverlapSphere(explosionPoint, blastRadius);

        foreach(Collider hitcol in hitColliders)
        {
            if(hitcol.GetComponent<Rigidbody>() != null)
            {
                hitcol.GetComponent<Rigidbody>().isKinematic = false;
                hitcol.GetComponent<Rigidbody>().AddExplosionForce(explosionForce, explosionPoint, blastRadius, 0.02f, ForceMode.Impulse);
                
            }
            if (hitcol.gameObject.tag == "Player")
            {
                hitcol.GetComponent<Rigidbody>().isKinematic = false;
                hitcol.GetComponent<Rigidbody>().AddExplosionForce(explosionForce, explosionPoint, blastRadius, 0.02f, ForceMode.Impulse);

                ActivePlayerHealth activePlayerHealth = hitcol.gameObject.GetComponent<ActivePlayerHealth>();
                if (activePlayerHealth != null)
                {
                    activePlayerHealth.TakeDamage(weaponDamage);
                }
            }
        }
    }
}
