public class RebindActon
{
    public ActionName ActionName { get; }
    public BindIndex BindIndex { get; }

    public RebindActon(ActionName actionName, BindIndex bindIndex)
    {
        ActionName = actionName;
        BindIndex = bindIndex;
    }

}
