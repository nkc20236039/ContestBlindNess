using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyConfigSaveService
{
    IKeyConfigRepository keyConfigRepository;

    public KeyConfigSaveService(IKeyConfigRepository keyConfigRepository)
    {
        this.keyConfigRepository = keyConfigRepository;
    }

    public void SaveSystem(SaveCommand saveCommand)
    {

        if(saveCommand.SavePath != null)
        {
            keyConfigRepository.Save(saveCommand.SavePath.Value);
        }
        else if(saveCommand.AutoSavePath != null)
        {
            keyConfigRepository.Save(saveCommand.AutoSavePath.Value);
        }
    }

}
