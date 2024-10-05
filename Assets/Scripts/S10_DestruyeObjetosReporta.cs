using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class S10_DestruyeObjetosReporta : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] TextMeshProUGUI text_c;
     public int count;
    void Start()
    {
           count =0;
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
    private void OnCollisionEnter (Collision other){
        if(other.gameObject.CompareTag("Candy")){
            GameObject obj = other.gameObject;
            Destroy(obj);
            count++;
            text_c.text = count.ToString();
        }
    }
}
