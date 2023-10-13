using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour, IInventory
{
    public int Weapon { get => weapon; set => weapon = value; }


    public int weapon = 0;
}

public class PlayerInventory2 : MonoBehaviour, IInventory2
{
    public int Weapon2 { get => weapon2; set => weapon2 = value; }


    public int weapon2 = 0;
}
