using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VContainer;

public class KeyConfigSetupService
{
    private IKeyConfigRepository keyConfigRepository;

    [Inject]
    public KeyConfigSetupService(IKeyConfigRepository keyConfigRepository)
    {
        this.keyConfigRepository = keyConfigRepository;
    }

    public void Setup(SetupCmmand setupComand)
    {
        keyConfigRepository.Setup(setupComand.SavePath.Value);
    }

}
