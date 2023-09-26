using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour
{
    private Transform enemyHolder;
    public float speed;
    public GameObject shot;
    public Text winText;
    public float fireRate = 0.2f;
    private Animator animator;

    void Start()
    {
        winText.enabled = false;
        InvokeRepeating("MoveEnemy", 0.1f, 0.3f);
        enemyHolder = GetComponent<Transform>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {

    }

    void MoveEnemy()
    {
        // Mova o enemyHolder para a esquerda com uma velocidade negativa.
        enemyHolder.position += Vector3.left * speed;

        foreach (Transform enemy in enemyHolder)
        {
            if (enemy.position.x < -15.5 || enemy.position.x > 5.5)
            {
                speed = -speed;
               
                return;
            }

            if (Random.value > fireRate)
            {
                Instantiate(shot, enemy.position, enemy.rotation);
            }

            if (enemy.position.x <= -7.8)
            {
                GameOver.isPlayerDead = true;
                Time.timeScale = 0;
            }
        }

        if (enemyHolder.childCount == 1)
        {
            CancelInvoke();
            InvokeRepeating("MoveEnemy", 0.1f, 0.25f);
        }

        if (enemyHolder.childCount == 0)
        {
            animator.SetTrigger("DestroyTrigger");

            float animationDuration = 2.0f;
            Destroy(gameObject, animationDuration);
        }
    }
}
