using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VContainer;

public class KeyConfigDisableService
{
    public IKeyConfigRepository keyConfigRepository;

    [Inject]
    public KeyConfigDisableService(IKeyConfigRepository keyConfigRepository)
    {
        this.keyConfigRepository = keyConfigRepository;
    }

    public void Disable(DisableComand disableComand)
    {

        keyConfigRepository.Disable(disableComand.AutoSavePath,disableComand.SavePath);
    }

}
