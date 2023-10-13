using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WeaponCounter : MonoBehaviour
{
    public static WeaponCounter instance;

    public TMP_Text weaponText;
    int currentWeapons = 0;

    public TMP_Text weaponText2;
    int currentWeapons2 = 0;

    void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        weaponText.text = "WEAPONS:" + currentWeapons.ToString();
        weaponText2.text = "WEAPONS:" + currentWeapons2.ToString();
    }

    public void IncreaseWeapons(int v)
    {
        currentWeapons += v;
        weaponText.text = "WEAPONS:" + currentWeapons.ToString();
    }

    public void IncreaseWeapons2(int v)
    {
        currentWeapons2 += v;
        weaponText2.text = "WEAPONS:" + currentWeapons2.ToString();
    }
}
