// GENERATED AUTOMATICALLY FROM 'Assets/Prefabs/InputSystem/MainControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @MainControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @MainControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""MainControls"",
    ""maps"": [
        {
            ""name"": ""MenuControls"",
            ""id"": ""5da5ed66-3c71-4536-8fb4-33c1cbd33a65"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""a42f3fda-4d84-40ec-913f-01a0c3307024"",
                    ""expectedControlType"": ""Dpad"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Confirm"",
                    ""type"": ""Button"",
                    ""id"": ""ecdccc32-a692-4ea3-a5bc-0207dd837754"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Back"",
                    ""type"": ""Button"",
                    ""id"": ""2ef69c86-bf22-42ea-afbf-3121a3e70a57"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""aaf75fad-dfed-466c-a3bc-c785cbeff087"",
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
                    ""id"": ""ef95c56d-a3ac-4182-895c-2a00b180577e"",
                    ""path"": ""w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""71914c21-c72e-4057-a14b-bd3511ea07e2"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""ded84c53-7ee8-40c2-9d73-b8516e398215"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""ed20537e-23bd-4875-8512-b6fa6b9b2caf"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""ArrowKeys"",
                    ""id"": ""e5119ab2-6832-4dc5-a750-6b86d3ef6d42"",
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
                    ""id"": ""28c00347-c077-4294-aca5-d5939c58eea5"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""269c8e95-7c01-45ea-aae5-a72b15caa4e7"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""e1dd52df-38a7-460a-afa7-fa87fa06fec3"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""15e25b46-92ce-4389-8a2f-1109b5d31e30"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""DPad"",
                    ""id"": ""240b5cf2-3301-4148-a40d-84b08863a1c1"",
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
                    ""id"": ""919a8040-85c2-4297-a324-f474459ae5fc"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controllers"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""fd703300-4cad-4ce1-b868-21da1b928481"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controllers"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""4cced100-ba93-4c6e-9bee-336780848db6"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controllers"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""443f3a68-2670-4f50-9802-d68da196c107"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controllers"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""LeftJoystick"",
                    ""id"": ""2b5bc19c-089a-419b-b907-b2af2301c675"",
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
                    ""id"": ""55435216-4f8d-4794-a121-19cf638fcdf4"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controllers"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""c6c1d0c4-de86-44b9-91a8-bba20c8adab1"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controllers"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""6377fc35-bf9a-4c24-b876-571f40024b0e"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controllers"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""3614cadb-2b77-47d1-b5d0-6928078602e8"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controllers"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""9eae4eca-37cc-48cc-90fa-f689926d9068"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Confirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0d680e8f-c2ce-46c3-8ec7-68b916d2a6df"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controllers"",
                    ""action"": ""Confirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""42208162-9cce-4843-ae44-dd342641ad8c"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Back"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5071ff73-f214-49b1-8265-041156c495fc"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controllers"",
                    ""action"": ""Back"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""DrivingControls"",
            ""id"": ""30c9e03e-39d3-4852-aa6a-c006254a36b2"",
            ""actions"": [
                {
                    ""name"": ""Steering"",
                    ""type"": ""Value"",
                    ""id"": ""f9185450-8330-44cb-97e6-64c2a51f8135"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Gas"",
                    ""type"": ""Value"",
                    ""id"": ""064b9153-df3e-4805-9bf0-718b7cd01fb4"",
                    ""expectedControlType"": ""Analog"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Brakes"",
                    ""type"": ""Value"",
                    ""id"": ""366849bb-5b82-4d55-94a0-010cd3441e9b"",
                    ""expectedControlType"": ""Analog"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""LeftStick(LeftandRight)"",
                    ""id"": ""0e44775e-c410-4337-8761-92cd3de791fb"",
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
                    ""id"": ""3e5b087b-e5f6-4014-9981-981ce17c9173"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controllers"",
                    ""action"": ""Steering"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""a53838a9-42fc-4076-bfc2-9b38b50aa163"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controllers"",
                    ""action"": ""Steering"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""A and D Keys"",
                    ""id"": ""e275892e-52de-4daa-9ea0-8568259c0465"",
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
                    ""id"": ""a7c00041-8132-4003-bcd9-f2e27a531b10"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Steering"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""a9b5d09a-f0c8-4d92-9128-6e4125439b75"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Steering"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""RightTrigger"",
                    ""id"": ""48cc239c-a5bb-40e5-9932-42da4d71a1ea"",
                    ""path"": ""1DAxis(minValue=0,whichSideWins=1)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Gas"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""19e0dc6d-2a5f-4797-b3bc-d3a892870be3"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controllers"",
                    ""action"": ""Gas"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""4ae863ea-63f7-4d0b-bc55-5891bcc6d598"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controllers"",
                    ""action"": ""Gas"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""70b307c0-76f1-4e68-8dc0-ca05fca15ce1"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Gas"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""LeftTrigger"",
                    ""id"": ""9cad9dbb-bcad-4751-ac58-98726aeaad93"",
                    ""path"": ""1DAxis(minValue=0,whichSideWins=1)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Brakes"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""3303330e-fa4f-42ed-b948-53b1a17cd20b"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controllers"",
                    ""action"": ""Brakes"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""ece69080-4d22-4174-ad6d-9256abe36c6c"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controllers"",
                    ""action"": ""Brakes"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""71c89301-7103-4007-9667-1fd64a94df85"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Brakes"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""WalkingControls"",
            ""id"": ""c9aceac6-e688-4f99-b903-8a297ca46b18"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""911ad5c0-3308-4e16-90d4-37b7d01d0093"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""3fdbe939-9d2a-46cd-936e-05fbd4b073d7"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controllers"",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Controllers"",
            ""bindingGroup"": ""Controllers"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Keyboard and Mouse"",
            ""bindingGroup"": ""Keyboard and Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // MenuControls
        m_MenuControls = asset.FindActionMap("MenuControls", throwIfNotFound: true);
        m_MenuControls_Move = m_MenuControls.FindAction("Move", throwIfNotFound: true);
        m_MenuControls_Confirm = m_MenuControls.FindAction("Confirm", throwIfNotFound: true);
        m_MenuControls_Back = m_MenuControls.FindAction("Back", throwIfNotFound: true);
        // DrivingControls
        m_DrivingControls = asset.FindActionMap("DrivingControls", throwIfNotFound: true);
        m_DrivingControls_Steering = m_DrivingControls.FindAction("Steering", throwIfNotFound: true);
        m_DrivingControls_Gas = m_DrivingControls.FindAction("Gas", throwIfNotFound: true);
        m_DrivingControls_Brakes = m_DrivingControls.FindAction("Brakes", throwIfNotFound: true);
        // WalkingControls
        m_WalkingControls = asset.FindActionMap("WalkingControls", throwIfNotFound: true);
        m_WalkingControls_Newaction = m_WalkingControls.FindAction("New action", throwIfNotFound: true);
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

    // MenuControls
    private readonly InputActionMap m_MenuControls;
    private IMenuControlsActions m_MenuControlsActionsCallbackInterface;
    private readonly InputAction m_MenuControls_Move;
    private readonly InputAction m_MenuControls_Confirm;
    private readonly InputAction m_MenuControls_Back;
    public struct MenuControlsActions
    {
        private @MainControls m_Wrapper;
        public MenuControlsActions(@MainControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_MenuControls_Move;
        public InputAction @Confirm => m_Wrapper.m_MenuControls_Confirm;
        public InputAction @Back => m_Wrapper.m_MenuControls_Back;
        public InputActionMap Get() { return m_Wrapper.m_MenuControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuControlsActions set) { return set.Get(); }
        public void SetCallbacks(IMenuControlsActions instance)
        {
            if (m_Wrapper.m_MenuControlsActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnMove;
                @Confirm.started -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnConfirm;
                @Confirm.performed -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnConfirm;
                @Confirm.canceled -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnConfirm;
                @Back.started -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnBack;
                @Back.performed -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnBack;
                @Back.canceled -= m_Wrapper.m_MenuControlsActionsCallbackInterface.OnBack;
            }
            m_Wrapper.m_MenuControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Confirm.started += instance.OnConfirm;
                @Confirm.performed += instance.OnConfirm;
                @Confirm.canceled += instance.OnConfirm;
                @Back.started += instance.OnBack;
                @Back.performed += instance.OnBack;
                @Back.canceled += instance.OnBack;
            }
        }
    }
    public MenuControlsActions @MenuControls => new MenuControlsActions(this);

    // DrivingControls
    private readonly InputActionMap m_DrivingControls;
    private IDrivingControlsActions m_DrivingControlsActionsCallbackInterface;
    private readonly InputAction m_DrivingControls_Steering;
    private readonly InputAction m_DrivingControls_Gas;
    private readonly InputAction m_DrivingControls_Brakes;
    public struct DrivingControlsActions
    {
        private @MainControls m_Wrapper;
        public DrivingControlsActions(@MainControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Steering => m_Wrapper.m_DrivingControls_Steering;
        public InputAction @Gas => m_Wrapper.m_DrivingControls_Gas;
        public InputAction @Brakes => m_Wrapper.m_DrivingControls_Brakes;
        public InputActionMap Get() { return m_Wrapper.m_DrivingControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DrivingControlsActions set) { return set.Get(); }
        public void SetCallbacks(IDrivingControlsActions instance)
        {
            if (m_Wrapper.m_DrivingControlsActionsCallbackInterface != null)
            {
                @Steering.started -= m_Wrapper.m_DrivingControlsActionsCallbackInterface.OnSteering;
                @Steering.performed -= m_Wrapper.m_DrivingControlsActionsCallbackInterface.OnSteering;
                @Steering.canceled -= m_Wrapper.m_DrivingControlsActionsCallbackInterface.OnSteering;
                @Gas.started -= m_Wrapper.m_DrivingControlsActionsCallbackInterface.OnGas;
                @Gas.performed -= m_Wrapper.m_DrivingControlsActionsCallbackInterface.OnGas;
                @Gas.canceled -= m_Wrapper.m_DrivingControlsActionsCallbackInterface.OnGas;
                @Brakes.started -= m_Wrapper.m_DrivingControlsActionsCallbackInterface.OnBrakes;
                @Brakes.performed -= m_Wrapper.m_DrivingControlsActionsCallbackInterface.OnBrakes;
                @Brakes.canceled -= m_Wrapper.m_DrivingControlsActionsCallbackInterface.OnBrakes;
            }
            m_Wrapper.m_DrivingControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Steering.started += instance.OnSteering;
                @Steering.performed += instance.OnSteering;
                @Steering.canceled += instance.OnSteering;
                @Gas.started += instance.OnGas;
                @Gas.performed += instance.OnGas;
                @Gas.canceled += instance.OnGas;
                @Brakes.started += instance.OnBrakes;
                @Brakes.performed += instance.OnBrakes;
                @Brakes.canceled += instance.OnBrakes;
            }
        }
    }
    public DrivingControlsActions @DrivingControls => new DrivingControlsActions(this);

    // WalkingControls
    private readonly InputActionMap m_WalkingControls;
    private IWalkingControlsActions m_WalkingControlsActionsCallbackInterface;
    private readonly InputAction m_WalkingControls_Newaction;
    public struct WalkingControlsActions
    {
        private @MainControls m_Wrapper;
        public WalkingControlsActions(@MainControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_WalkingControls_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_WalkingControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(WalkingControlsActions set) { return set.Get(); }
        public void SetCallbacks(IWalkingControlsActions instance)
        {
            if (m_Wrapper.m_WalkingControlsActionsCallbackInterface != null)
            {
                @Newaction.started -= m_Wrapper.m_WalkingControlsActionsCallbackInterface.OnNewaction;
                @Newaction.performed -= m_Wrapper.m_WalkingControlsActionsCallbackInterface.OnNewaction;
                @Newaction.canceled -= m_Wrapper.m_WalkingControlsActionsCallbackInterface.OnNewaction;
            }
            m_Wrapper.m_WalkingControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
            }
        }
    }
    public WalkingControlsActions @WalkingControls => new WalkingControlsActions(this);
    private int m_ControllersSchemeIndex = -1;
    public InputControlScheme ControllersScheme
    {
        get
        {
            if (m_ControllersSchemeIndex == -1) m_ControllersSchemeIndex = asset.FindControlSchemeIndex("Controllers");
            return asset.controlSchemes[m_ControllersSchemeIndex];
        }
    }
    private int m_KeyboardandMouseSchemeIndex = -1;
    public InputControlScheme KeyboardandMouseScheme
    {
        get
        {
            if (m_KeyboardandMouseSchemeIndex == -1) m_KeyboardandMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard and Mouse");
            return asset.controlSchemes[m_KeyboardandMouseSchemeIndex];
        }
    }
    public interface IMenuControlsActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnConfirm(InputAction.CallbackContext context);
        void OnBack(InputAction.CallbackContext context);
    }
    public interface IDrivingControlsActions
    {
        void OnSteering(InputAction.CallbackContext context);
        void OnGas(InputAction.CallbackContext context);
        void OnBrakes(InputAction.CallbackContext context);
    }
    public interface IWalkingControlsActions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
}
