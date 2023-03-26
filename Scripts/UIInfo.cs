using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIInfo : MonoBehaviour
{
    public PlayerHealth playerinfo;
    public TextMeshProUGUI health;


    private void Update()
    {

        health.text = playerinfo.health.ToString();


    }
}
