using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyBulletController : MonoBehaviour
{
    private Transform bullet;
    public float speed;

    // Use this for initialization
    void Start()
    {
        bullet = GetComponent<Transform>();
    }

    void FixedUpdate()
    {
        bullet.position += Vector3.left * speed; // Mova a bala para a esquerda no eixo X.

        if (bullet.position.x <= -10)
            Destroy(bullet.gameObject);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            GameOver.isPlayerDead = true;
            // Invoke("LoadGameOverScene", 3f);
        }
    }

    //void LoadGameOverScene()
    //{
    //  SceneManager.LoadScene("gameover");
    //}
}
