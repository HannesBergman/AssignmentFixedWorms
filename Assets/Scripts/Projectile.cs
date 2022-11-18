using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Rigidbody projectileBody;
    
    private bool isActive;
    private float weaponDamage = 100;

    public void Initialize(Vector3 direction)
    {
        isActive = true;
        projectileBody.AddForce(direction);
    }

    void Update()
    {
        if (isActive)
        { 
            projectileBody.MovePosition(transform.position + transform.forward * speed * Time.deltaTime);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {

            ActivePlayerHealth activePlayerHealth = other.gameObject.GetComponent<ActivePlayerHealth>();
            if (activePlayerHealth != null)
            {
                activePlayerHealth.TakeDamage(weaponDamage);
            }
        }
        Destroy(gameObject);
        
    }
    
}
