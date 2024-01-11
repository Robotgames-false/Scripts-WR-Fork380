using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttons : MonoBehaviour
{
    public Button meuBotao;
    private float tempoDecorrido;

    void Update()
    {
        if (meuBotao != null)
        {
            // Adiciona este script como um handler para o evento OnPointerUp do botão
            meuBotao.onClick.AddListener(OnPointerUp);

            // Atualiza o tempo decorrido
            tempoDecorrido += Time.deltaTime;

            // Verifica se passaram 10 segundos
            if (tempoDecorrido >= 10f)
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
