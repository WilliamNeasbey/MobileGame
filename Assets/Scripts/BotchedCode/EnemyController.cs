using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Transform playerTransform;
    public ParticleSystem muzzleFlash;
    public GameObject hitEffect;
    public float shootInterval = 0.5f;
    public int damage = 20;
    public float maxAngleOffset = 10f;
    public float hitFlashDuration = 0.1f;
    public Color hitFlashColor = Color.red;

    private bool isShooting = false;
    private float timeSinceLastShot = 0f;

    
   /* private void Update()
    {
        if (isShooting)
        {
            timeSinceLastShot += Time.deltaTime;

            if (timeSinceLastShot >= shootInterval)
            {
                Shoot();
                timeSinceLastShot = 0f;
            }
        }
    }

    public void StartShooting()
    {
        isShooting = true;
    }

    public void StopShooting()
    {
        isShooting = false;
    }

    private void Shoot()
    {
        float angleOffset = Random.Range(-maxAngleOffset, maxAngleOffset);
        Vector3 direction = (playerTransform.position - transform.position).normalized;
        direction = Quaternion.Euler(0f, angleOffset, 0f) * direction;

        Ray ray = new Ray(transform.position, direction);
        if (Physics.Raycast(ray, out RaycastHit hitInfo))
        {
            if (hitInfo.collider.CompareTag("Player"))
            {
                PlayerHealth playerHealth = hitInfo.collider.GetComponent<PlayerHealth>();
                if (playerHealth != null)
                {
                    playerHealth.TakeDamage(damage);

                    // Flash screen red if shot is going to hit the player
                    Camera.main.backgroundColor = hitFlashColor;
                    Invoke("ResetBackgroundColor", hitFlashDuration);
                }
            }
            else
            {
                GameObject effect = Instantiate(hitEffect, hitInfo.point, Quaternion.LookRotation(hitInfo.normal));
                Destroy(effect, 2f);
            }
        }

        muzzleFlash.Play();
    }

    private void ResetBackgroundColor()
    {
        Camera.main.backgroundColor = Color.black;
    }*/
}

