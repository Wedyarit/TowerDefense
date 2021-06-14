using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;

    void Awake()
    {
        instance = this;
    }

    public GameObject TowerCrystallizerPrefab;
    public GameObject TowerVatPrefab;
    public GameObject TowerTeslaPrefab;

    public GameObject buildEffect;


    private TowerBlueprint towerToBuild;

    public bool CanBuild { get { return towerToBuild != null; } }
    public bool HasCrystals { get { return PlayerStats.Crystals >= towerToBuild.cost; } }

    public void SelectTowerToBuild(TowerBlueprint tower)
    {
        towerToBuild = tower;
    }

    public void BuildTowerOn(Node node)
    {
        if (PlayerStats.Crystals < towerToBuild.cost)
        {
            Debug.Log("Not enough crystals to build that!");
            return;
        }
        PlayerStats.Crystals -= towerToBuild.cost;
        node.tower = (GameObject)Instantiate(towerToBuild.prefab, new Vector3(node.transform.position.x, 1.2f, node.transform.position.z), new Quaternion(-1f, node.transform.rotation.y, node.transform.rotation.z, node.transform.rotation.w));
        Debug.Log("Tower built! Crystals left: " + PlayerStats.Crystals);

        GameObject effect = (GameObject)Instantiate(buildEffect, new Vector3(node.transform.position.x, 1.2f, node.transform.position.z), new Quaternion(-1f, node.transform.rotation.y, node.transform.rotation.z, node.transform.rotation.w));
        Destroy(effect, 5f);
    }

}
