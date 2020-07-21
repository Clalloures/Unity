using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_camera : MonoBehaviour
{
    public GameObject objetoBolinha;
    private Vector3 posicaoInicial; 

    // Start is called before the first frame update
    void Start(){
        posicaoInicial = transform.position;
    }

    // Update is called once per frame
    void LateUpdate(){
        transform.position = objetoBolinha.transform.position + posicaoInicial;

    }
}
