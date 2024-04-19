using UnityEngine;
using UnityEngine.SceneManagement;

[ExecuteInEditMode]
public class TemplateWarning : MonoBehaviour
{
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "_TemplateScene")
        {
            Debug.LogError("テンプレートシーン触るな！！！！");
        }
        else
        {
            DestroyImmediate(gameObject);
        }
    }
}