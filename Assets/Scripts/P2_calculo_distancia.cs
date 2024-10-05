using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2_calculo_distancia : MonoBehaviour
{
    // Start is called before the first frame update
    Transform ubi_obj_a_calc_dist;

    float distance;
    public float getDistance(){
        return distance;
    }

    private void Awake(){
        ubi_obj_a_calc_dist = GameObject.Find("Player").GetComponent<Transform>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(transform.position,ubi_obj_a_calc_dist.position);
    }
}
