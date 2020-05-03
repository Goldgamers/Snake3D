// GENERATED AUTOMATICALLY FROM 'Assets/InputMaster.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputMaster : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputMaster()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputMaster"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""30316325-1e46-48fd-ae3d-b4f28121eaad"",
            ""actions"": [
                {
                    ""name"": ""ChangeDirUp"",
                    ""type"": ""Button"",
                    ""id"": ""473fd385-f077-47db-b3ec-630e6882d423"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ChangeDirDown"",
                    ""type"": ""Button"",
                    ""id"": ""02f0b279-e7d2-4785-956e-a225566bfa30"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ChangeDirLeft"",
                    ""type"": ""Button"",
                    ""id"": ""3120a260-870a-41c3-a36b-f697cf712a1c"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ChangeDirRight"",
                    ""type"": ""Button"",
                    ""id"": ""149994cf-ae22-4fc7-9939-20b74cd4d0a7"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b3a3dd1f-0284-4247-93d1-50326ffd05a0"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""ChangeDirUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0de4fd82-5315-4d28-86a5-7aca1c896c9a"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""ChangeDirUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e4128d5a-7bca-422d-959c-130abe2efba4"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""ChangeDirUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""65686cc7-20e6-4d3a-889e-43490b61af02"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""ChangeDirDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""378ee50e-3782-43f0-929b-9b8d4fe839b1"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""ChangeDirDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""065926ba-70f4-4daa-a73c-4bea9d9f2918"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""ChangeDirDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""20cef06d-d44c-4056-bf29-e36a326f90f8"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""ChangeDirLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""797c09b0-332c-4861-a36d-ca231a4dd94f"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""ChangeDirLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c8d211b2-7f1d-4c73-8cf6-7c5307123d96"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""ChangeDirLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""00de2bf4-4181-4f28-931b-8dc1a9834ed9"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""ChangeDirRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fb429abf-4dfe-4996-9746-8a1d9973d8b6"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""ChangeDirRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6984699e-a89b-4b3d-887d-5c78c6d7beb0"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""ChangeDirRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UI"",
            ""id"": ""39e0fd3d-3dcb-4ba1-92fc-65d6207d54de"",
            ""actions"": [
                {
                    ""name"": ""MenuUp"",
                    ""type"": ""Button"",
                    ""id"": ""41903108-73cc-4c7d-998e-4317ae6331e5"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MenuDown"",
                    ""type"": ""Button"",
                    ""id"": ""e49b9bf7-65f4-42c6-a9dc-4ce44847ab3a"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""StartGame"",
                    ""type"": ""Button"",
                    ""id"": ""dcc4f620-4166-4cff-8da0-6859fcaa3d43"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PauseMenu"",
                    ""type"": ""Button"",
                    ""id"": ""7f2ed418-43e1-49ae-a1f6-f9e6a66f5ec1"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""70882458-00b5-436d-bddd-842b96a8fcf1"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""MenuUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d5c72447-30d1-47ab-9be8-26e84c948456"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""MenuUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f8405179-2b0c-41a5-9d3f-b4108bca997c"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""MenuDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8654bc71-cb1d-412b-b9e8-c85355f72efa"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""MenuDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f3449053-9c7d-412f-81ea-dbec9929d23e"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""StartGame"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3c5118a3-3165-411b-b828-1b132f72f96e"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""StartGame"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e30508e4-3e1c-45f7-b77b-20cf0b727370"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""PauseMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d17e4ec4-97d6-49d7-b2c7-da3e193feb43"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""PauseMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Controller"",
            ""bindingGroup"": ""Controller"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_ChangeDirUp = m_Gameplay.FindAction("ChangeDirUp", throwIfNotFound: true);
        m_Gameplay_ChangeDirDown = m_Gameplay.FindAction("ChangeDirDown", throwIfNotFound: true);
        m_Gameplay_ChangeDirLeft = m_Gameplay.FindAction("ChangeDirLeft", throwIfNotFound: true);
        m_Gameplay_ChangeDirRight = m_Gameplay.FindAction("ChangeDirRight", throwIfNotFound: true);
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_MenuUp = m_UI.FindAction("MenuUp", throwIfNotFound: true);
        m_UI_MenuDown = m_UI.FindAction("MenuDown", throwIfNotFound: true);
        m_UI_StartGame = m_UI.FindAction("StartGame", throwIfNotFound: true);
        m_UI_PauseMenu = m_UI.FindAction("PauseMenu", throwIfNotFound: true);
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

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private IGameplayActions m_GameplayActionsCallbackInterface;
    private readonly InputAction m_Gameplay_ChangeDirUp;
    private readonly InputAction m_Gameplay_ChangeDirDown;
    private readonly InputAction m_Gameplay_ChangeDirLeft;
    private readonly InputAction m_Gameplay_ChangeDirRight;
    public struct GameplayActions
    {
        private @InputMaster m_Wrapper;
        public GameplayActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @ChangeDirUp => m_Wrapper.m_Gameplay_ChangeDirUp;
        public InputAction @ChangeDirDown => m_Wrapper.m_Gameplay_ChangeDirDown;
        public InputAction @ChangeDirLeft => m_Wrapper.m_Gameplay_ChangeDirLeft;
        public InputAction @ChangeDirRight => m_Wrapper.m_Gameplay_ChangeDirRight;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                @ChangeDirUp.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnChangeDirUp;
                @ChangeDirUp.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnChangeDirUp;
                @ChangeDirUp.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnChangeDirUp;
                @ChangeDirDown.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnChangeDirDown;
                @ChangeDirDown.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnChangeDirDown;
                @ChangeDirDown.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnChangeDirDown;
                @ChangeDirLeft.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnChangeDirLeft;
                @ChangeDirLeft.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnChangeDirLeft;
                @ChangeDirLeft.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnChangeDirLeft;
                @ChangeDirRight.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnChangeDirRight;
                @ChangeDirRight.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnChangeDirRight;
                @ChangeDirRight.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnChangeDirRight;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @ChangeDirUp.started += instance.OnChangeDirUp;
                @ChangeDirUp.performed += instance.OnChangeDirUp;
                @ChangeDirUp.canceled += instance.OnChangeDirUp;
                @ChangeDirDown.started += instance.OnChangeDirDown;
                @ChangeDirDown.performed += instance.OnChangeDirDown;
                @ChangeDirDown.canceled += instance.OnChangeDirDown;
                @ChangeDirLeft.started += instance.OnChangeDirLeft;
                @ChangeDirLeft.performed += instance.OnChangeDirLeft;
                @ChangeDirLeft.canceled += instance.OnChangeDirLeft;
                @ChangeDirRight.started += instance.OnChangeDirRight;
                @ChangeDirRight.performed += instance.OnChangeDirRight;
                @ChangeDirRight.canceled += instance.OnChangeDirRight;
            }
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);

    // UI
    private readonly InputActionMap m_UI;
    private IUIActions m_UIActionsCallbackInterface;
    private readonly InputAction m_UI_MenuUp;
    private readonly InputAction m_UI_MenuDown;
    private readonly InputAction m_UI_StartGame;
    private readonly InputAction m_UI_PauseMenu;
    public struct UIActions
    {
        private @InputMaster m_Wrapper;
        public UIActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @MenuUp => m_Wrapper.m_UI_MenuUp;
        public InputAction @MenuDown => m_Wrapper.m_UI_MenuDown;
        public InputAction @StartGame => m_Wrapper.m_UI_StartGame;
        public InputAction @PauseMenu => m_Wrapper.m_UI_PauseMenu;
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        public void SetCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterface != null)
            {
                @MenuUp.started -= m_Wrapper.m_UIActionsCallbackInterface.OnMenuUp;
                @MenuUp.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnMenuUp;
                @MenuUp.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnMenuUp;
                @MenuDown.started -= m_Wrapper.m_UIActionsCallbackInterface.OnMenuDown;
                @MenuDown.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnMenuDown;
                @MenuDown.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnMenuDown;
                @StartGame.started -= m_Wrapper.m_UIActionsCallbackInterface.OnStartGame;
                @StartGame.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnStartGame;
                @StartGame.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnStartGame;
                @PauseMenu.started -= m_Wrapper.m_UIActionsCallbackInterface.OnPauseMenu;
                @PauseMenu.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnPauseMenu;
                @PauseMenu.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnPauseMenu;
            }
            m_Wrapper.m_UIActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MenuUp.started += instance.OnMenuUp;
                @MenuUp.performed += instance.OnMenuUp;
                @MenuUp.canceled += instance.OnMenuUp;
                @MenuDown.started += instance.OnMenuDown;
                @MenuDown.performed += instance.OnMenuDown;
                @MenuDown.canceled += instance.OnMenuDown;
                @StartGame.started += instance.OnStartGame;
                @StartGame.performed += instance.OnStartGame;
                @StartGame.canceled += instance.OnStartGame;
                @PauseMenu.started += instance.OnPauseMenu;
                @PauseMenu.performed += instance.OnPauseMenu;
                @PauseMenu.canceled += instance.OnPauseMenu;
            }
        }
    }
    public UIActions @UI => new UIActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    private int m_ControllerSchemeIndex = -1;
    public InputControlScheme ControllerScheme
    {
        get
        {
            if (m_ControllerSchemeIndex == -1) m_ControllerSchemeIndex = asset.FindControlSchemeIndex("Controller");
            return asset.controlSchemes[m_ControllerSchemeIndex];
        }
    }
    public interface IGameplayActions
    {
        void OnChangeDirUp(InputAction.CallbackContext context);
        void OnChangeDirDown(InputAction.CallbackContext context);
        void OnChangeDirLeft(InputAction.CallbackContext context);
        void OnChangeDirRight(InputAction.CallbackContext context);
    }
    public interface IUIActions
    {
        void OnMenuUp(InputAction.CallbackContext context);
        void OnMenuDown(InputAction.CallbackContext context);
        void OnStartGame(InputAction.CallbackContext context);
        void OnPauseMenu(InputAction.CallbackContext context);
    }
}
