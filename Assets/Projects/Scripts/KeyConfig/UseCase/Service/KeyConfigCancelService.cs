using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using VContainer;

public class KeyConfigCancelService
{
    private IKeyConfigRepository configRepository;

    [Inject]
    public KeyConfigCancelService(IKeyConfigRepository configRepository)
    {
        this.configRepository = configRepository;
    }

    public void CancelBind(AutoSavePath autoSavePath)
    {
        configRepository.Load(autoSavePath.Value);  
        configRepository.Update();
    }

}
