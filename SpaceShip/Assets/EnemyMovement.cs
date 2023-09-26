using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float moveSpeed = 2.0f; // Velocidade de movimento do inimigo
    public float minX = -10.0f; // Posi��o X m�nima (esquerda)
    public float maxX = 10.0f; // Posi��o X m�xima (direita)
    private bool movingRight = true; // Flag para controlar a dire��o do movimento

    private void Update()
    {
        // Move o inimigo da direita para a esquerda
        if (movingRight)
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);

            // Se atingir a posi��o m�xima � direita, muda a dire��o
            if (transform.position.x >= maxX)
            {
                movingRight = false;
            }
        }
        else
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);

            // Se atingir a posi��o m�nima � esquerda, muda a dire��o
            if (transform.position.x <= minX)
            {
                movingRight = true;
            }
        }
    }
}

