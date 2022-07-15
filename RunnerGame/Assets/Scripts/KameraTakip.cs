using UnityEditor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class KameraTakip : MonoBehaviour
{

    public Transform karakterkonum;
    Vector3 fark;

    void Start()
    {
        fark = transform.position - karakterkonum.position;
    }

    void Update()
    {
        transform.position = karakterkonum.position + fark;
    }
<<<<<<< HEAD


    private void LateUpdate()
    {
        if (sona_geldikmi)
        {
            transform.position = Vector3.Lerp(transform.position, kamera_Son_konum.transform.position, 0.125f);
        }
          
            
        
    }
=======
>>>>>>> parent of 96b6d762 (update4)
}
