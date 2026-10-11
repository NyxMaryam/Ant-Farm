using UnityEngine;

[CreateAssetMenu (menuName = "EnemyAI/Actions/SearchForFood")]
public class SearchForFoodAction : Action
{
    public override void Act(StateController controller)
    {
        SearchForFood(controller);
    }

    private void SearchForFood(StateController controller)
    {
        if(Vector3.Distance(controller.transform.position, controller.navMeshAgent.destination) < 2f)
        {

            controller.navMeshAgent.SetDestination(NavmeshManager.Singleton.searchWaypointList[Random.Range(0, 16)].position);
        }
        
    }
}
