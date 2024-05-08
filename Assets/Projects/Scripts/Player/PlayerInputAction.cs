//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Projects/Scripts/Player/PlayerInputAction.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerInputAction: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputAction()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputAction"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""e279baef-6d1e-4966-905f-404086238715"",
            ""actions"": [
                {
                    ""name"": ""OnMove"",
                    ""type"": ""Value"",
                    ""id"": ""19395253-8725-429c-a4ce-cd3bc2f701ee"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""OnDash"",
                    ""type"": ""Value"",
                    ""id"": ""84432ca0-08f5-4d64-899e-06315d528cae"",
                    ""expectedControlType"": ""Key"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""OnMouseMove"",
                    ""type"": ""Value"",
                    ""id"": ""17f5bf1f-8ef0-478e-bca1-e265b420dda8"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""OnEcho"",
                    ""type"": ""Value"",
                    ""id"": ""901b3523-0285-48aa-94b6-17231f01064a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""7e4d6574-f09b-41b7-afa8-0b0cd1206049"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""OnMove"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""277a0278-880b-4072-b4d8-d0e4481582bc"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""OnMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""69763e23-be47-4372-b5a6-01cc6b8a31cd"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""OnMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""38a11d18-2717-47a2-ba4c-2ddcff4c81c3"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""OnMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""db51f73a-9580-46c7-a492-9f55b625bb8b"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""OnMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""0989768c-c320-4731-b9d5-9d94064a8991"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""OnDash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1c1bedde-3437-4897-837a-6c89785d44c6"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""OnMouseMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cdb1f3d9-37eb-49fb-ad01-2519241b8ab4"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""OnEcho"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_OnMove = m_Player.FindAction("OnMove", throwIfNotFound: true);
        m_Player_OnDash = m_Player.FindAction("OnDash", throwIfNotFound: true);
        m_Player_OnMouseMove = m_Player.FindAction("OnMouseMove", throwIfNotFound: true);
        m_Player_OnEcho = m_Player.FindAction("OnEcho", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Player
    private readonly InputActionMap m_Player;
    private List<IPlayerActions> m_PlayerActionsCallbackInterfaces = new List<IPlayerActions>();
    private readonly InputAction m_Player_OnMove;
    private readonly InputAction m_Player_OnDash;
    private readonly InputAction m_Player_OnMouseMove;
    private readonly InputAction m_Player_OnEcho;
    public struct PlayerActions
    {
        private @PlayerInputAction m_Wrapper;
        public PlayerActions(@PlayerInputAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @OnMove => m_Wrapper.m_Player_OnMove;
        public InputAction @OnDash => m_Wrapper.m_Player_OnDash;
        public InputAction @OnMouseMove => m_Wrapper.m_Player_OnMouseMove;
        public InputAction @OnEcho => m_Wrapper.m_Player_OnEcho;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerActionsCallbackInterfaces.Add(instance);
            @OnMove.started += instance.OnOnMove;
            @OnMove.performed += instance.OnOnMove;
            @OnMove.canceled += instance.OnOnMove;
            @OnDash.started += instance.OnOnDash;
            @OnDash.performed += instance.OnOnDash;
            @OnDash.canceled += instance.OnOnDash;
            @OnMouseMove.started += instance.OnOnMouseMove;
            @OnMouseMove.performed += instance.OnOnMouseMove;
            @OnMouseMove.canceled += instance.OnOnMouseMove;
            @OnEcho.started += instance.OnOnEcho;
            @OnEcho.performed += instance.OnOnEcho;
            @OnEcho.canceled += instance.OnOnEcho;
        }

        private void UnregisterCallbacks(IPlayerActions instance)
        {
            @OnMove.started -= instance.OnOnMove;
            @OnMove.performed -= instance.OnOnMove;
            @OnMove.canceled -= instance.OnOnMove;
            @OnDash.started -= instance.OnOnDash;
            @OnDash.performed -= instance.OnOnDash;
            @OnDash.canceled -= instance.OnOnDash;
            @OnMouseMove.started -= instance.OnOnMouseMove;
            @OnMouseMove.performed -= instance.OnOnMouseMove;
            @OnMouseMove.canceled -= instance.OnOnMouseMove;
            @OnEcho.started -= instance.OnOnEcho;
            @OnEcho.performed -= instance.OnOnEcho;
            @OnEcho.canceled -= instance.OnOnEcho;
        }

        public void RemoveCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    public interface IPlayerActions
    {
        void OnOnMove(InputAction.CallbackContext context);
        void OnOnDash(InputAction.CallbackContext context);
        void OnOnMouseMove(InputAction.CallbackContext context);
        void OnOnEcho(InputAction.CallbackContext context);
    }
}
