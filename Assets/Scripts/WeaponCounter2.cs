using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WeaponCounter2 : MonoBehaviour
{
    public static WeaponCounter2 instance;

    public TMP_Text weaponText;
    public int currentWeapons = 0;

    void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        weaponText.text = "WEAPONS:" + currentWeapons.ToString();
    }

    public void IncreaseWeapons(int v)
    {
        currentWeapons += v;
        weaponText.text = "WEAPONS:" + currentWeapons.ToString();
    }
}
