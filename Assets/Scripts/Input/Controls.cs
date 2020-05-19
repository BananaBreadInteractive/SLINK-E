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
                },
                {
                    ""name"": ""DPadUp"",
                    ""type"": ""Button"",
                    ""id"": ""65b4d726-a855-4d12-897a-b34191fa50dd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DPadDown"",
                    ""type"": ""Button"",
                    ""id"": ""457f3be9-b5a1-4755-95a6-c7c10b101ca0"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Select"",
                    ""type"": ""Button"",
                    ""id"": ""0393e654-dc36-4bd3-ae0e-7980a5b0c2e8"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""B"",
                    ""type"": ""Button"",
                    ""id"": ""fbbb7ef4-436e-48de-ab2d-9bf43b444da2"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""D-PadLeft"",
                    ""type"": ""Button"",
                    ""id"": ""78b1335b-3124-4677-b9b4-cdb6958602d2"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""D-PadRight"",
                    ""type"": ""Button"",
                    ""id"": ""faa66043-26f8-4ef8-9215-a8cebb8b0572"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Y"",
                    ""type"": ""Button"",
                    ""id"": ""74b550e4-349e-4039-8d77-c7225722be0b"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Start"",
                    ""type"": ""Button"",
                    ""id"": ""85263fcb-71e2-4791-85e9-d85a2aaa6d19"",
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
                },
                {
                    ""name"": """",
                    ""id"": ""2ca5cb0b-691b-4528-b051-897e79f396c6"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DPadDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8e267d20-8047-4861-a605-954c032c7493"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DPadUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9d96c025-aa86-481b-a1e7-ce17fb6dc85e"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""96d69bd1-869e-4696-8cf0-5b7b95fe1f51"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""B"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6ab9b38a-b021-4b50-a5ae-417e3105f6e7"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""D-PadLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4c4db11f-f95e-4919-aaee-2561878258e3"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""D-PadRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""15397550-5f11-4ae9-9cd1-745f36f9436d"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Y"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f742af56-75f1-492f-8593-d5cb03d536ce"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Start"",
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
        m_Player_DPadUp = m_Player.FindAction("DPadUp", throwIfNotFound: true);
        m_Player_DPadDown = m_Player.FindAction("DPadDown", throwIfNotFound: true);
        m_Player_Select = m_Player.FindAction("Select", throwIfNotFound: true);
        m_Player_B = m_Player.FindAction("B", throwIfNotFound: true);
        m_Player_DPadLeft = m_Player.FindAction("D-PadLeft", throwIfNotFound: true);
        m_Player_DPadRight = m_Player.FindAction("D-PadRight", throwIfNotFound: true);
        m_Player_Y = m_Player.FindAction("Y", throwIfNotFound: true);
        m_Player_Start = m_Player.FindAction("Start", throwIfNotFound: true);
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
    private readonly InputAction m_Player_DPadUp;
    private readonly InputAction m_Player_DPadDown;
    private readonly InputAction m_Player_Select;
    private readonly InputAction m_Player_B;
    private readonly InputAction m_Player_DPadLeft;
    private readonly InputAction m_Player_DPadRight;
    private readonly InputAction m_Player_Y;
    private readonly InputAction m_Player_Start;
    public struct PlayerActions
    {
        private @Controls m_Wrapper;
        public PlayerActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Arms => m_Wrapper.m_Player_Arms;
        public InputAction @LeftHand => m_Wrapper.m_Player_LeftHand;
        public InputAction @RightHand => m_Wrapper.m_Player_RightHand;
        public InputAction @DPadUp => m_Wrapper.m_Player_DPadUp;
        public InputAction @DPadDown => m_Wrapper.m_Player_DPadDown;
        public InputAction @Select => m_Wrapper.m_Player_Select;
        public InputAction @B => m_Wrapper.m_Player_B;
        public InputAction @DPadLeft => m_Wrapper.m_Player_DPadLeft;
        public InputAction @DPadRight => m_Wrapper.m_Player_DPadRight;
        public InputAction @Y => m_Wrapper.m_Player_Y;
        public InputAction @Start => m_Wrapper.m_Player_Start;
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
                @DPadUp.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDPadUp;
                @DPadUp.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDPadUp;
                @DPadUp.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDPadUp;
                @DPadDown.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDPadDown;
                @DPadDown.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDPadDown;
                @DPadDown.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDPadDown;
                @Select.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSelect;
                @Select.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSelect;
                @Select.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSelect;
                @B.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnB;
                @B.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnB;
                @B.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnB;
                @DPadLeft.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDPadLeft;
                @DPadLeft.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDPadLeft;
                @DPadLeft.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDPadLeft;
                @DPadRight.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDPadRight;
                @DPadRight.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDPadRight;
                @DPadRight.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDPadRight;
                @Y.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnY;
                @Y.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnY;
                @Y.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnY;
                @Start.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnStart;
                @Start.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnStart;
                @Start.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnStart;
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
                @DPadUp.started += instance.OnDPadUp;
                @DPadUp.performed += instance.OnDPadUp;
                @DPadUp.canceled += instance.OnDPadUp;
                @DPadDown.started += instance.OnDPadDown;
                @DPadDown.performed += instance.OnDPadDown;
                @DPadDown.canceled += instance.OnDPadDown;
                @Select.started += instance.OnSelect;
                @Select.performed += instance.OnSelect;
                @Select.canceled += instance.OnSelect;
                @B.started += instance.OnB;
                @B.performed += instance.OnB;
                @B.canceled += instance.OnB;
                @DPadLeft.started += instance.OnDPadLeft;
                @DPadLeft.performed += instance.OnDPadLeft;
                @DPadLeft.canceled += instance.OnDPadLeft;
                @DPadRight.started += instance.OnDPadRight;
                @DPadRight.performed += instance.OnDPadRight;
                @DPadRight.canceled += instance.OnDPadRight;
                @Y.started += instance.OnY;
                @Y.performed += instance.OnY;
                @Y.canceled += instance.OnY;
                @Start.started += instance.OnStart;
                @Start.performed += instance.OnStart;
                @Start.canceled += instance.OnStart;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    public interface IPlayerActions
    {
        void OnArms(InputAction.CallbackContext context);
        void OnLeftHand(InputAction.CallbackContext context);
        void OnRightHand(InputAction.CallbackContext context);
        void OnDPadUp(InputAction.CallbackContext context);
        void OnDPadDown(InputAction.CallbackContext context);
        void OnSelect(InputAction.CallbackContext context);
        void OnB(InputAction.CallbackContext context);
        void OnDPadLeft(InputAction.CallbackContext context);
        void OnDPadRight(InputAction.CallbackContext context);
        void OnY(InputAction.CallbackContext context);
        void OnStart(InputAction.CallbackContext context);
    }
}
