using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Gameover : MonoBehaviour
{
    public GameObject gameOverUI;
    public GameObject player;
    public AudioSource gameMusic;
    public AudioSource gameOverMusic;
    public AudioSource DeathSound;

    private bool isGameOver = false;

    public float deathHeight = -6f; // The height at which the game will end

    private void Update()
    {
        if (!isGameOver && player.transform.position.y < Camera.main.transform.position.y + deathHeight)
        {
            EndGame();
        }
    }

    public void EndGame()
    {
        isGameOver = true;

        gameMusic.Stop();
        gameOverMusic.Play();
        DeathSound.Play();

        Time.timeScale = 0f;

        gameOverUI.SetActive(true);
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void ReturnToMenu()
    {
        Time.timeScale = 1f;

        SceneManager.LoadScene("MenuScene");
    }
}
