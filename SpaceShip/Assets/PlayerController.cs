using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Transform player;
    public float speed;
    public float maxVerticalBound, minVerticalBound;

    public GameObject shot;
    public Transform shotSpawn;
    public float fireRate;

    public int maxLives = 3;
    private int currentLives;
    private bool isDamaged = false;

    private float nextFire;

    private Animator animator;
    private AudioSource playerAudioSource;

    void Start()
    {
        currentLives = maxLives;
        player = GetComponent<Transform>();
        animator = GetComponent<Animator>();
        playerAudioSource = GetComponent<AudioSource>();
    }

    void FixedUpdate()
    {
        float v = Input.GetAxis("Vertical");

        if (player.position.y < minVerticalBound && v < 0)
            v = 0;
        else if (player.position.y > maxVerticalBound && v > 0)
            v = 0;

        player.position += Vector3.up * v * speed; 
    }

    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
            if (playerAudioSource != null)
            {
                playerAudioSource.Play();
            }
        }
    }
}
