using UnityEngine;

public class GoalDetect : MonoBehaviour
{

    [HideInInspector]
    public PushAgentBasic agent;

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("goal"))
        {
            agent.ScoredAGoal();
        }
    }
}
