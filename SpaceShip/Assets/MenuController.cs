using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public string fase1 = "cena1"; // Substitua "Fase1" pelo nome da sua cena da fase 1
    public Button startButton; // Refer�ncia ao bot�o no Unity Inspector

    private void Start()
    {
        // Adicione um ouvinte de clique ao bot�o
        startButton.onClick.AddListener(StartFase1);
    }

    public void StartFase1()
    {
        SceneManager.LoadScene(fase1);
    }

    public void QuitGame()
    {
        // Este m�todo pode ser usado para sair do jogo (somente na build final).
        Application.Quit();
    }
}
