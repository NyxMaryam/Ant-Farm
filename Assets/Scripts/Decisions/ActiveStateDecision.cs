using UnityEngine;

[CreateAssetMenu (menuName = "EnemyAI/Decisions/ActiveState")]
public class ActiveStateDecision : Decision
{
    public override bool Decide(StateController controller)
    {
        bool chaseTargetIsActive = controller.enemy.targetedTransform != null;
        return chaseTargetIsActive;
    }
}
