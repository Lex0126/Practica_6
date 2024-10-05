using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CmabioDeescena : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI texto_score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         int escena_actual = SceneManager.GetActiveScene().buildIndex;
        if(escena_actual == 0){
            if(Input.GetKeyDown(KeyCode.Space)){
                cambioDeEscena(1);

            }    
        }
        else if (escena_actual ==2){
                texto_score.text =PlayerPrefs.GetInt("Score",0).ToString();
            }
    }
    public void cambioDeEscena(int index_escena_ir){
        SceneManager.LoadScene(index_escena_ir);
    }
    public void cambioDeEscena(int index_escena_ir,int score){
        PlayerPrefs.SetInt("Score",score);
        cambioDeEscena(index_escena_ir);
    }
}
