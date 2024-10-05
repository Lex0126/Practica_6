using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2_Movimiento_enemigo : MonoBehaviour
{
    // Start is called before the first frame update
    Transform ubi_personaje;
    P2_calculo_distancia auxComponenteDistance;
    private void Awake(){
        ubi_personaje = GameObject.Find("Player").GetComponent<Transform>();
    }
    void Start()
    {
        auxComponenteDistance = GetComponent<P2_calculo_distancia>();
    }

    // Update is called once per frame
    void Update()

    {
        float distanciaAlEnemigo= auxComponenteDistance.getDistance();
        if(distanciaAlEnemigo <5.5f){
        float velocidad =4.0f * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position,ubi_personaje.position,velocidad);
    }
}
}
