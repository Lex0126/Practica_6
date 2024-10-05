using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WordBobble : MonoBehaviour
{
    // Start is called before the first frame update
    TMP_Text Mensaje;
    Mesh mesh;
    Vector3[] vertices;

    void Start()
    {
        Mensaje = GetComponent<TMP_Text>();

    }

    // Update is called once per frame
    void Update()
    {
       
        Mensaje.ForceMeshUpdate();
        mesh=Mensaje.mesh;
        vertices = mesh.vertices;

        for(int i=0; i<vertices.Length;i++){
            Vector3 offset= Wobble(Time.time+i*0.1f)*1.0f;

            vertices[i] = vertices[i]+ offset;

        }
        mesh.vertices = vertices;
        Mensaje.canvasRenderer.SetMesh(mesh);
    }

    Vector2 Wobble(float time){
        return new Vector2(Mathf.Sin(time*3.3f), Mathf.Cos(time*2.5f));
    }
 
}
