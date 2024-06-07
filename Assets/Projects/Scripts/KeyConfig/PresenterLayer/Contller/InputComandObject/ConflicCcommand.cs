public class ConflicCcommand
{
    public string ConflictName { get; }
    public int BindingIndex { get; }

    public ConflicCcommand(string conflictName,int BindingIndex)
    {
        this.ConflictName = conflictName;
        this.BindingIndex = BindingIndex;
    }
}
