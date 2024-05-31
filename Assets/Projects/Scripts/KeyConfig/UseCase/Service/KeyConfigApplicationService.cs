using UnityEngine;
using VContainer;

public class KeyConfigApplicationService : IInputAction
{

    private KeyConfigRebindService rebindService;
    private KeyConfigConflictService conflictService;
    private KeyConfigCancelService cancelService;
    private KeyConfigSaveService saveService;
    private KeyConfigSetupService setupService;
    private KeyConfigDefaultService defaultService;
    private KeyConfigDisableService disableService;
    private IOutPutAction outPutAction;

    [Inject]
    public KeyConfigApplicationService(KeyConfigRebindService keyConfigConflictService
        , IOutPutAction outPutAction, KeyConfigConflictService conflictService
        , KeyConfigCancelService cancelService, KeyConfigSaveService keyConfigSaveService
        , KeyConfigSetupService setupService, KeyConfigDefaultService defaultService
        , KeyConfigDisableService disableService)
    {
        this.rebindService = keyConfigConflictService;
        this.outPutAction = outPutAction;
        this.conflictService = conflictService;
        this.cancelService = cancelService;
        this.saveService = keyConfigSaveService;
        this.setupService = setupService;
        this.defaultService = defaultService;
        this.disableService = disableService;
    }

    public void BindingAction(InputData inputData)
    {
        if (inputData.SetupComand != null)
        {
            setupService.Setup(inputData.SetupComand);
            var bindingData = new BindingData(false);
            var outputData = new OutputData(bindingData);
            outPutAction.Output(outputData);
        }

        if (inputData.CancelCommand != null)
        {
            cancelService.CancelBind(inputData.CancelCommand.autoSavePath);
            var bindingData = new BindingData(false);
            var outputData = new OutputData(bindingData);
            outPutAction.Output(outputData);
        }

        if (inputData.ConflicCcommand != null)
        {
            var conflictComand = inputData.ConflicCcommand;
            var actionName = new ActionName(conflictComand.ConflictName);
            var bindIndex = new BindIndex(conflictComand.BindingIndex);
            var rebindAction = new RebindActon(actionName, bindIndex);
            conflictService.KeyBindCange(rebindAction);
            var bindingData = new BindingData(false);
            var outputData = new OutputData(bindingData);
            outPutAction.Output(outputData);
        }

        if (inputData.RebindingCommand != null)
        {
            var rebindComand = inputData.RebindingCommand;
            var actionName = new ActionName(rebindComand.ActionName);
            var bindIndex = new BindIndex(rebindComand.BindIndex);
            var rebindAction = new RebindActon(actionName, bindIndex);

            var isConflict = rebindService.ConflictCheck(rebindAction);
            var bindingData = new BindingData(isConflict, actionName, bindIndex);
            var outputData = new OutputData(bindingData);
            outPutAction.Output(outputData);
            if (isConflict) { return; }

        }

        if (inputData.SaveCommand != null)
        {
            saveService.SaveSystem(inputData.SaveCommand);
        }

        if(inputData.DefaltCommand != null)
        {
            defaultService.Defalt(inputData.DefaltCommand);
            var bindingData = new BindingData(false);
            var outputData = new OutputData(bindingData);
            outPutAction.Output(outputData);
        }

        if(inputData.DisableComand != null)
        {
            disableService.Disable(inputData.DisableComand);
            var DisableData = new DisableData();
            var outputData = new OutputData(DisableData);
            outPutAction.Output(outputData);
        }
    }
}
