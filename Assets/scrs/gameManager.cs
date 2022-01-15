using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  UnityEngine.UI;
enum estado{
 Enjuego,
 Enpausa
}

public class gameManager : MonoBehaviour
{
    public AudioSource au,ua;
    public Canvas pause, juego;

    private void Awake()
    {
        ua.mute = true;
        au.mute = false;
        juego.GetComponent<Canvas>().enabled = false;
        pause.GetComponent<Canvas>().enabled = true;
        
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }

    public void jugar()
    {
        ua.mute = false;
        au.mute = true;
        juego.GetComponent<Canvas>().enabled = true;
        pause.GetComponent<Canvas>().enabled = false;
    }

    public void pausar()
    {
        ua.mute = true;
        au.mute = false;
        juego.GetComponent<Canvas>().enabled = false;
        pause.GetComponent<Canvas>().enabled = true;
    }

}
