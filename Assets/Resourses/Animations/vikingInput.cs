// GENERATED AUTOMATICALLY FROM 'Assets/Resourses/Animations/vikingInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @VikingInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @VikingInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""vikingInput"",
    ""maps"": [
        {
            ""name"": ""vikingInput"",
            ""id"": ""39f0d28a-dece-40d3-b1bc-5eb52aaf65b0"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""bc9fc2e0-f9cc-4799-a2c9-c622cfb3a2b7"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Value"",
                    ""id"": ""62109616-4287-492c-b0f8-09ac30f1d21c"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""284bb055-bb33-4569-a0f6-a440dcba9f3b"",
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
                    ""id"": ""19e1fd9e-0418-4ff6-a105-fd9a1c449afb"",
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
                    ""id"": ""cb013e64-a60b-4db2-a979-3d008eb5956d"",
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
                    ""id"": ""7cc2672f-5a9e-4a28-88f4-4b73e7e50e48"",
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
                    ""id"": ""cfcf4f86-fb1e-46b4-9e3d-3f546b067ae5"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""69db3fbb-9224-45d6-8ea4-ed6a24b684a3"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""6a2df7ec-c0fc-444a-ac9c-542ea4d052e3"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // vikingInput
        m_vikingInput = asset.FindActionMap("vikingInput", throwIfNotFound: true);
        m_vikingInput_Move = m_vikingInput.FindAction("Move", throwIfNotFound: true);
        m_vikingInput_Jump = m_vikingInput.FindAction("Jump", throwIfNotFound: true);
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

    // vikingInput
    private readonly InputActionMap m_vikingInput;
    private IVikingInputActions m_VikingInputActionsCallbackInterface;
    private readonly InputAction m_vikingInput_Move;
    private readonly InputAction m_vikingInput_Jump;
    public struct VikingInputActions
    {
        private @VikingInput m_Wrapper;
        public VikingInputActions(@VikingInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_vikingInput_Move;
        public InputAction @Jump => m_Wrapper.m_vikingInput_Jump;
        public InputActionMap Get() { return m_Wrapper.m_vikingInput; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(VikingInputActions set) { return set.Get(); }
        public void SetCallbacks(IVikingInputActions instance)
        {
            if (m_Wrapper.m_VikingInputActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_VikingInputActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_VikingInputActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_VikingInputActionsCallbackInterface.OnMove;
                @Jump.started -= m_Wrapper.m_VikingInputActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_VikingInputActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_VikingInputActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_VikingInputActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
            }
        }
    }
    public VikingInputActions @vikingInput => new VikingInputActions(this);
    public interface IVikingInputActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
}
