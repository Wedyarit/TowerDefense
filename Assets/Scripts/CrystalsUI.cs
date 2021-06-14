using UnityEngine;
using UnityEngine.UI;

public class CrystalsUI : MonoBehaviour
{
    public Text crystalsText;

    void Update()
    {
        crystalsText.text = "\t" + PlayerStats.Crystals;
    }
}
