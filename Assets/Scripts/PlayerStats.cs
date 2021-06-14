using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public static int Crystals;
    public int startCrystals = 300;

    void Start()
    {
        Crystals = startCrystals;
    }
}
