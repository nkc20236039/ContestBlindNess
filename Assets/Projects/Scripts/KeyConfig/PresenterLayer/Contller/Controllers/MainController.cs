using UnityEngine;
using UnityEngine.InputSystem;
using VContainer;

public class MainController : MonoBehaviour
{
    private IInputAction inputAction;

    [Inject]
    public void Injction(IInputAction action)
    {
        inputAction = action;
    }

    public void InputContller(InputData inputData)
    {
        inputAction.BindingAction(inputData);
    }

}
