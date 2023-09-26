using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    private Transform bullet;
    public float speed;
    private AudioSource audioSource;
    public AudioClip hitSound;
    public AudioClip destroySound;

    // Use this for initialization
    void Start()
    {
        bullet = GetComponent<Transform>();
        audioSource = GetComponent<AudioSource>();
    }

    void FixedUpdate()
    {
        bullet.position += Vector3.right * speed; // Mova o disparo no eixo X.

        // Verifique os limites de posição em X para destruir o objeto.
        if (bullet.position.x >= 10 || bullet.position.x <= -10)
            Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            PlayerScore.playerScore += 100;
            audioSource.PlayOneShot(destroySound);
        }
    }
}
