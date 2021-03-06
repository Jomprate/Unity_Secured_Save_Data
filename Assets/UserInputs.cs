//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/UserInputs.inputactions
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

public partial class @UserInputs : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @UserInputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""UserInputs"",
    ""maps"": [
        {
            ""name"": ""UIInputs"",
            ""id"": ""5c69309e-aad0-4177-a101-ad0fb48fbe15"",
            ""actions"": [
                {
                    ""name"": ""TabInputChange"",
                    ""type"": ""Value"",
                    ""id"": ""9e161ab1-98db-4d25-9920-30fa470ba745"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""bd11849b-b2e0-429c-a13d-d397448f5900"",
                    ""normalSavePath"": ""<Keyboard>/tab"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""TabInputChange"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""PC"",
            ""bindingGroup"": ""PC"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // UIInputs
        m_UIInputs = asset.FindActionMap("UIInputs", throwIfNotFound: true);
        m_UIInputs_TabInputChange = m_UIInputs.FindAction("TabInputChange", throwIfNotFound: true);
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

    // UIInputs
    private readonly InputActionMap m_UIInputs;
    private IUIInputsActions m_UIInputsActionsCallbackInterface;
    private readonly InputAction m_UIInputs_TabInputChange;
    public struct UIInputsActions
    {
        private @UserInputs m_Wrapper;
        public UIInputsActions(@UserInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @TabInputChange => m_Wrapper.m_UIInputs_TabInputChange;
        public InputActionMap Get() { return m_Wrapper.m_UIInputs; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIInputsActions set) { return set.Get(); }
        public void SetCallbacks(IUIInputsActions instance)
        {
            if (m_Wrapper.m_UIInputsActionsCallbackInterface != null)
            {
                @TabInputChange.started -= m_Wrapper.m_UIInputsActionsCallbackInterface.OnTabInputChange;
                @TabInputChange.performed -= m_Wrapper.m_UIInputsActionsCallbackInterface.OnTabInputChange;
                @TabInputChange.canceled -= m_Wrapper.m_UIInputsActionsCallbackInterface.OnTabInputChange;
            }
            m_Wrapper.m_UIInputsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @TabInputChange.started += instance.OnTabInputChange;
                @TabInputChange.performed += instance.OnTabInputChange;
                @TabInputChange.canceled += instance.OnTabInputChange;
            }
        }
    }
    public UIInputsActions @UIInputs => new UIInputsActions(this);
    private int m_PCSchemeIndex = -1;
    public InputControlScheme PCScheme
    {
        get
        {
            if (m_PCSchemeIndex == -1) m_PCSchemeIndex = asset.FindControlSchemeIndex("PC");
            return asset.controlSchemes[m_PCSchemeIndex];
        }
    }
    public interface IUIInputsActions
    {
        void OnTabInputChange(InputAction.CallbackContext context);
    }
}
