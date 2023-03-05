using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public ParticleSystem particlePrefab;
    public float damageAmount = 10f;
    public Transform shootingTransform;
    public Transform cameraTransform;
    public float moveSpeed = 5f;

    private bool isShooting = false;
    private bool isCrouching = false;
    private float cameraYStanding = 1.6f;
    private float cameraYCrouching = 0.8f;
    private CharacterController characterController;

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        // Handle shooting
        if (isShooting && Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);

            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                ParticleSystem particleInstance = Instantiate(particlePrefab, shootingTransform.position, shootingTransform.rotation);
                Destroy(particleInstance.gameObject, 2f);

                EnemyController enemy = hit.collider.GetComponent<EnemyController>();
                if (enemy != null)
                {
                    //enemy.TakeDamage(damageAmount);
                }
            }
        }

        // Handle player movement
        Vector3 moveDirection = Vector3.zero;
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                isShooting = true;
            }
            else if (touch.phase == TouchPhase.Ended)
            {
                isShooting = false;
            }

            if (touch.phase == TouchPhase.Moved)
            {
                Vector2 touchDeltaPosition = touch.deltaPosition;
                if (touchDeltaPosition.y < -20 && !isCrouching) // Swipe down
                {
                    isCrouching = true;
                    cameraTransform.localPosition = new Vector3(cameraTransform.localPosition.x, cameraYCrouching, cameraTransform.localPosition.z);
                }
                else if (touchDeltaPosition.y > 20 && !isShooting) // Swipe up
                {
                    isShooting = true;
                    cameraTransform.localPosition = new Vector3(cameraTransform.localPosition.x, cameraYStanding, cameraTransform.localPosition.z);
                }
            }
        }

        if (!isCrouching)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection) * moveSpeed;
        }

        characterController.Move(moveDirection * Time.deltaTime);
    }
}
