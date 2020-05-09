using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class KusScript : MonoBehaviour
{
    public float hiz;
    public float ziplamaGucu;
    public int puan;

    public Text RecordText;
    public Text PointText;

    public GameObject canvas;

    public AudioClip[] sesFiles;


    // Start is called before the first frame update
    private void Start()
    {

        canvas.SetActive(false);
        Time.timeScale = 1;
        puan = 0;


    }

    // Update is called once per frame
    private void Update()
    {
        transform.Translate(Vector3.right * hiz * Time.deltaTime);


        for (var i = 0; i < Input.touchCount; ++i)
        {
            if (Input.GetTouch(i).phase == TouchPhase.Began)
            {
                GetComponent<AudioSource>().PlayOneShot(sesFiles[0], 1);
                GetComponent<Rigidbody2D>().AddForce(Vector3.up * ziplamaGucu);
            }
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            GetComponent<AudioSource>().PlayOneShot(sesFiles[0], 1);
            GetComponent<Rigidbody2D>().AddForce(Vector3.up * ziplamaGucu);
        }
    }

    private void OnTriggerEnter2D(Collider2D temas)
    {
        if (temas.gameObject.tag == "Tetik")
        {


            temas.gameObject.transform.parent.root.GetComponent<Patika>().temasEdildimi = true;
            GetComponent<AudioSource>().PlayOneShot(sesFiles[1], 1);
            puan++;

        }

    }

    private void OnCollisionEnter2D(Collision2D temas)
    {
        if (temas.gameObject.tag == "Engel")
        {
            Debug.Log("carpti");
            OyunSonu();
        }

    }

    public void OyunSonu()
    {
        
        Time.timeScale = 0;
        GetComponent<AudioSource>().PlayOneShot(sesFiles[2], 1);
        canvas.SetActive(true);
        PointText.text = puan.ToString();
        if (puan > PlayerPrefs.GetInt("Rekor"))
        {
            PlayerPrefs.SetInt("Rekor", puan);
        }
        




        RecordText.text = PlayerPrefs.GetInt("Rekor").ToString(); 

    }
    public void AgainButton() => Application.LoadLevel("SampleScene");

    public void MainGame() => SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + -1);
    

}


