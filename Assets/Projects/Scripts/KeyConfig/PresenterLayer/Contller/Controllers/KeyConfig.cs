using UnityEngine;
using UnityEngine.InputSystem;

public class KeyConfig : MonoBehaviour
{

    private enum BindingType
    {
        Gamepad,
        Keyboard
    }

    [SerializeField]
    private InputActionReference actionRef;

    [SerializeField]
    private string bindId;

    [SerializeField]
    private GameObject maskPrefab;

    [SerializeField]
    private BindingType bindType;

    private MainController mainController;
    private InputAction action;
    private InputActionRebindingExtensions.RebindingOperation rebindOperation;

    private void Awake()
    {
        if (actionRef == null) { return; }
        mainController = GetComponentInParent<MainController>();
        action = actionRef.action;
    }

    private void OnDestroy()
    {
        CleanUpOperation();
    }

    public void StartRebinding()
    {
        if (action == null) { return; }
        rebindOperation?.Cancel();
        action.Disable();
        var bindingIndex = action.bindings.IndexOf(x => x.id.ToString() == bindId);

        if (maskPrefab != null)
        {
            maskPrefab.SetActive(true);
        }

        void OnFinished()
        {
            CleanUpOperation();
            action.Enable();
            if (maskPrefab != null)
            {
                maskPrefab.SetActive(false);
            }
        }



        rebindOperation = action
            .PerformInteractiveRebinding(bindingIndex)
            .OnComplete(rebindOperation =>
            {
                var rebindComand = new RebindingCommand(rebindOperation.action.name, bindingIndex);
                var autoSavePath = new AutoSavePath();
                var inputData = new InputData(rebindComand, new SaveCommand(autoSavePath));
                mainController.InputContller(inputData);
                OnFinished();
            })
            .OnCancel(_ =>
            {
                OnFinished();
            })
            .WithControlsHavingToMatchPath(bindType.ToString())
            .WithCancelingThrough("<Keyboard>/escape")
            .Start();
    }

    private void CleanUpOperation()
    {
        rebindOperation?.Dispose();
        rebindOperation = null;
    }

    public string GetBindingId() => bindId;
    public InputAction GetAction() => action;

}