using UnityEngine;

public class AnimRandom : StateMachineBehaviour
{
    //OnStateMachineEnter is called when entering a state machine via its Entry Node
    override public void OnStateMachineEnter(Animator animator, int stateMachinePathHash)
    {
        animator.SetInteger("AnimID", Random.Range(0, 3));
    }
}
