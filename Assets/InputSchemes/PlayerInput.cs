// GENERATED AUTOMATICALLY FROM 'Assets/InputSchemes/PlayerInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""KeyboardControls"",
            ""id"": ""1442e708-2498-44f2-8298-c6874c0530fb"",
            ""actions"": [
                {
                    ""name"": ""Steering"",
                    ""type"": ""Value"",
                    ""id"": ""f102ca3e-c20c-4cb5-9d57-d541a1261cbf"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Value"",
                    ""id"": ""14d9372e-adfc-4603-848e-ff9635b89475"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""HammerBoost"",
                    ""type"": ""Button"",
                    ""id"": ""9a924022-1cf3-4a33-9c67-a100ff61a981"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Value"",
                    ""id"": ""efd42687-e0ad-4bca-9ab5-7e891af44d90"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steering"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""37dd4b6f-93cd-42cd-8f79-3acef0ac026c"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Steering"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""2a0c20a8-812b-4ce5-8f85-9ace47526245"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Steering"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""82bcec66-36f3-47d9-ab03-2e3f7e4cc237"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5d4392f3-db56-4110-a691-5f9e4d9caef1"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""HammerBoost"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""147cc5b1-08d9-4f25-af5e-b8c5358bcba6"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""MouseControls"",
            ""id"": ""dffcc1cf-31a9-42b1-a26d-89c7cb2103c2"",
            ""actions"": [
                {
                    ""name"": ""SteeringPos"",
                    ""type"": ""Value"",
                    ""id"": ""4aaeaba3-7e2d-47e4-b822-d4798d317aac"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""HammerBoost"",
                    ""type"": ""Button"",
                    ""id"": ""46a916c5-8792-4832-a77c-8958b613f310"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""91c28734-8aad-4fcc-903d-25154c2ac222"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse"",
                    ""action"": ""SteeringPos"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fc486f86-d2d4-4f1d-a462-dc4175a70bc3"",
                    ""path"": ""<Mouse>/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse"",
                    ""action"": ""HammerBoost"",
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
            ""name"": ""Mouse"",
            ""bindingGroup"": ""Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // KeyboardControls
        m_KeyboardControls = asset.FindActionMap("KeyboardControls", throwIfNotFound: true);
        m_KeyboardControls_Steering = m_KeyboardControls.FindAction("Steering", throwIfNotFound: true);
        m_KeyboardControls_Jump = m_KeyboardControls.FindAction("Jump", throwIfNotFound: true);
        m_KeyboardControls_HammerBoost = m_KeyboardControls.FindAction("HammerBoost", throwIfNotFound: true);
        // MouseControls
        m_MouseControls = asset.FindActionMap("MouseControls", throwIfNotFound: true);
        m_MouseControls_SteeringPos = m_MouseControls.FindAction("SteeringPos", throwIfNotFound: true);
        m_MouseControls_HammerBoost = m_MouseControls.FindAction("HammerBoost", throwIfNotFound: true);
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

    // KeyboardControls
    private readonly InputActionMap m_KeyboardControls;
    private IKeyboardControlsActions m_KeyboardControlsActionsCallbackInterface;
    private readonly InputAction m_KeyboardControls_Steering;
    private readonly InputAction m_KeyboardControls_Jump;
    private readonly InputAction m_KeyboardControls_HammerBoost;
    public struct KeyboardControlsActions
    {
        private @PlayerInput m_Wrapper;
        public KeyboardControlsActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Steering => m_Wrapper.m_KeyboardControls_Steering;
        public InputAction @Jump => m_Wrapper.m_KeyboardControls_Jump;
        public InputAction @HammerBoost => m_Wrapper.m_KeyboardControls_HammerBoost;
        public InputActionMap Get() { return m_Wrapper.m_KeyboardControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(KeyboardControlsActions set) { return set.Get(); }
        public void SetCallbacks(IKeyboardControlsActions instance)
        {
            if (m_Wrapper.m_KeyboardControlsActionsCallbackInterface != null)
            {
                @Steering.started -= m_Wrapper.m_KeyboardControlsActionsCallbackInterface.OnSteering;
                @Steering.performed -= m_Wrapper.m_KeyboardControlsActionsCallbackInterface.OnSteering;
                @Steering.canceled -= m_Wrapper.m_KeyboardControlsActionsCallbackInterface.OnSteering;
                @Jump.started -= m_Wrapper.m_KeyboardControlsActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_KeyboardControlsActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_KeyboardControlsActionsCallbackInterface.OnJump;
                @HammerBoost.started -= m_Wrapper.m_KeyboardControlsActionsCallbackInterface.OnHammerBoost;
                @HammerBoost.performed -= m_Wrapper.m_KeyboardControlsActionsCallbackInterface.OnHammerBoost;
                @HammerBoost.canceled -= m_Wrapper.m_KeyboardControlsActionsCallbackInterface.OnHammerBoost;
            }
            m_Wrapper.m_KeyboardControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Steering.started += instance.OnSteering;
                @Steering.performed += instance.OnSteering;
                @Steering.canceled += instance.OnSteering;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @HammerBoost.started += instance.OnHammerBoost;
                @HammerBoost.performed += instance.OnHammerBoost;
                @HammerBoost.canceled += instance.OnHammerBoost;
            }
        }
    }
    public KeyboardControlsActions @KeyboardControls => new KeyboardControlsActions(this);

    // MouseControls
    private readonly InputActionMap m_MouseControls;
    private IMouseControlsActions m_MouseControlsActionsCallbackInterface;
    private readonly InputAction m_MouseControls_SteeringPos;
    private readonly InputAction m_MouseControls_HammerBoost;
    public struct MouseControlsActions
    {
        private @PlayerInput m_Wrapper;
        public MouseControlsActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @SteeringPos => m_Wrapper.m_MouseControls_SteeringPos;
        public InputAction @HammerBoost => m_Wrapper.m_MouseControls_HammerBoost;
        public InputActionMap Get() { return m_Wrapper.m_MouseControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MouseControlsActions set) { return set.Get(); }
        public void SetCallbacks(IMouseControlsActions instance)
        {
            if (m_Wrapper.m_MouseControlsActionsCallbackInterface != null)
            {
                @SteeringPos.started -= m_Wrapper.m_MouseControlsActionsCallbackInterface.OnSteeringPos;
                @SteeringPos.performed -= m_Wrapper.m_MouseControlsActionsCallbackInterface.OnSteeringPos;
                @SteeringPos.canceled -= m_Wrapper.m_MouseControlsActionsCallbackInterface.OnSteeringPos;
                @HammerBoost.started -= m_Wrapper.m_MouseControlsActionsCallbackInterface.OnHammerBoost;
                @HammerBoost.performed -= m_Wrapper.m_MouseControlsActionsCallbackInterface.OnHammerBoost;
                @HammerBoost.canceled -= m_Wrapper.m_MouseControlsActionsCallbackInterface.OnHammerBoost;
            }
            m_Wrapper.m_MouseControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @SteeringPos.started += instance.OnSteeringPos;
                @SteeringPos.performed += instance.OnSteeringPos;
                @SteeringPos.canceled += instance.OnSteeringPos;
                @HammerBoost.started += instance.OnHammerBoost;
                @HammerBoost.performed += instance.OnHammerBoost;
                @HammerBoost.canceled += instance.OnHammerBoost;
            }
        }
    }
    public MouseControlsActions @MouseControls => new MouseControlsActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    private int m_MouseSchemeIndex = -1;
    public InputControlScheme MouseScheme
    {
        get
        {
            if (m_MouseSchemeIndex == -1) m_MouseSchemeIndex = asset.FindControlSchemeIndex("Mouse");
            return asset.controlSchemes[m_MouseSchemeIndex];
        }
    }
    public interface IKeyboardControlsActions
    {
        void OnSteering(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnHammerBoost(InputAction.CallbackContext context);
    }
    public interface IMouseControlsActions
    {
        void OnSteeringPos(InputAction.CallbackContext context);
        void OnHammerBoost(InputAction.CallbackContext context);
    }
}
