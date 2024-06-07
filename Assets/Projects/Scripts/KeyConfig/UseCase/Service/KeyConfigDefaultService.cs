using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyConfigDefaultService
{
    private IKeyConfigRepository keyConfigRepository;

    public KeyConfigDefaultService(IKeyConfigRepository keyConfigRepository)
    {
        this.keyConfigRepository = keyConfigRepository;
    }

    public void Defalt(DefaltCommand defaltCommand)
    {
        keyConfigRepository.Defalt(defaltCommand.SavePath.Value, defaltCommand.AutoSavePath.Value);
        keyConfigRepository.Update();
    }

}
