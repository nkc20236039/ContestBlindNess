using UnityEngine.InputSystem;
using VContainer;

public class KeyConfigConflictService
{
    private IKeyConfigRepository keyConfigRepository;

    [Inject]
    public KeyConfigConflictService(IKeyConfigRepository keyConfigRepository)
    {
        this.keyConfigRepository = keyConfigRepository;
    }

    public void KeyBindCange(RebindActon rebindActon)
    {
        keyConfigRepository.Update();
        var targetBind = keyConfigRepository.Find(rebindActon.ActionName, rebindActon.BindIndex);
        keyConfigRepository.ChangeBind(targetBind);
        //keyConfigRepository.Save();
        keyConfigRepository.Update();
    }

}
