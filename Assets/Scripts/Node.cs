using UnityEngine;
using UnityEngine.EventSystems;

public class Node : MonoBehaviour
{
    public Color hoverColor;

    [Header("Optional")]
    public GameObject tower;
    private Color defaultColor;
    public Color notEnoughCrystalsColor;
    private Renderer _renderer;

    void OnMouseDown()
    {
        if (EventSystem.current.IsPointerOverGameObject())
            return;

        if (!BuildManager.instance.CanBuild)
            return;

        if (tower != null)
        {
            Debug.Log("NO SPACE. TODO: UI");
            return;
        }

        BuildManager.instance.BuildTowerOn(this);
    }

    void Start()
    {
        _renderer = GetComponent<Renderer>();
        defaultColor = _renderer.material.color;
    }

    void OnMouseEnter()
    {
        if (EventSystem.current.IsPointerOverGameObject())
            return;
        if (!BuildManager.instance.CanBuild)
            return;
        if (BuildManager.instance.HasCrystals)
            _renderer.material.color = hoverColor;
        else
            _renderer.material.color = notEnoughCrystalsColor;
    }

    void OnMouseExit()
    {
        _renderer.material.color = defaultColor;
    }
}
