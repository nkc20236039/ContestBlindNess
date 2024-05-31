using System.Linq;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

[CustomEditor(typeof(KeyConfig))]
public class KeyConfigEditor : Editor
{
    private GUIContent BindingLabel = new GUIContent("Binding");
    private SerializedProperty bindingIdProperty;
    private SerializedProperty binding;
    private SerializedProperty mask;
    private SerializedProperty bindingType;
    private GUIContent[] bindingOptions;
    private string[] bindingOptionValues;
    private int selectedBindingOption;

    protected void OnEnable()
    {
        binding = serializedObject.FindProperty("actionRef");
        bindingIdProperty = serializedObject.FindProperty("bindId");
        mask = serializedObject.FindProperty("maskPrefab");
        bindingType = serializedObject.FindProperty("bindType");
        SetUp();
    }
    public override void OnInspectorGUI()
    {
        EditorGUILayout.LabelField("Test");//�v���p�e�B��ҏW���܂��B
        EditorGUI.BeginChangeCheck();


        using (new EditorGUI.IndentLevelScope())
        {
            EditorGUILayout.PropertyField(binding);
            EditorGUILayout.PropertyField(mask);
            EditorGUILayout.PropertyField (bindingType);
            // �h���b�v�_�E�����j���[��\�����A�I�����ꂽ�C���f�b�N�X���擾����
            var newSelectedBinding = EditorGUILayout.Popup(BindingLabel, selectedBindingOption, bindingOptions);

            if (newSelectedBinding != selectedBindingOption)
            {
                var bindingId = bindingOptionValues[newSelectedBinding];
                bindingIdProperty.stringValue = bindingId;
                selectedBindingOption = newSelectedBinding;
            }
        }
        if (EditorGUI.EndChangeCheck())
        {
            serializedObject.ApplyModifiedProperties();
            SetUp();
        }
    }

    public void SetUp()
    {
        var actionReference = (InputActionReference)binding.objectReferenceValue;
        var action = actionReference?.action;

        if (action == null)
        {
            bindingOptions = new GUIContent[0];
            bindingOptionValues = new string[0];
            selectedBindingOption = -1;
            return;
        }

        var bindings = action.bindings;
        var bindingCount = bindings.Count;

        bindingOptions = new GUIContent[bindingCount];
        bindingOptionValues = new string[bindingCount];
        selectedBindingOption = -1;

        var currentBindingId = bindingIdProperty.stringValue;
        for (var i = 0; i < bindingCount; ++i)
        {
            var binding = bindings[i];
            var bindingId = binding.id.ToString();
            var haveBindingGroups = !string.IsNullOrEmpty(binding.groups);

            var displayOptions =
                InputBinding.DisplayStringOptions.DontUseShortDisplayNames | InputBinding.DisplayStringOptions.IgnoreBindingOverrides;
            if (!haveBindingGroups)
                displayOptions |= InputBinding.DisplayStringOptions.DontOmitDevice;

            var displayString = action.GetBindingDisplayString(i, displayOptions);

            if (binding.isPartOfComposite)
                displayString = $"{ObjectNames.NicifyVariableName(binding.name)}: {displayString}";

            displayString = displayString.Replace('/', '\\');

            if (haveBindingGroups)
            {
                var asset = action.actionMap?.asset;
                if (asset != null)
                {
                    var controlSchemes = string.Join(", ",
                        binding.groups.Split(InputBinding.Separator)
                            .Select(x => asset.controlSchemes.FirstOrDefault(c => c.bindingGroup == x).name));

                    displayString = $"{displayString} ({controlSchemes})";
                }
            }

            bindingOptions[i] = new GUIContent(displayString);
            bindingOptionValues[i] = bindingId;

            if (currentBindingId == bindingId)
                selectedBindingOption = i;

        }

    }
}
