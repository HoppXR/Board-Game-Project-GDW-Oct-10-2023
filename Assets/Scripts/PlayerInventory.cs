using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour, IInventory
{
    public int Weapon { get => weapon; set => weapon = value; }


    public int weapon = 0;
}
