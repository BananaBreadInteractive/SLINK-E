// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Input/Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""fec58260-8d6f-4250-94de-a1b1f7254dc4"",
            ""actions"": [
                {
                    ""name"": ""Arms"",
                    ""type"": ""Button"",
                    ""id"": ""227e2465-323b-4b7a-92a2-ae9090ba0278"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LeftHand"",
                    ""type"": ""Button"",
                    ""id"": ""55fa4a18-3cbd-41a1-ba8d-8cb407901b1f"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightHand"",
                    ""type"": ""Button"",
                    ""id"": ""3079e346-200c-4605-9f34-3eae08dd3fcd"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""d1fbfca4-48b4-45be-90d8-f0a326a7997d"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Arms"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5ea035a0-5116-4d1b-819b-63c1a378021c"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftHand"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""396716ab-5b75-4e9e-bf77-663bda99d46f"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightHand"",
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
        m_Player_Arms = m_Player.FindAction("Arms", throwIfNotFound: true);
        m_Player_LeftHand = m_Player.FindAction("LeftHand", throwIfNotFound: true);
        m_Player_RightHand = m_Player.FindAction("RightHand", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Arms;
    private readonly InputAction m_Player_LeftHand;
    private readonly InputAction m_Player_RightHand;
    public struct PlayerActions
    {
        private @Controls m_Wrapper;
        public PlayerActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Arms => m_Wrapper.m_Player_Arms;
        public InputAction @LeftHand => m_Wrapper.m_Player_LeftHand;
        public InputAction @RightHand => m_Wrapper.m_Player_RightHand;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Arms.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnArms;
                @Arms.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnArms;
                @Arms.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnArms;
                @LeftHand.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLeftHand;
                @LeftHand.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLeftHand;
                @LeftHand.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLeftHand;
                @RightHand.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRightHand;
                @RightHand.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRightHand;
                @RightHand.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRightHand;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Arms.started += instance.OnArms;
                @Arms.performed += instance.OnArms;
                @Arms.canceled += instance.OnArms;
                @LeftHand.started += instance.OnLeftHand;
                @LeftHand.performed += instance.OnLeftHand;
                @LeftHand.canceled += instance.OnLeftHand;
                @RightHand.started += instance.OnRightHand;
                @RightHand.performed += instance.OnRightHand;
                @RightHand.canceled += instance.OnRightHand;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    public interface IPlayerActions
    {
        void OnArms(InputAction.CallbackContext context);
        void OnLeftHand(InputAction.CallbackContext context);
        void OnRightHand(InputAction.CallbackContext context);
    }
}
