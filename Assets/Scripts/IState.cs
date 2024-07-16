public interface IState
{
    public void Enter()
    {
        //This logic executes when first entering the state
    }
    public void Update()
    {
        //Update This logic runs every frame You can further segment the update method as MoonoBehavior does
        //Any functionality in the Update runs each frame until condition is detected that triggers a state change
    }
    public void Exit()
    {
        //Leaving the state and transitioning to a new state
    }

}

public class IdleState: IState
{
    private PlayerControllerState _state;
    public IdleState(PlayerControllerState playerControllerState) 
    {
        this._state = playerControllerState;
    }

    public void Enter()
    {
        //code that runs when we first enter the state
    }

    public void Update()
    {
        //Here we add logic to detec if the conditions exits to transition to another state
    }

    public void Exit()
    {
        //code that runs when we exit the state
    }

}

public class WalkState : IState
{

}

public class JumpState : IState
{

}
