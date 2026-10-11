using UnityEngine;

[CreateAssetMenu (menuName = "EnemyAI/Decisions/Look")]
public class LookDecision : Decision
{
    public override bool Decide(StateController controller)
    {
        bool targetVisible = Look(controller);
        return targetVisible;
    }

    private bool Look(StateController controller)
    {
        RaycastHit _hit;

        Debug.DrawRay(controller.eyes.position, controller.eyes.forward.normalized * 40f, Color.red);

        if(Physics.SphereCast(controller.eyes.position, 2f, controller.eyes.forward, out _hit, 40f) && _hit.collider.CompareTag("Ant"))
        {
            controller.enemy.targetedTransform = _hit.transform;
            return true;
        }
        else
        {
            return false;
        }
    }
}
