// GENERATED AUTOMATICALLY FROM 'Assets/Properties/InputSystem/MainControls.inputactions'

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
                    ""groups"": ""DefaultKeyboardMouse"",
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
                    ""groups"": ""DefaultKeyboardMouse"",
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
                    ""groups"": ""DefaultKeyboardMouse"",
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
                    ""groups"": ""DefaultKeyboardMouse"",
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
                    ""groups"": ""DefaultKeyboardMouse"",
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
                    ""groups"": ""DefaultKeyboardMouse"",
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
                    ""groups"": ""DefaultKeyboardMouse"",
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
                    ""groups"": ""DefaultKeyboardMouse"",
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
                    ""groups"": ""DefaultControllers"",
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
                    ""groups"": ""DefaultControllers"",
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
                    ""groups"": ""DefaultControllers"",
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
                    ""groups"": ""DefaultControllers"",
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
                    ""groups"": ""DefaultControllers"",
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
                    ""groups"": ""DefaultControllers"",
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
                    ""groups"": ""DefaultControllers"",
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
                    ""groups"": ""DefaultControllers"",
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
                    ""groups"": ""DefaultKeyboardMouse"",
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
                    ""groups"": ""DefaultControllers"",
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
                    ""groups"": ""DefaultKeyboardMouse"",
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
                    ""groups"": ""DefaultControllers"",
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
                },
                {
                    ""name"": ""ClutchButton"",
                    ""type"": ""Value"",
                    ""id"": ""faa37e7b-291a-4686-8962-dba438fe809d"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""GearUpButton"",
                    ""type"": ""Button"",
                    ""id"": ""1e78e3d3-b1d6-4519-b140-d39c9256aada"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""GearDownButton"",
                    ""type"": ""Button"",
                    ""id"": ""567fa840-e173-44dc-9585-be154c3bacb0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""HandBrakeButton"",
                    ""type"": ""Button"",
                    ""id"": ""e11bb9a4-b1b5-4946-bed6-ea18a930e854"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pitch"",
                    ""type"": ""Value"",
                    ""id"": ""644e3ed8-813f-4ca2-a0d8-409e3dfe8194"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Roll"",
                    ""type"": ""Value"",
                    ""id"": ""99215c48-5c47-4d36-8e66-db030383709f"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Yaw"",
                    ""type"": ""Value"",
                    ""id"": ""30020d90-3339-41a6-98a0-7b91ce80e735"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SwitchCameraButton"",
                    ""type"": ""Button"",
                    ""id"": ""9080f2f7-1109-41bf-b157-465f1b4debde"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
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
                    ""groups"": ""DefaultControllers"",
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
                    ""groups"": ""DefaultControllers"",
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
                    ""groups"": ""DefaultKeyboardMouse"",
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
                    ""groups"": ""DefaultKeyboardMouse"",
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
                    ""groups"": ""DefaultControllers"",
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
                    ""groups"": ""DefaultControllers"",
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
                    ""groups"": ""DefaultKeyboardMouse"",
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
                    ""groups"": ""DefaultControllers"",
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
                    ""groups"": ""DefaultControllers"",
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
                    ""groups"": ""DefaultKeyboardMouse"",
                    ""action"": ""Brakes"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""LeftStick(LeftandRight)"",
                    ""id"": ""71e5f343-4f07-4b6b-b7f3-d3437a0cd232"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Yaw"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""52f10f07-fb83-4a5c-911c-9338299b080a"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""DefaultControllers"",
                    ""action"": ""Yaw"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""d4c8fa0c-64cf-4e4b-8ecb-c4c164732132"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""DefaultControllers"",
                    ""action"": ""Yaw"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""A and D Keys"",
                    ""id"": ""44da6be6-95f3-4456-b937-6e2110e7f6d4"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Yaw"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""b29fe66a-9b44-4907-8398-aae1afcc7bf9"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""DefaultKeyboardMouse"",
                    ""action"": ""Yaw"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""d296462c-6fa8-4403-8aaf-5a69767104f5"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""DefaultKeyboardMouse"",
                    ""action"": ""Yaw"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""LeftShift"",
                    ""id"": ""13e166dc-8dbe-425b-804a-0dd515d76c18"",
                    ""path"": ""1DAxis(minValue=0,whichSideWins=1)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ClutchButton"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""807fa20a-231e-4f09-b49c-751a111c186e"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""DefaultKeyboardMouse"",
                    ""action"": ""ClutchButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""0f5f51d1-86a6-4121-9f0d-4177542372cf"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""DefaultKeyboardMouse"",
                    ""action"": ""ClutchButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""LeftBumper"",
                    ""id"": ""29e09656-c48d-477b-9ac0-3d4478ea9043"",
                    ""path"": ""1DAxis(minValue=0)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ClutchButton"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""94a63247-5820-40e1-9de7-75d67a78ef68"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""DefaultControllers"",
                    ""action"": ""ClutchButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""47d25d35-6488-4945-b143-2442c0c30c69"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""DefaultControllers"",
                    ""action"": ""ClutchButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""ArrowKeysHorizontal"",
                    ""id"": ""d752475c-878f-4e35-91a6-34c16c4e0614"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Roll"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""97873585-13ed-4398-aa6e-7328e51861d8"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""DefaultKeyboardMouse"",
                    ""action"": ""Roll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""1f44a5df-53ae-447f-9969-7cba9249e156"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""DefaultKeyboardMouse"",
                    ""action"": ""Roll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""RightJoystick(Horizontal)"",
                    ""id"": ""683374b5-c56f-47df-b944-52b40fc3bac5"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Roll"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""b6dac1a0-dcb9-4b5e-9730-2aa2d325682c"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""DefaultControllers"",
                    ""action"": ""Roll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""a861064f-eb78-45a4-b279-b505e40c9e06"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""DefaultControllers"",
                    ""action"": ""Roll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""ArrowKeysVertical"",
                    ""id"": ""39773701-3d13-4abd-b651-d0c052d60ecc"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pitch"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""d1b9768a-4ee0-4fe5-af65-da9bac1b56cb"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""DefaultKeyboardMouse"",
                    ""action"": ""Pitch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""6cf10855-d1de-4cd1-bdb5-b7e74d4b93c9"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""DefaultKeyboardMouse"",
                    ""action"": ""Pitch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""RightStick(Vertical)"",
                    ""id"": ""6503f5f3-d4b7-4dd7-ad1b-70f4c6df5393"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pitch"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""50db8770-a1f1-4b1e-b278-6ee911e62952"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""DefaultControllers"",
                    ""action"": ""Pitch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""6c265623-b50e-4078-b699-fa2a8c9eead1"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""DefaultControllers"",
                    ""action"": ""Pitch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""83ff2a62-1324-4723-9672-4ea3fffbd50d"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""DefaultKeyboardMouse"",
                    ""action"": ""GearUpButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2ff893c3-8499-4911-9139-77263aefb847"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""DefaultControllers"",
                    ""action"": ""GearUpButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0f07369c-f6a4-459b-bbec-ff6af4c9d161"",
                    ""path"": ""<Keyboard>/rightShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""DefaultKeyboardMouse"",
                    ""action"": ""GearDownButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""806c0b83-4356-42ee-a023-4f3500d746ef"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""DefaultControllers"",
                    ""action"": ""GearDownButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0b7641f4-11ce-4c81-818c-df8af5f2371c"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""DefaultKeyboardMouse"",
                    ""action"": ""HandBrakeButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0466aea2-2bce-4a3d-85dd-bd64fbfe525e"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""DefaultControllers"",
                    ""action"": ""HandBrakeButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c7d9dff6-a9eb-49c4-a4ca-b4fe6587af81"",
                    ""path"": ""<Gamepad>/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""DefaultControllers"",
                    ""action"": ""SwitchCameraButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0b5711a5-6d06-46d0-821d-3448850796a2"",
                    ""path"": ""<Keyboard>/tab"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""DefaultKeyboardMouse"",
                    ""action"": ""SwitchCameraButton"",
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
                    ""groups"": ""DefaultControllers"",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""DefaultControllers"",
            ""bindingGroup"": ""DefaultControllers"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""DefaultKeyboardMouse"",
            ""bindingGroup"": ""DefaultKeyboardMouse"",
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
        m_DrivingControls_ClutchButton = m_DrivingControls.FindAction("ClutchButton", throwIfNotFound: true);
        m_DrivingControls_GearUpButton = m_DrivingControls.FindAction("GearUpButton", throwIfNotFound: true);
        m_DrivingControls_GearDownButton = m_DrivingControls.FindAction("GearDownButton", throwIfNotFound: true);
        m_DrivingControls_HandBrakeButton = m_DrivingControls.FindAction("HandBrakeButton", throwIfNotFound: true);
        m_DrivingControls_Pitch = m_DrivingControls.FindAction("Pitch", throwIfNotFound: true);
        m_DrivingControls_Roll = m_DrivingControls.FindAction("Roll", throwIfNotFound: true);
        m_DrivingControls_Yaw = m_DrivingControls.FindAction("Yaw", throwIfNotFound: true);
        m_DrivingControls_SwitchCameraButton = m_DrivingControls.FindAction("SwitchCameraButton", throwIfNotFound: true);
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
    private readonly InputAction m_DrivingControls_ClutchButton;
    private readonly InputAction m_DrivingControls_GearUpButton;
    private readonly InputAction m_DrivingControls_GearDownButton;
    private readonly InputAction m_DrivingControls_HandBrakeButton;
    private readonly InputAction m_DrivingControls_Pitch;
    private readonly InputAction m_DrivingControls_Roll;
    private readonly InputAction m_DrivingControls_Yaw;
    private readonly InputAction m_DrivingControls_SwitchCameraButton;
    public struct DrivingControlsActions
    {
        private @MainControls m_Wrapper;
        public DrivingControlsActions(@MainControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Steering => m_Wrapper.m_DrivingControls_Steering;
        public InputAction @Gas => m_Wrapper.m_DrivingControls_Gas;
        public InputAction @Brakes => m_Wrapper.m_DrivingControls_Brakes;
        public InputAction @ClutchButton => m_Wrapper.m_DrivingControls_ClutchButton;
        public InputAction @GearUpButton => m_Wrapper.m_DrivingControls_GearUpButton;
        public InputAction @GearDownButton => m_Wrapper.m_DrivingControls_GearDownButton;
        public InputAction @HandBrakeButton => m_Wrapper.m_DrivingControls_HandBrakeButton;
        public InputAction @Pitch => m_Wrapper.m_DrivingControls_Pitch;
        public InputAction @Roll => m_Wrapper.m_DrivingControls_Roll;
        public InputAction @Yaw => m_Wrapper.m_DrivingControls_Yaw;
        public InputAction @SwitchCameraButton => m_Wrapper.m_DrivingControls_SwitchCameraButton;
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
                @ClutchButton.started -= m_Wrapper.m_DrivingControlsActionsCallbackInterface.OnClutchButton;
                @ClutchButton.performed -= m_Wrapper.m_DrivingControlsActionsCallbackInterface.OnClutchButton;
                @ClutchButton.canceled -= m_Wrapper.m_DrivingControlsActionsCallbackInterface.OnClutchButton;
                @GearUpButton.started -= m_Wrapper.m_DrivingControlsActionsCallbackInterface.OnGearUpButton;
                @GearUpButton.performed -= m_Wrapper.m_DrivingControlsActionsCallbackInterface.OnGearUpButton;
                @GearUpButton.canceled -= m_Wrapper.m_DrivingControlsActionsCallbackInterface.OnGearUpButton;
                @GearDownButton.started -= m_Wrapper.m_DrivingControlsActionsCallbackInterface.OnGearDownButton;
                @GearDownButton.performed -= m_Wrapper.m_DrivingControlsActionsCallbackInterface.OnGearDownButton;
                @GearDownButton.canceled -= m_Wrapper.m_DrivingControlsActionsCallbackInterface.OnGearDownButton;
                @HandBrakeButton.started -= m_Wrapper.m_DrivingControlsActionsCallbackInterface.OnHandBrakeButton;
                @HandBrakeButton.performed -= m_Wrapper.m_DrivingControlsActionsCallbackInterface.OnHandBrakeButton;
                @HandBrakeButton.canceled -= m_Wrapper.m_DrivingControlsActionsCallbackInterface.OnHandBrakeButton;
                @Pitch.started -= m_Wrapper.m_DrivingControlsActionsCallbackInterface.OnPitch;
                @Pitch.performed -= m_Wrapper.m_DrivingControlsActionsCallbackInterface.OnPitch;
                @Pitch.canceled -= m_Wrapper.m_DrivingControlsActionsCallbackInterface.OnPitch;
                @Roll.started -= m_Wrapper.m_DrivingControlsActionsCallbackInterface.OnRoll;
                @Roll.performed -= m_Wrapper.m_DrivingControlsActionsCallbackInterface.OnRoll;
                @Roll.canceled -= m_Wrapper.m_DrivingControlsActionsCallbackInterface.OnRoll;
                @Yaw.started -= m_Wrapper.m_DrivingControlsActionsCallbackInterface.OnYaw;
                @Yaw.performed -= m_Wrapper.m_DrivingControlsActionsCallbackInterface.OnYaw;
                @Yaw.canceled -= m_Wrapper.m_DrivingControlsActionsCallbackInterface.OnYaw;
                @SwitchCameraButton.started -= m_Wrapper.m_DrivingControlsActionsCallbackInterface.OnSwitchCameraButton;
                @SwitchCameraButton.performed -= m_Wrapper.m_DrivingControlsActionsCallbackInterface.OnSwitchCameraButton;
                @SwitchCameraButton.canceled -= m_Wrapper.m_DrivingControlsActionsCallbackInterface.OnSwitchCameraButton;
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
                @ClutchButton.started += instance.OnClutchButton;
                @ClutchButton.performed += instance.OnClutchButton;
                @ClutchButton.canceled += instance.OnClutchButton;
                @GearUpButton.started += instance.OnGearUpButton;
                @GearUpButton.performed += instance.OnGearUpButton;
                @GearUpButton.canceled += instance.OnGearUpButton;
                @GearDownButton.started += instance.OnGearDownButton;
                @GearDownButton.performed += instance.OnGearDownButton;
                @GearDownButton.canceled += instance.OnGearDownButton;
                @HandBrakeButton.started += instance.OnHandBrakeButton;
                @HandBrakeButton.performed += instance.OnHandBrakeButton;
                @HandBrakeButton.canceled += instance.OnHandBrakeButton;
                @Pitch.started += instance.OnPitch;
                @Pitch.performed += instance.OnPitch;
                @Pitch.canceled += instance.OnPitch;
                @Roll.started += instance.OnRoll;
                @Roll.performed += instance.OnRoll;
                @Roll.canceled += instance.OnRoll;
                @Yaw.started += instance.OnYaw;
                @Yaw.performed += instance.OnYaw;
                @Yaw.canceled += instance.OnYaw;
                @SwitchCameraButton.started += instance.OnSwitchCameraButton;
                @SwitchCameraButton.performed += instance.OnSwitchCameraButton;
                @SwitchCameraButton.canceled += instance.OnSwitchCameraButton;
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
    private int m_DefaultControllersSchemeIndex = -1;
    public InputControlScheme DefaultControllersScheme
    {
        get
        {
            if (m_DefaultControllersSchemeIndex == -1) m_DefaultControllersSchemeIndex = asset.FindControlSchemeIndex("DefaultControllers");
            return asset.controlSchemes[m_DefaultControllersSchemeIndex];
        }
    }
    private int m_DefaultKeyboardMouseSchemeIndex = -1;
    public InputControlScheme DefaultKeyboardMouseScheme
    {
        get
        {
            if (m_DefaultKeyboardMouseSchemeIndex == -1) m_DefaultKeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("DefaultKeyboardMouse");
            return asset.controlSchemes[m_DefaultKeyboardMouseSchemeIndex];
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
        void OnClutchButton(InputAction.CallbackContext context);
        void OnGearUpButton(InputAction.CallbackContext context);
        void OnGearDownButton(InputAction.CallbackContext context);
        void OnHandBrakeButton(InputAction.CallbackContext context);
        void OnPitch(InputAction.CallbackContext context);
        void OnRoll(InputAction.CallbackContext context);
        void OnYaw(InputAction.CallbackContext context);
        void OnSwitchCameraButton(InputAction.CallbackContext context);
    }
    public interface IWalkingControlsActions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
}
