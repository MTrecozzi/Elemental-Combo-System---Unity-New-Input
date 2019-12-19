// GENERATED AUTOMATICALLY FROM 'Assets/TestInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @TestInput : IInputActionCollection, IDisposable
{
    private InputActionAsset asset;
    public @TestInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""TestInput"",
    ""maps"": [
        {
            ""name"": ""Combo"",
            ""id"": ""7614ef6c-032a-45b8-891a-5edfe4eea7b8"",
            ""actions"": [
                {
                    ""name"": ""R1"",
                    ""type"": ""Button"",
                    ""id"": ""04368ddb-1b41-4bf4-8d9c-6de471e4898a"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""R2"",
                    ""type"": ""Button"",
                    ""id"": ""036a92be-1fd3-48d9-9d36-157b961396b2"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""L1"",
                    ""type"": ""Button"",
                    ""id"": ""5786f196-67c0-4e62-8d72-f3f2a0810abd"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""L2"",
                    ""type"": ""Button"",
                    ""id"": ""e040a713-1023-472f-8cc3-8faf74bbb222"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ea2f0e31-fb89-429a-b7e1-601e904dea20"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""R1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""96b9bd49-9695-4ffa-ba60-6c67819cefe1"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""R2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a75b8632-7c26-464f-bac1-b78b0c5c05c2"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""L1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e9618da3-945f-4e4f-b104-063fb4be388b"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""L2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Combo
        m_Combo = asset.FindActionMap("Combo", throwIfNotFound: true);
        m_Combo_R1 = m_Combo.FindAction("R1", throwIfNotFound: true);
        m_Combo_R2 = m_Combo.FindAction("R2", throwIfNotFound: true);
        m_Combo_L1 = m_Combo.FindAction("L1", throwIfNotFound: true);
        m_Combo_L2 = m_Combo.FindAction("L2", throwIfNotFound: true);
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

    // Combo
    private readonly InputActionMap m_Combo;
    private IComboActions m_ComboActionsCallbackInterface;
    private readonly InputAction m_Combo_R1;
    private readonly InputAction m_Combo_R2;
    private readonly InputAction m_Combo_L1;
    private readonly InputAction m_Combo_L2;
    public struct ComboActions
    {
        private @TestInput m_Wrapper;
        public ComboActions(@TestInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @R1 => m_Wrapper.m_Combo_R1;
        public InputAction @R2 => m_Wrapper.m_Combo_R2;
        public InputAction @L1 => m_Wrapper.m_Combo_L1;
        public InputAction @L2 => m_Wrapper.m_Combo_L2;
        public InputActionMap Get() { return m_Wrapper.m_Combo; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ComboActions set) { return set.Get(); }
        public void SetCallbacks(IComboActions instance)
        {
            if (m_Wrapper.m_ComboActionsCallbackInterface != null)
            {
                @R1.started -= m_Wrapper.m_ComboActionsCallbackInterface.OnR1;
                @R1.performed -= m_Wrapper.m_ComboActionsCallbackInterface.OnR1;
                @R1.canceled -= m_Wrapper.m_ComboActionsCallbackInterface.OnR1;
                @R2.started -= m_Wrapper.m_ComboActionsCallbackInterface.OnR2;
                @R2.performed -= m_Wrapper.m_ComboActionsCallbackInterface.OnR2;
                @R2.canceled -= m_Wrapper.m_ComboActionsCallbackInterface.OnR2;
                @L1.started -= m_Wrapper.m_ComboActionsCallbackInterface.OnL1;
                @L1.performed -= m_Wrapper.m_ComboActionsCallbackInterface.OnL1;
                @L1.canceled -= m_Wrapper.m_ComboActionsCallbackInterface.OnL1;
                @L2.started -= m_Wrapper.m_ComboActionsCallbackInterface.OnL2;
                @L2.performed -= m_Wrapper.m_ComboActionsCallbackInterface.OnL2;
                @L2.canceled -= m_Wrapper.m_ComboActionsCallbackInterface.OnL2;
            }
            m_Wrapper.m_ComboActionsCallbackInterface = instance;
            if (instance != null)
            {
                @R1.started += instance.OnR1;
                @R1.performed += instance.OnR1;
                @R1.canceled += instance.OnR1;
                @R2.started += instance.OnR2;
                @R2.performed += instance.OnR2;
                @R2.canceled += instance.OnR2;
                @L1.started += instance.OnL1;
                @L1.performed += instance.OnL1;
                @L1.canceled += instance.OnL1;
                @L2.started += instance.OnL2;
                @L2.performed += instance.OnL2;
                @L2.canceled += instance.OnL2;
            }
        }
    }
    public ComboActions @Combo => new ComboActions(this);
    public interface IComboActions
    {
        void OnR1(InputAction.CallbackContext context);
        void OnR2(InputAction.CallbackContext context);
        void OnL1(InputAction.CallbackContext context);
        void OnL2(InputAction.CallbackContext context);
    }
}
