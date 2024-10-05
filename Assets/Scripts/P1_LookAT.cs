using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1_LookAT : MonoBehaviour
{
    // Start is called before the first frame update

    Transform ubi_Obj_a_Mirar;
    P2_calculo_distancia auxComponenteDistance;
    [SerializeField] CmabioDeescena auxiliar;
    //solo game objects
    private void Awake(){
        ubi_Obj_a_Mirar = GameObject.Find("Player").GetComponent<Transform>();
    }
    //solo componentes
    void Start()
    {
        auxComponenteDistance = GetComponent<P2_calculo_distancia>();
    }


    // Update is called once per frame
    void Update()

    {   
        float distanciaAlEnemigo= auxComponenteDistance.getDistance();
        if(distanciaAlEnemigo <6.0f){
            float valY=ubi_Obj_a_Mirar.position.y;
            //si esta por encima del umbral(3.0f)
         if (valY>6.5f)
         {
            transform.LookAt(new Vector3(ubi_Obj_a_Mirar.position.x,6.5f,ubi_Obj_a_Mirar.position.z));
            

         }
          else
            {

            transform.LookAt(ubi_Obj_a_Mirar.position);

            }
       

        }
        
        

       
    }
}
