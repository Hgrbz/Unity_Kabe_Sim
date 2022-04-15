using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaftTrigger : MonoBehaviour
{

    public GameObject[] textler;
    public int saftsayisi = 0;
    public int x = 0;//saft sayisi için;
    public int y = 0; //dizi indisi için;
    public AudioSource source;
    public AudioClip clip1, clip2, clip3, clip4, clip5, clip6, clip7;
    public GameObject sesTrig,col;
    // Start is called before the first frame update
    void Start()
    {
        source = sesTrig.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            col.SetActive(false);
            if (saftsayisi == 0)
            {
                textler[0].SetActive(true);
                saftsayisi = 1;
                source.clip = clip1;
                source.Play();

            }
            else if (saftsayisi == 1)
            {
                textler[0].SetActive(false);
                textler[1].SetActive(true);
                saftsayisi = 2;
                source.Stop();
                source.clip = clip2;
                source.Play();
            }
            else if (saftsayisi == 2)
            {
                textler[0].SetActive(false);
                textler[1].SetActive(false);
                textler[2].SetActive(true);
                saftsayisi = 3;
                source.Stop();
                source.clip = clip3;
                source.Play();
            }
            else if (saftsayisi == 3)
            {
                textler[0].SetActive(false);
                textler[1].SetActive(false);
                textler[2].SetActive(false);
                textler[3].SetActive(true);
                saftsayisi = 4;
                source.Stop();
                source.clip = clip4;
                source.Play();
            }

            else if (saftsayisi == 4)
            {
                textler[0].SetActive(false);
                textler[1].SetActive(false);
                textler[2].SetActive(false);
                textler[3].SetActive(false);
                textler[4].SetActive(true);
                saftsayisi = 5;
                source.Stop();
                source.clip = clip5;
                source.Play();
            }

            else if (saftsayisi == 5)
            {
                textler[0].SetActive(false);
                textler[1].SetActive(false);
                textler[2].SetActive(false);
                textler[3].SetActive(false);
                textler[4].SetActive(false);
                textler[5].SetActive(true);
                saftsayisi = 6;
                source.Stop();
                source.clip = clip6;
                source.Play();
            }
            else if (saftsayisi == 6)
            {
                textler[0].SetActive(false);
                textler[1].SetActive(false);
                textler[2].SetActive(false);
                textler[3].SetActive(false);
                textler[4].SetActive(false);
                textler[5].SetActive(false);
                textler[6].SetActive(true);
                saftsayisi = 7;

                //textler[x] = 0;
                //for (saftsayisi = x; other.tag == "Player"; x++)
                //{

                //    if (x == )

                //}




            }
        }

       
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            col.SetActive(true);
        }
    }
}

