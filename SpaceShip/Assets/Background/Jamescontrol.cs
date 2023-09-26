using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jamescontrol : MonoBehaviour
{
    public float moveSpeed = 5f; // Velocidade de movimento do jogador
    public float minY = -3.74f; // Limite m�nimo em Y
    public float maxY = -2.15f; // Limite m�ximo em Y
    public Sprite sp1; // Sprite de empinada
    public Sprite sp2; // Sprite padr�o
    private bool isEmpinando = false;
    private Animator anim;
    void Update()
    {
        // Obt�m as entradas do teclado para movimento
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        // Calcula a nova posi��o do jogador
        Vector3 newPosition = transform.position + new Vector3(moveX, moveY, 0) * moveSpeed * Time.deltaTime;

        // Limita a posi��o Y dentro dos limites minY e maxY
        newPosition.y = Mathf.Clamp(newPosition.y, minY, maxY);

        // Atualiza a posi��o do jogador
        transform.position = newPosition;

        // Verifica se a tecla "A" foi pressionada para alternar a anima��o de empinar
        if (Input.GetKeyDown(KeyCode.E))
        {
            anim.SetBool("isEmpinando", true);
        }

        // Verifica se a tecla "A" foi solta para voltar � anima��o padr�o
        if (Input.GetKeyUp(KeyCode.E))
        {
            anim.SetBool("isEmpinando", false);
        }

       
    }
}
