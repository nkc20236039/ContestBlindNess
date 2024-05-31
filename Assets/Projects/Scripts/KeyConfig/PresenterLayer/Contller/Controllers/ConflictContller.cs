using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ConflictContller : MonoBehaviour
{
    private MainController controller;
    [SerializeField]
    private Button cancelButton;
    [SerializeField]
    private Button conflictButton;

    private void Start()
    {
        controller = GetComponentInParent<MainController>();
    }

    public void ButtonSetting(BindingData bindingData)
    {
        conflictButton.onClick.RemoveAllListeners();
        cancelButton.onClick.RemoveAllListeners();

        conflictButton.onClick.AddListener(() => Conflict(bindingData));
        cancelButton.onClick.AddListener(Cancel);
    }

    private void Cancel()
    {
        var autoCommand = new AutoSavePath();
        var canselCommand = new CancelCommand(autoCommand);
        var inputAction = new InputData(canselCommand,new SaveCommand(autoCommand));
        controller.InputContller(inputAction);
        this.gameObject.SetActive(false);
    }

    private void Conflict(BindingData bindingData)
    {
        var conflictCommand = new ConflicCcommand(bindingData.InputActionName.Vaule, bindingData.InputBindIndex.Vaule);
        var autoSaveCommand = new AutoSavePath();
        var inputAction = new InputData(conflictCommand,new SaveCommand(autoSaveCommand));
        controller.InputContller(inputAction);
        this.gameObject.SetActive(false);
    }
    private void OnDisable()
    {
        conflictButton.onClick.RemoveAllListeners();
        cancelButton.onClick.RemoveAllListeners();
    }

}
