using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class PlayerMovement2 : MonoBehaviour
{
    public float step = 600f;
    private Rigidbody rb;
    private Vector3 movement;
    private int direction = 1;
    private float diff;
    private bool isJumping = false;
    private bool isGrounded = false;
    public float jumpForce = 20.0f;
    public float grav = 5;
    public float hitpower = 200f;
    private bool isKnockedBack = false;
    private Vector3 knockbackDirection = Vector3.zero;
    public Canvas UI;
    public Slider healthbar;
    public Slider ScoreBar;
    public GameObject gameover;
    public GameObject YouWin;
    public Animator animatorboy;
    public Animator animatorgirl;
    public Animator animator;
    public AudioSource deathSound;
    public AudioSource hurtSound;

    public GameObject boy;
    public GameObject girl;

    string m_DeviceType;

    void Start()
    {
        if (PlayerPrefs.GetInt("caracter") == 0)
        {
            girl.SetActive(false);
            boy.SetActive(true);
            animator = animatorboy;
        }
        else
        {
            girl.SetActive(true);
            boy.SetActive(false);
            animator = animatorgirl;
        }

        step = 600;
        diff = transform.position.x - Camera.main.transform.position.x;
        rb = GetComponent<Rigidbody>();
        Physics.gravity = new Vector3(0, -grav, 0);

        if (PlayerPrefs.GetInt("soundfx") == 0)
        {
            deathSound.mute = false;
            hurtSound.mute = false;
        }
        else
        {
            deathSound.mute = true;
            hurtSound.mute = true;
        }
    }

    public void Jump()
    {
        if (!isJumping && isGrounded)
        {
            isJumping = true;
            isGrounded = false;
        }
    }

    void Update()
    {
        healthbar.maxValue = PlayerPrefs.GetInt("health");

        // Handle movement input
        movement = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        animator.SetFloat("step", Input.GetAxis("Horizontal"));

        // Adjust player direction
        if (Input.GetAxis("Horizontal") > 0)
        {
            direction = 1;
            transform.eulerAngles = new Vector3(0, 90, 0);
        }
        else if (Input.GetAxis("Horizontal") < 0)
        {
            direction = -1;
            transform.eulerAngles = new Vector3(0, -90, 0);
        }

        // Jump handling
        if (Input.GetButtonDown("Jump") && !isJumping && isGrounded)
        {
            Jump();
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector3(step * Time.deltaTime * movement.x, rb.velocity.y, rb.velocity.z);
        rb.AddForce(Physics.gravity);

        if (isKnockedBack)
        {
            rb.AddForce(-knockbackDirection * hitpower * Time.fixedDeltaTime, ForceMode.Impulse);
            StartCoroutine(StopKnockback());
        }

        if (isJumping)
        {
            Vector3 jumpVector = new Vector3(direction * 1, jumpForce, 0f);
            rb.AddForce(jumpVector, ForceMode.Impulse);
            StartCoroutine(StopJumping());
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Terrain"))
        {
            isJumping = false;
            isGrounded = true;
        }
        else if (collision.gameObject.CompareTag("Enemy") && !isKnockedBack)
        {
            hurtSound.Play();
            healthbar.value--;

            knockbackDirection = -collision.contacts[0].normal;
            isKnockedBack = true;
        }

        if (collision.gameObject.CompareTag("Win"))
        {
            YouWin.SetActive(true);
        }

        if (collision.gameObject.CompareTag("GameOver"))
        {
            deathSound.Play();
            gameover.SetActive(true);
            Destroy(gameObject);
        }
    }

    private IEnumerator StopKnockback()
    {
        yield return new WaitForSeconds(0.2f);
        isKnockedBack = false;
        knockbackDirection = Vector3.zero;
    }

    private IEnumerator StopJumping()
    {
        yield return new WaitForSeconds(0.3f);
        isJumping = false;
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Terrain"))
        {
            isGrounded = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Contains("Key"))
        {
            Destroy(other.gameObject);
            ScoreBar.value += 1;
        }
    }
}
