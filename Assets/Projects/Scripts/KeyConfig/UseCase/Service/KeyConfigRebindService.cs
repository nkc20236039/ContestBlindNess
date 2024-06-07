using VContainer;

public class KeyConfigRebindService
{
    private IKeyConfigRepository keyConfigRepository;

    [Inject]
    public KeyConfigRebindService(IKeyConfigRepository keyConfigRepository)
    {
        this.keyConfigRepository = keyConfigRepository;
    }

    public bool ConflictCheck(RebindActon rebindActon)
    {
        keyConfigRepository.Update();
        keyConfigRepository.Remove(rebindActon.ActionName,rebindActon.BindIndex);
        var findAction = keyConfigRepository.Find(rebindActon.ActionName,rebindActon.BindIndex).effectivePath;
        keyConfigRepository.Update();

        var isConflict = findAction != null;

        //if(!isConflict)
        //{
        //    keyConfigRepository.Save();
        //}
        return isConflict;

    }

}
