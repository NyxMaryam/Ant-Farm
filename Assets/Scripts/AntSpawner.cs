using UnityEngine;

public class AntSpawner : MonoBehaviour
{
    public GameObject Runt;

    private void Start()
    {
        foreach(Transform wayPoint in NavmeshManager.Singleton.searchWaypointList)
        {
            if(Random.Range(0, 10) > 5)
            {
                Instantiate(Runt, wayPoint.transform.position, Quaternion.identity);
            }            
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            foreach (Transform wayPoint in NavmeshManager.Singleton.searchWaypointList)
            {
                if (Random.Range(0, 10) > 5)
                {
                    Instantiate(Runt, wayPoint.transform.position, Quaternion.identity);
                }
            }
        }
    }
}
