using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heyyo : MonoBehaviour

{
    public GameObject astro;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(astro.gameObject.transform.position.x , -0.04f, -2.06234f);
    }
}
