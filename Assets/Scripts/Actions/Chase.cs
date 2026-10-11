using UnityEngine;

[CreateAssetMenu (menuName = "EnemyAI/Actions/Chase")]
public class Chase : Action
{
    public override void Act(StateController controller)
    {
        ChaseTarget(controller);
    }
    
    private void ChaseTarget(StateController controller)
    {
        if(controller.enemy.targetedTransform != null)
        {
            controller.navMeshAgent.SetDestination(controller.enemy.targetedTransform.position);
            if(Vector3.Distance(controller.transform.position, controller.enemy.targetedTransform.position) > 10f)
            {
                controller.navMeshAgent.isStopped = false;
            }
            else
            {
                controller.navMeshAgent.isStopped = true;
            }
        }
    }
}
