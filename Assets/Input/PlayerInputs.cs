// GENERATED AUTOMATICALLY FROM 'Assets/Input/PlayerInputs.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInputs : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputs"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""ec631ee9-d6cc-4776-a3d2-99448a820f2f"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""9fff8822-2f63-44b3-a6a5-066d2465b275"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""StickDeadzone(max=1)"",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""b22d8a4c-3bd8-47d2-8c3f-22f69536bd41"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""StickDeadzone(max=1)"",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""56bf2d81-fbfe-45eb-9164-f3d7e9f86386"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interact2"",
                    ""type"": ""Button"",
                    ""id"": ""e0aafe77-6e65-412b-a0e0-3e898396cc78"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""99733ef0-b0e7-4037-b795-b972bfe579c0"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1be2f4b5-cfa2-48bb-a519-4a1b3ed9cbdf"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f4d3ea8c-f7e2-4762-a198-abdfab490aac"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5fad4231-033a-4194-8e5c-40002a38ec33"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cad489a9-40aa-4660-bdd5-90f0dae7bc2c"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""224d4b47-d6f1-478d-a84a-be16230d368c"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""26e08a59-4e6e-44aa-aaac-f2a05ec32208"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": ""StickDeadzone,InvertVector2(invertX=false)"",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4615b6df-c7ff-474c-ad3a-cf69bebacfff"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UIPlayer"",
            ""id"": ""c7805bc5-d328-4b09-8423-d521fc4d5bc3"",
            ""actions"": [
                {
                    ""name"": ""Submit"",
                    ""type"": ""Button"",
                    ""id"": ""7629af59-3143-4d2a-a2bc-c6c2f69c0c66"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""7101b04c-f0d5-470a-bccb-e7e45e9d573c"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a2e60c83-ec81-46dd-9d87-13ddefd9cb1a"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Submit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c00ef746-6ddb-4531-95de-fe46cf6f66f5"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a72c5839-1d84-45af-bb5f-bc5cf0ea690d"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""DebugPlayer"",
            ""id"": ""aedc77c2-3a3d-4444-8109-c7d33e6d2c3c"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""2f194e92-c46a-4f9a-bcd8-f986cde5952a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""c1c9e455-3575-4b00-9c79-ec0260870d61"",
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
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Move = m_Player.FindAction("Move", throwIfNotFound: true);
        m_Player_Look = m_Player.FindAction("Look", throwIfNotFound: true);
        m_Player_Interact = m_Player.FindAction("Interact", throwIfNotFound: true);
        m_Player_Interact2 = m_Player.FindAction("Interact2", throwIfNotFound: true);
        // UIPlayer
        m_UIPlayer = asset.FindActionMap("UIPlayer", throwIfNotFound: true);
        m_UIPlayer_Submit = m_UIPlayer.FindAction("Submit", throwIfNotFound: true);
        m_UIPlayer_Move = m_UIPlayer.FindAction("Move", throwIfNotFound: true);
        // DebugPlayer
        m_DebugPlayer = asset.FindActionMap("DebugPlayer", throwIfNotFound: true);
        m_DebugPlayer_Newaction = m_DebugPlayer.FindAction("New action", throwIfNotFound: true);
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
    private readonly InputAction m_Player_Move;
    private readonly InputAction m_Player_Look;
    private readonly InputAction m_Player_Interact;
    private readonly InputAction m_Player_Interact2;
    public struct PlayerActions
    {
        private @PlayerInputs m_Wrapper;
        public PlayerActions(@PlayerInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Player_Move;
        public InputAction @Look => m_Wrapper.m_Player_Look;
        public InputAction @Interact => m_Wrapper.m_Player_Interact;
        public InputAction @Interact2 => m_Wrapper.m_Player_Interact2;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Look.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                @Interact.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                @Interact2.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract2;
                @Interact2.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract2;
                @Interact2.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract2;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
                @Interact2.started += instance.OnInteract2;
                @Interact2.performed += instance.OnInteract2;
                @Interact2.canceled += instance.OnInteract2;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // UIPlayer
    private readonly InputActionMap m_UIPlayer;
    private IUIPlayerActions m_UIPlayerActionsCallbackInterface;
    private readonly InputAction m_UIPlayer_Submit;
    private readonly InputAction m_UIPlayer_Move;
    public struct UIPlayerActions
    {
        private @PlayerInputs m_Wrapper;
        public UIPlayerActions(@PlayerInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Submit => m_Wrapper.m_UIPlayer_Submit;
        public InputAction @Move => m_Wrapper.m_UIPlayer_Move;
        public InputActionMap Get() { return m_Wrapper.m_UIPlayer; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIPlayerActions set) { return set.Get(); }
        public void SetCallbacks(IUIPlayerActions instance)
        {
            if (m_Wrapper.m_UIPlayerActionsCallbackInterface != null)
            {
                @Submit.started -= m_Wrapper.m_UIPlayerActionsCallbackInterface.OnSubmit;
                @Submit.performed -= m_Wrapper.m_UIPlayerActionsCallbackInterface.OnSubmit;
                @Submit.canceled -= m_Wrapper.m_UIPlayerActionsCallbackInterface.OnSubmit;
                @Move.started -= m_Wrapper.m_UIPlayerActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_UIPlayerActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_UIPlayerActionsCallbackInterface.OnMove;
            }
            m_Wrapper.m_UIPlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Submit.started += instance.OnSubmit;
                @Submit.performed += instance.OnSubmit;
                @Submit.canceled += instance.OnSubmit;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
            }
        }
    }
    public UIPlayerActions @UIPlayer => new UIPlayerActions(this);

    // DebugPlayer
    private readonly InputActionMap m_DebugPlayer;
    private IDebugPlayerActions m_DebugPlayerActionsCallbackInterface;
    private readonly InputAction m_DebugPlayer_Newaction;
    public struct DebugPlayerActions
    {
        private @PlayerInputs m_Wrapper;
        public DebugPlayerActions(@PlayerInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_DebugPlayer_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_DebugPlayer; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DebugPlayerActions set) { return set.Get(); }
        public void SetCallbacks(IDebugPlayerActions instance)
        {
            if (m_Wrapper.m_DebugPlayerActionsCallbackInterface != null)
            {
                @Newaction.started -= m_Wrapper.m_DebugPlayerActionsCallbackInterface.OnNewaction;
                @Newaction.performed -= m_Wrapper.m_DebugPlayerActionsCallbackInterface.OnNewaction;
                @Newaction.canceled -= m_Wrapper.m_DebugPlayerActionsCallbackInterface.OnNewaction;
            }
            m_Wrapper.m_DebugPlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
            }
        }
    }
    public DebugPlayerActions @DebugPlayer => new DebugPlayerActions(this);
    public interface IPlayerActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnInteract2(InputAction.CallbackContext context);
    }
    public interface IUIPlayerActions
    {
        void OnSubmit(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
    }
    public interface IDebugPlayerActions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
}
