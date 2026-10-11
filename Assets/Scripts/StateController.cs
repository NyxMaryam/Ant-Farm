using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem.XR;

public class StateController : MonoBehaviour
{
    public State currentState;
    public State remainState;
    public NavMeshAgent navMeshAgent;
    public Transform eyes;
    public Enemy enemy;

    public float stateTimeElapsed = 0f;

    private void Update()
    {
        currentState.UpdateState(this);
    }

    private void OnDrawGizmos()
    {
        if(currentState != null)
        {
            Gizmos.color = currentState.sceneGizmoColor;
            Gizmos.DrawWireSphere(transform.position, 2f);
        }
    }

    public void TransitionToState(State nextState)
    {
        if(nextState != remainState)
        {
            currentState = nextState;
            OnExitState();
        }
    }

    public bool CheckIfCountDownElapsed(float duration)
    {
        stateTimeElapsed += Time.deltaTime;
        if(stateTimeElapsed >= duration)
        {
            stateTimeElapsed = 0f;
            return true;
        }
        else
        {
            return false;
        }
    }

    private void OnExitState()
    {
        stateTimeElapsed = 0f;
        navMeshAgent.isStopped = false;
    }
}
