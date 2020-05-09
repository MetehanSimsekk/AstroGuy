using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Patika : MonoBehaviour
{
    public bool temasEdildimi;

    public GameObject borular;

    
    void Start()
    {
        temasEdildimi = false;
    }

    // Update is called once per frame
    void Update() {
        if (temasEdildimi)
        {


            Invoke("IleriAta", 4.7f);

            temasEdildimi = false;



        }

    }

    void IleriAta()
        {
            
            transform.position = transform.position + new Vector3(10427, 0, 0);

        //en az -3.47 veya en fazla 3.67
        float yPoz = Random.Range(-2.84f , 1.21f);
        Debug.Log(yPoz.ToString());

        borular.transform.position = new Vector3(transform.position.x, yPoz, -0.2f);
        
        }
    }

