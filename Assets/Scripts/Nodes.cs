using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nodes : MonoBehaviour
{

    public Color hoverColor;
    public Vector3 positionOffset;
    private GameObject tower;

    private Renderer rend;
    private Color startColor;
    
    void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
    }
    private void OnMouseEnter()
    {
        rend.material.color = hoverColor;
    }

    private void OnMouseExit()
    {
        rend.material.color = startColor;
    }

    private void OnMouseDown()
    {
        if(tower != null)
        {
            Debug.Log("I can't build here");
            return;
        }
        GameObject towerToBuild = BuildManager.instance.GetTowerToBuild();
        tower = (GameObject)Instantiate(towerToBuild, transform.position + positionOffset, transform.rotation);
    }


}
