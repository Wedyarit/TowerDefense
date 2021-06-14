using UnityEngine;

public class Shop : MonoBehaviour
{

    public TowerBlueprint crystallizer;
    public TowerBlueprint crystalVat;
    public TowerBlueprint crystalTesla;

    public void SelectCrystallizer()
    {
        Debug.Log("Tower 'Crystallizer' selected!");
        BuildManager.instance.SelectTowerToBuild(crystallizer);
    }

    public void SelectCrystalVat()
    {
        Debug.Log("Tower 'Crystal Vat' selected!");
        BuildManager.instance.SelectTowerToBuild(crystalVat);
    }

    public void SelectCrystalTesla()
    {
        Debug.Log("Tower 'Crystal Tesla' selected!");
        BuildManager.instance.SelectTowerToBuild(crystalTesla);
    }
}
