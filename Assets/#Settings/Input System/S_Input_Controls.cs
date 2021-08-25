// GENERATED AUTOMATICALLY FROM 'Assets/#Settings/Input System/S_Input_Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @S_Input_Controls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @S_Input_Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""S_Input_Controls"",
    ""maps"": [
        {
            ""name"": ""PlayerKeyMap"",
            ""id"": ""0f9d488a-0635-44be-9b86-a686cc87618c"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""44511721-3d1f-470c-84a1-1c8ee227bef7"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""671a1dd6-18d2-4307-aaa1-3b89c76bcb66"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""57b99943-8032-4685-a478-1d4a1357b3f1"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Menu"",
                    ""type"": ""Button"",
                    ""id"": ""4d0cfdb1-46c2-4d8a-8397-fc1bccba75fc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Escape"",
                    ""type"": ""Button"",
                    ""id"": ""7ead5aef-252c-420b-ae7f-8d99ae1a5045"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Mouse"",
                    ""type"": ""Button"",
                    ""id"": ""795cd88a-f631-4b96-884c-26ff9a543ff8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""8a4d7166-1f26-4a8a-b8c9-a753300aaf56"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": ""InvertVector2(invertX=false)"",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""756db4b1-9c93-4e7e-a441-44ef65e7f97a"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""de2d49f1-d6bf-44b0-9309-004c1f5a2a94"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""e5f80570-e6c8-418b-9e60-899cb604caff"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""59cc5b35-b9e6-420e-a3b3-d99a6e8cb8e1"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""6fe014e3-39ec-44a5-9ccc-23ea873db776"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""dbdee6ca-7257-4c95-9c3b-8180d34d277f"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8841c7fd-5b9d-4fcc-9af2-49ba8a6b999a"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0a37c33e-eddf-485e-920e-297116822664"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": ""InvertVector2(invertX=false)"",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""927493a0-357e-4276-a38c-c113217b46a9"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""54fcfcd7-12b7-4791-8ef4-50b3468237e8"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Escape"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c3527a59-6777-4825-8609-a3c10480351c"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mouse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""TouchKeyMap"",
            ""id"": ""4a1cbcec-4d3f-4fdf-87b4-a0595d9d4c61"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""970fa179-a43b-4c7e-aa43-6f92c4a92c82"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""dcb84fd2-fc65-4554-bf29-8c900e4d2e88"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerKeyMap
        m_PlayerKeyMap = asset.FindActionMap("PlayerKeyMap", throwIfNotFound: true);
        m_PlayerKeyMap_Move = m_PlayerKeyMap.FindAction("Move", throwIfNotFound: true);
        m_PlayerKeyMap_Jump = m_PlayerKeyMap.FindAction("Jump", throwIfNotFound: true);
        m_PlayerKeyMap_Look = m_PlayerKeyMap.FindAction("Look", throwIfNotFound: true);
        m_PlayerKeyMap_Menu = m_PlayerKeyMap.FindAction("Menu", throwIfNotFound: true);
        m_PlayerKeyMap_Escape = m_PlayerKeyMap.FindAction("Escape", throwIfNotFound: true);
        m_PlayerKeyMap_Mouse = m_PlayerKeyMap.FindAction("Mouse", throwIfNotFound: true);
        // TouchKeyMap
        m_TouchKeyMap = asset.FindActionMap("TouchKeyMap", throwIfNotFound: true);
        m_TouchKeyMap_Newaction = m_TouchKeyMap.FindAction("New action", throwIfNotFound: true);
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

    // PlayerKeyMap
    private readonly InputActionMap m_PlayerKeyMap;
    private IPlayerKeyMapActions m_PlayerKeyMapActionsCallbackInterface;
    private readonly InputAction m_PlayerKeyMap_Move;
    private readonly InputAction m_PlayerKeyMap_Jump;
    private readonly InputAction m_PlayerKeyMap_Look;
    private readonly InputAction m_PlayerKeyMap_Menu;
    private readonly InputAction m_PlayerKeyMap_Escape;
    private readonly InputAction m_PlayerKeyMap_Mouse;
    public struct PlayerKeyMapActions
    {
        private @S_Input_Controls m_Wrapper;
        public PlayerKeyMapActions(@S_Input_Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_PlayerKeyMap_Move;
        public InputAction @Jump => m_Wrapper.m_PlayerKeyMap_Jump;
        public InputAction @Look => m_Wrapper.m_PlayerKeyMap_Look;
        public InputAction @Menu => m_Wrapper.m_PlayerKeyMap_Menu;
        public InputAction @Escape => m_Wrapper.m_PlayerKeyMap_Escape;
        public InputAction @Mouse => m_Wrapper.m_PlayerKeyMap_Mouse;
        public InputActionMap Get() { return m_Wrapper.m_PlayerKeyMap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerKeyMapActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerKeyMapActions instance)
        {
            if (m_Wrapper.m_PlayerKeyMapActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayerKeyMapActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerKeyMapActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerKeyMapActionsCallbackInterface.OnMove;
                @Jump.started -= m_Wrapper.m_PlayerKeyMapActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerKeyMapActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerKeyMapActionsCallbackInterface.OnJump;
                @Look.started -= m_Wrapper.m_PlayerKeyMapActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_PlayerKeyMapActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_PlayerKeyMapActionsCallbackInterface.OnLook;
                @Menu.started -= m_Wrapper.m_PlayerKeyMapActionsCallbackInterface.OnMenu;
                @Menu.performed -= m_Wrapper.m_PlayerKeyMapActionsCallbackInterface.OnMenu;
                @Menu.canceled -= m_Wrapper.m_PlayerKeyMapActionsCallbackInterface.OnMenu;
                @Escape.started -= m_Wrapper.m_PlayerKeyMapActionsCallbackInterface.OnEscape;
                @Escape.performed -= m_Wrapper.m_PlayerKeyMapActionsCallbackInterface.OnEscape;
                @Escape.canceled -= m_Wrapper.m_PlayerKeyMapActionsCallbackInterface.OnEscape;
                @Mouse.started -= m_Wrapper.m_PlayerKeyMapActionsCallbackInterface.OnMouse;
                @Mouse.performed -= m_Wrapper.m_PlayerKeyMapActionsCallbackInterface.OnMouse;
                @Mouse.canceled -= m_Wrapper.m_PlayerKeyMapActionsCallbackInterface.OnMouse;
            }
            m_Wrapper.m_PlayerKeyMapActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @Menu.started += instance.OnMenu;
                @Menu.performed += instance.OnMenu;
                @Menu.canceled += instance.OnMenu;
                @Escape.started += instance.OnEscape;
                @Escape.performed += instance.OnEscape;
                @Escape.canceled += instance.OnEscape;
                @Mouse.started += instance.OnMouse;
                @Mouse.performed += instance.OnMouse;
                @Mouse.canceled += instance.OnMouse;
            }
        }
    }
    public PlayerKeyMapActions @PlayerKeyMap => new PlayerKeyMapActions(this);

    // TouchKeyMap
    private readonly InputActionMap m_TouchKeyMap;
    private ITouchKeyMapActions m_TouchKeyMapActionsCallbackInterface;
    private readonly InputAction m_TouchKeyMap_Newaction;
    public struct TouchKeyMapActions
    {
        private @S_Input_Controls m_Wrapper;
        public TouchKeyMapActions(@S_Input_Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_TouchKeyMap_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_TouchKeyMap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TouchKeyMapActions set) { return set.Get(); }
        public void SetCallbacks(ITouchKeyMapActions instance)
        {
            if (m_Wrapper.m_TouchKeyMapActionsCallbackInterface != null)
            {
                @Newaction.started -= m_Wrapper.m_TouchKeyMapActionsCallbackInterface.OnNewaction;
                @Newaction.performed -= m_Wrapper.m_TouchKeyMapActionsCallbackInterface.OnNewaction;
                @Newaction.canceled -= m_Wrapper.m_TouchKeyMapActionsCallbackInterface.OnNewaction;
            }
            m_Wrapper.m_TouchKeyMapActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
            }
        }
    }
    public TouchKeyMapActions @TouchKeyMap => new TouchKeyMapActions(this);
    public interface IPlayerKeyMapActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnMenu(InputAction.CallbackContext context);
        void OnEscape(InputAction.CallbackContext context);
        void OnMouse(InputAction.CallbackContext context);
    }
    public interface ITouchKeyMapActions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
}
