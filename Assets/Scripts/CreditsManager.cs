using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsManager : MonoBehaviour
{
    GameObject Credits;

    void Start()
    {
        Credits = GameObject.FindGameObjectWithTag("Credits");
        Credits.SetActive(false);
    }

    public void ToggleActive(bool State)
    {
        Credits.SetActive(State);
    }
}