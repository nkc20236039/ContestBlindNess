using UnityEngine.InputSystem;

public class OutputData
{
    public DisableData DisableData { get; }
    public BindingData BindingData { get; }

    public OutputData(DisableData disableData)
    {
        DisableData = disableData;
    }

    public OutputData(BindingData bindingData)
    {
        BindingData = bindingData;
    }

}
