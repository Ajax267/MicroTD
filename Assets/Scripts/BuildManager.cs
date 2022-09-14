using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;
    private void Awake()
    {
        if (instance != null)
        {
            Debug.Log("Multiple Instances of BuildManager");
            return;
        }
        instance = this;
    }

    public GameObject standartTowerPrefab;

    private void Start()
    {
        towerToBuild = standartTowerPrefab;
    }

    private GameObject towerToBuild;

    public GameObject GetTowerToBuild()
    {
        return towerToBuild;
    } 
}
