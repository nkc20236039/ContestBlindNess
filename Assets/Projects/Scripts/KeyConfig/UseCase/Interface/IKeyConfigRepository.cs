using UnityEngine.InputSystem;

public interface IKeyConfigRepository 
{
    InputBinding Find(ActionName actionName,BindIndex bindIndex);
    void Remove(ActionName actionName, BindIndex bindIndex);
    void ChangeBind(InputBinding binding);
    void Save(string savePath);
    void Load(string savePath);
    void Setup(string savePath);
    void Defalt(string savePath,string autoSavePath);
    void Disable(AutoSavePath autoSavePath,SavePath savePath);
    void Update();

}
