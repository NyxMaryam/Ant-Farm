using UnityEngine;
using System.Collections.Generic;

public class NavmeshManager : MonoBehaviour
{
    public static NavmeshManager Singleton;
    public List<Transform> searchWaypointList;

    private void Awake()
    {
        Singleton = this;
    }
}
