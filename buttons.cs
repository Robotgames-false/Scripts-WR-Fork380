using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttons : MonoBehaviour
{
   public Button meuBotao;
    private float tempoInicial;

    void Start()
    {
        if (meuBotao != null)
        {
            // Adiciona este script como um handler para o evento OnPointerUp do botão
            meuBotao.onClick.AddListener(OnPointerUp);

            // Armazena o tempo inicial
            tempoInicial = Time.time;
        }
    }

    void Update()
    {
        if (meuBotao != null)
        {
            // Verifica se passaram 10 segundos
            if (Time.time - tempoInicial >= 10f)
            {
                ChamarOnPointerUp();
            }
        }
    }

    void ChamarOnPointerUp()
    {
        OnPointerUp(); // Chama o método após 10 segundos
    }

    public void OnPointerUp()
    {
        Debug.Log("Botão específico foi liberado!");
        // Adicione aqui o código que deseja executar quando o botão específico for liberado.
    }
}
