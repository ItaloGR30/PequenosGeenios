using UnityEngine;
using UnityEngine.SceneManagement;
public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] private string NomeDoLevelDoJogo; 
    [SerializeField] private GameObject painelMenuInicial;
    [SerializeField] private GameObject painelOpcoes;
    [SerializeField] private GameObject painelModulo1;
    [SerializeField] private GameObject painelModulo2;
    [SerializeField] private GameObject painelModulo3;
    public void Jogar()
    {
        SceneManager.LoadScene("Jogo");
    }
    public void abrirOpcoes()
    {
        painelMenuInicial.SetActive(false);
        painelOpcoes.SetActive(true);
        painelModulo1.SetActive(false);
        painelModulo2.SetActive(false);
        painelModulo3.SetActive(false);
    }
    public void Modulo1()
    {
        painelOpcoes.SetActive(false);
        painelModulo1.SetActive(true);
    }

    public void Modulo2()
    {
        painelOpcoes.SetActive(false);
        painelModulo2.SetActive(true);
    }
    
    public void Modulo3()
    {
        painelOpcoes.SetActive(false);
        painelModulo3.SetActive(true);
    }
    public void FecharOpcoes()
    {
        painelOpcoes.SetActive(false);
        painelMenuInicial.SetActive(true);
    }
    public void SairdoJogo()
    {
        Debug.Log("Sair do Jogo");
        Application.Quit();
    }
}
