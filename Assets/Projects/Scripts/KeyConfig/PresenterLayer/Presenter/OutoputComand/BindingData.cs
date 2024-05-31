public class BindingData
{
    public ActionName InputActionName { get; }
    public BindIndex InputBindIndex { get; }
    public bool IsConflict { get; }

    public BindingData(bool isConflict, ActionName actionName = null, BindIndex bindIndex = null)
    {
        IsConflict = isConflict;
        InputActionName = actionName;
        InputBindIndex = bindIndex;
    }

}
