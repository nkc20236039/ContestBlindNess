using UnityEngine;
using UnityEngine.SceneManagement;

[ExecuteInEditMode]
public class TemplateWarning : MonoBehaviour
{
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "_TemplateScene")
        {
            Debug.LogError("�e���v���[�g�V�[���G��ȁI�I�I�I");
        }
        else
        {
            DestroyImmediate(gameObject);
        }
    }
}