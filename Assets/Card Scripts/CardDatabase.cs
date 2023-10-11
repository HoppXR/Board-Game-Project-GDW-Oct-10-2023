using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDatabase : MonoBehaviour
{

    public static List<Card> cardList = new List<Card>();

    void Awake()
    {
        cardList.Add(new Card(0, "None", 0, 0, "None"));
        cardList.Add(new Card(1, "CardName", 2, 1000, "CardDescription"));
        cardList.Add(new Card(2, "CardName", 2, 1000, "CardDescription"));
        cardList.Add(new Card(3, "CardName", 2, 1000, "CardDescription"));
        cardList.Add(new Card(4, "CardName", 2, 1000, "CardDescription"));
        cardList.Add(new Card(5, "CardName", 2, 1000, "CardDescription"));
        cardList.Add(new Card(6, "CardName", 2, 1000, "CardDescription"));
        cardList.Add(new Card(7, "CardName", 2, 1000, "CardDescription"));
        cardList.Add(new Card(8, "CardName", 2, 1000, "CardDescription"));
        cardList.Add(new Card(9, "CardName", 2, 1000, "CardDescription"));
        cardList.Add(new Card(10, "CardName", 2, 1000, "CardDescription"));
        cardList.Add(new Card(11, "CardName", 2, 1000, "CardDescription"));
        cardList.Add(new Card(12, "CardName", 2, 1000, "CardDescription"));
        cardList.Add(new Card(13, "CardName", 2, 1000, "CardDescription"));
        cardList.Add(new Card(14, "CardName", 2, 1000, "CardDescription"));
        cardList.Add(new Card(15, "CardName", 2, 1000, "CardDescription"));
        cardList.Add(new Card(16, "CardName", 2, 1000, "CardDescription"));
        cardList.Add(new Card(17, "CardName", 2, 1000, "CardDescription"));
        cardList.Add(new Card(18, "CardName", 2, 1000, "CardDescription"));
        cardList.Add(new Card(19, "CardName", 2, 1000, "CardDescription"));
        cardList.Add(new Card(20, "CardName", 2, 1000, "CardDescription"));
        cardList.Add(new Card(21, "CardName", 2, 1000, "CardDescription"));
        cardList.Add(new Card(22, "CardName", 2, 1000, "CardDescription"));
        cardList.Add(new Card(23, "CardName", 2, 1000, "CardDescription"));
        cardList.Add(new Card(24, "CardName", 2, 1000, "CardDescription"));
        cardList.Add(new Card(25, "CardName", 2, 1000, "CardDescription"));
        cardList.Add(new Card(26, "CardName", 2, 1000, "CardDescription"));



    }
}
