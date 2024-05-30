using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class llaves : MonoBehaviour
{
    public AudioClip sonido;
    AudioSource reproducirsonido;
    public Text tx;
    public GameObject jd;
    // Start is called before the first frame update
    void Start()
    {
        reproducirsonido=GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other) {
        jd.gameObject.GetComponent<scr_movent>().puntos+=1;
        reproducirsonido.PlayOneShot(sonido);
        Destroy(this.gameObject);
        tx.text=jd.gameObject.GetComponent<scr_movent>().puntos.ToString();

    }
}
