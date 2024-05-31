using UnityEngine.InputSystem;

public class InputData
{
    public ConflicCcommand ConflicCcommand { get; }
    public CancelCommand CancelCommand { get; }
    public RebindingCommand RebindingCommand { get; }
    public SaveCommand SaveCommand { get; }
    public SetupCmmand SetupComand { get; }
    public DefaltCommand DefaltCommand { get; }
    public DisableComand DisableComand { get; }

    public InputData(ConflicCcommand conflicCcommand,SaveCommand saveCommand = null)
    {
        ConflicCcommand = conflicCcommand;
        SaveCommand = saveCommand;
    }
    public InputData(CancelCommand cancelCommand,SaveCommand saveCommand = null)
    {
        CancelCommand = cancelCommand;
        SaveCommand = saveCommand;
    }
    public InputData(RebindingCommand rebindingCommand, SaveCommand saveCommand = null)
    {
        RebindingCommand = rebindingCommand;
        SaveCommand = saveCommand;
    }
    public InputData(SaveCommand saveCommand)
    {
        SaveCommand = saveCommand;
    }
    public InputData(SetupCmmand setupComand)
    {
        SetupComand = setupComand;
    }
    public InputData(DefaltCommand defaltCommand)
    {
        DefaltCommand = defaltCommand;
    }

    public InputData(DisableComand disableComand)
    {
        DisableComand = disableComand;
    }

}
