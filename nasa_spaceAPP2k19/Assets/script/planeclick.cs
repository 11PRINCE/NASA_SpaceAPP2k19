﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class planeclick : MonoBehaviour
{

    public GameObject definedButton;
    public UnityEvent OnClick = new UnityEvent();

    // Use this for initialization
    void Start()
    {
        definedButton = this.gameObject;
        //it defines the button
    }

    // Update is called once per frame
    void Update()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit Hit;

        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, out Hit) && Hit.collider.gameObject == gameObject)
            {
                Debug.Log("Button Clicked");
                OnClick.Invoke();
                //button function
            }
        }
    }
}
