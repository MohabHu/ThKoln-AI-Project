using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIInfoArmor : MonoBehaviour
{
    public PlayerHealth playerinfo;
    public TextMeshProUGUI armor;


    private void Update()
    {

        armor.text = playerinfo.armor.ToString();


    }
}
