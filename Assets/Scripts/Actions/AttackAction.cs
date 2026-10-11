using UnityEngine;

[CreateAssetMenu (menuName = "EnemyAI/Actions/Attack")]
public class AttackAction : Action
{
    public override void Act(StateController controller)
    {
        Attack(controller);
    }

    private void Attack(StateController controller)
    {
        controller.transform.LookAt(controller.enemy.targetedTransform);
        //controller.transform.rotation = Quaternion.Euler(0, controller.transform.rotation.y, 0);

        RaycastHit _hit;

        Debug.DrawRay(controller.eyes.position, controller.eyes.forward.normalized * 10f, Color.red);

        if(Physics.SphereCast(controller.eyes.position, 2f, controller.eyes.forward, out _hit, 10f) && _hit.collider.CompareTag("Ant"))
        {
            if (controller.CheckIfCountDownElapsed(1f))
            {
                controller.enemy.Attack(controller.enemy.targetedTransform);
            }
        }
    }
}
