﻿using UnityEngine;
using System.Collections;

public class FoodPickUp : MonoBehaviour {

    private Teacher.ResourceController ResourceController;
    public int AmountOfFood = 10;

    void Awake()
    {
        ResourceController = GameObject.Find("ResourceController").GetComponent<Teacher.ResourceController>();
    }

	void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player") // if the hitting object has a player tag
        {
            ResourceController.Food += AmountOfFood; // Add wood to resourcecontroller
            Destroy(gameObject);  // Destroy itself after it has been picked up
        }
    }
}
