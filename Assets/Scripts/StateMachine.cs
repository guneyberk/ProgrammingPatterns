using System;
using UnityEngine;

[Serializable]
public class StateMachine : MonoBehaviour
{


    public IState currentState { get; private set; }

    public WalkState walkState;
    public JumpState jumpState;
    public IdleState idleState;

    public StateMachine(PlayerControllerState playerController)
    {
        this.walkState = new WalkState(playerController);
        this.jumpState = new JumpState(playerController);
        this.idleState = new IdleState(playerController);
    }

    public void Initialize(IState startingState)
    {
        currentState = startingState;
        startingState.Enter();

    }

    public void TransitionTo(IState nextState)
    {
        currentState.Exit();
        currentState = nextState;
        nextState.Enter();
    }

    public void Update()
    {
        if (currentState != null)
        {
            currentState.Update();
        }
    }

}

public enum PlayerControllerState
{
    Idle,
    Walk,
    Jump
}
