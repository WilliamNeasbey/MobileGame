using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sonic : MonoBehaviour
{
    /*public float speed = 10f;
    public float jumpForce = 300f;
    public float homingAttackForce = 500f;
    public Text scoreText;
    public Text timerText;
    public Text highScoreText;
    public Text bestTimeText;
    public GameObject goalPost;
    public GameObject lockOnPrefab;
    public Button jumpButton;
    public Button attackButton;
    public Joystick joystick;
    public AudioClip gameMusic;
    public AudioClip resultsMusic;

    private Rigidbody rb;
    private Animator animator;
    private float score = 0f;
    private float timer = 0f;
    private float highScore = 0f;
    private float bestTime = 0f;
    private bool isGrounded = true;
    private bool isGoalReached = false;
    private bool isAttacking = false;
    private GameObject lockOnTarget;
    private AudioSource audioSource;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
        highScore = PlayerPrefs.GetFloat("HighScore", 0f);
        bestTime = PlayerPrefs.GetFloat("BestTime", 0f);
        highScoreText.text = "High Score: " + highScore.ToString("0");
        bestTimeText.text = "Best Time: " + bestTime.ToString("0.00");
        goalPost.SetActive(false);
        audioSource.clip = gameMusic;
        audioSource.loop = true;
        audioSource.Play();
    }

    void FixedUpdate()
    {
        if (!isGoalReached)
        {
            float moveHorizontal = joystick.Horizontal;
            float moveVertical = joystick.Vertical;

            Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
            rb.AddForce(movement * speed);

            if (Mathf.Abs(moveHorizontal) > 0.1f || Mathf.Abs(moveVertical) > 0.1f)
            {
                transform.rotation = Quaternion.LookRotation(movement);
                animator.SetBool("isRunning", true);
            }
            else
            {
                animator.SetBool("isRunning", false);
            }

            if (Input.GetKeyDown(KeyCode.Space) || jumpButton.GetComponent<ButtonHandler>().isPressed)
            {
                Jump();
            }

            if (Input.GetKeyDown(KeyCode.Z) || attackButton.GetComponent<ButtonHandler>().isPressed)
            {
                Attack();
            }

            if (lockOnTarget != null)
            {
                Vector3 targetDirection = lockOnTarget.transform.position - transform.position;
                Quaternion targetRotation = Quaternion.LookRotation(targetDirection);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, 360f * Time.deltaTime);
            }

            timer += Time.deltaTime;
            timerText.text = "Time: " + timer.ToString("0.00");
        }
        else
        {
            if (timer > bestTime)
            {
                bestTime = timer;
                PlayerPrefs.SetFloat("BestTime", bestTime);
            }

            highScore = Mathf.Max(highScore, score);
            PlayerPrefs.SetFloat("HighScore", highScore);

            scoreText.text = "Score: " + score.ToString();
            timerText.text = "Time: " + timer.ToString("0.00");
            highScoreText.text = "High Score: " + highScore.ToString("0");
            bestTimeText.text = "Best Time: " + bestTime.ToString("0.00");
            audioSource.Stop();
            audioSource.clip = resultsMusic;
            audioSource.loop = false;
            audioSource.Play();
        }
    }*/
}
