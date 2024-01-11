using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class buttons : MonoBehaviour
{
   public Button meuBotao;
    private float tempoInicial;

    void Start()
    {
       
    }

    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space)){
            OnDeselect();
        }
       
    }

    public void OnDeselect(){
        Debug.Log("Descelected");
    }
}
