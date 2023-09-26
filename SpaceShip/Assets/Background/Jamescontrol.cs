using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jamescontrol : MonoBehaviour
{
    public float moveSpeed = 5f; // Velocidade de movimento do jogador
    public float minY = -3.74f; // Limite mínimo em Y
    public float maxY = -2.15f; // Limite máximo em Y
    public Sprite sp1; // Sprite de empinada
    public Sprite sp2; // Sprite padrão
    private bool isEmpinando = false;
    private Animator anim;
    void Update()
    {
        // Obtém as entradas do teclado para movimento
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        // Calcula a nova posição do jogador
        Vector3 newPosition = transform.position + new Vector3(moveX, moveY, 0) * moveSpeed * Time.deltaTime;

        // Limita a posição Y dentro dos limites minY e maxY
        newPosition.y = Mathf.Clamp(newPosition.y, minY, maxY);

        // Atualiza a posição do jogador
        transform.position = newPosition;

        // Verifica se a tecla "A" foi pressionada para alternar a animação de empinar
        if (Input.GetKeyDown(KeyCode.E))
        {
            anim.SetBool("isEmpinando", true);
        }

        // Verifica se a tecla "A" foi solta para voltar à animação padrão
        if (Input.GetKeyUp(KeyCode.E))
        {
            anim.SetBool("isEmpinando", false);
        }

       
    }
}
