using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Ryu : MonoBehaviour
{
    /*public VirtualButton fireballButton;
    public VirtualButton spinningKickButton;
    public GameObject fireballPrefab;
    public Transform fireballSpawnPoint;
    public GameObject spinningKickEffect;
    public GameObject[] enemies;
    public GameObject gameOverUI;
    public GameObject victoryUI;
    public AudioClip fireballSound;
    public AudioClip spinningKickSound;
    public AudioClip gameoverMusic;
    public AudioClip victoryMusic;

    private Animator animator;
    private int health = 100;

    private void Start()
    {
        animator = GetComponent<Animator>();
        gameOverUI.SetActive(false);
        victoryUI.SetActive(false);
    }

    private void Update()
    {
        if (fireballButton.isPressed)
        {
            animator.SetTrigger("Fireball");
            AudioSource.PlayClipAtPoint(fireballSound, transform.position);
            GameObject fireball = Instantiate(fireballPrefab, fireballSpawnPoint.position, Quaternion.identity);
            if (enemies.Length > 0)
            {
                // Find closest enemy and target fireball towards them
                GameObject closestEnemy = enemies[0];
                float closestDistance = Vector3.Distance(fireball.transform.position, closestEnemy.transform.position);
                foreach (GameObject enemy in enemies)
                {
                    float distance = Vector3.Distance(fireball.transform.position, enemy.transform.position);
                    if (distance < closestDistance)
                    {
                        closestEnemy = enemy;
                        closestDistance = distance;
                    }
                }
                fireball.GetComponent<Fireball>().SetTarget(closestEnemy.transform);
            }
        }
        if (spinningKickButton.isPressed)
        {
            animator.SetTrigger("SpinningKick");
            AudioSource.PlayClipAtPoint(spinningKickSound, transform.position);
            GameObject spinningKick = Instantiate(spinningKickEffect, transform.position, Quaternion.identity);
            Destroy(spinningKick, 2f);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            health -= 10;
            if (health <= 0)
            {
                health = 0;
                GameOver();
            }
        }
    }

    void CheckVictory()
    {
        bool allEnemiesDead = true;
        foreach (GameObject enemy in enemies)
        {
            if (enemy.activeSelf)
            {
                allEnemiesDead = false;
                break;
            }
        }
        if (allEnemiesDead)
        {
            // Stop background music and play victory music
            AudioSource[] audioSources = FindObjectsOfType<AudioSource>();
            foreach (AudioSource audioSource in audioSources)
            {
                if (audioSource.tag == "BackgroundMusic")
                {
                    audioSource.Stop();
                }
            }
            AudioSource.PlayClipAtPoint(victoryMusic, transform.position);

            // Show victory UI after delay
            Invoke("ShowVictoryUI", 3f);
        }
    }

    void ShowGameOverUI()
    {
        // Stop background music and play game over music
        AudioSource[] audioSources = FindObjectsOfType<AudioSource>();
        foreach (AudioSource audioSource in audioSources)
        {
            if (audioSource.tag == "BackgroundMusic")
            {
                audioSource.Stop();
            }
        }
        AudioSource.PlayClipAtPoint(gameoverMusic, transform.position);

        // Show game over UI after delay
        Invoke("ShowGameOverUI", 3f);
    }

    void ShowVictoryUI()
    {
        victoryUI.SetActive(true);
    }
    void GameOver()
    {
        // Disable virtual buttons
        fireballButton.gameObject.SetActive(false);
        spinningKickButton.gameObject.SetActive(false);

        // Play game over animation
        animator.SetTrigger("GameOver");

        // Show game over UI after delay
        Invoke("ShowGameOverUI", 3f);
    }*/
}
