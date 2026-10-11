using UnityEngine;
using UnityEngine.AI;

public abstract class Enemy : MonoBehaviour
{
    public int enemy_id;
    public Transform targetedTransform;
    public Vector3 position_of_interest;
    public NavMeshAgent enemyAgent;

    private void Awake()
    {
        enemyAgent = GetComponent<NavMeshAgent>();
    }

    public virtual void Move()
    {
        Debug.LogError("Virtual function 'Move' has not been overidden. No default functionality exists.");
    }

    public virtual void Attack(Transform target)
    {

    }
}
