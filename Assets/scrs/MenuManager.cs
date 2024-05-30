using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MenuManager : MonoBehaviour
{
    private UIDocument menu;
    private Button empezar;

    private void OnEnable()
    {
        menu = gameObject.GetComponent<UIDocument>();
        VisualElement root = menu.rootVisualElement;
        empezar = root.Q<Button>("empezar");
        empezar.RegisterCallback<ClickEvent>(empezarjuego);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void empezarjuego(ClickEvent evt)
    {
        menu.enabled = false;
    }
}
