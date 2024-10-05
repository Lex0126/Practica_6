using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class S9_TiempoJuego : MonoBehaviour
{

    [SerializeField]CmabioDeescena auxiliar;
    [SerializeField]S10_DestruyeObjetosReporta acceso_score;
    int contador_segundos;
    [SerializeField] TextMeshProUGUI Tiempo;

    // Start is called before the first frame update
    void Start()
    {
        contador_segundos =95;
        Tiempo.text = contador_segundos.ToString();

        StartCoroutine("corrutinaTiempo");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator corrutinaTiempo(){
        while (contador_segundos>=0){
            Tiempo.text = contador_segundos--.ToString();
            yield return new WaitForSeconds(1.00f);
    
        }
        Debug.Log("Se acabo el juego");
        int score = acceso_score.count;
        Debug.Log(score);
        auxiliar.cambioDeEscena(2,score);

    }
}
