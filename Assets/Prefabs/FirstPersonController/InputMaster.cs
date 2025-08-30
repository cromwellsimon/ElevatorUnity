// GENERATED AUTOMATICALLY FROM 'Assets/Prefabs/FirstPersonController/InputMaster.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputMaster : IInputActionCollection, IDisposable
{
    private InputActionAsset asset;
    public @InputMaster()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputMaster"",
    ""maps"": [
        {
            ""name"": ""FirstPersonController"",
            ""id"": ""184798a0-34a2-4d45-9b31-b72ba6fdc84e"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""f636119d-2020-4c8b-9de3-ebd66a155a62"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""PassThrough"",
                    ""id"": ""657f0a50-3d6c-4988-9f27-04d5f77aaa49"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""K+M"",
                    ""id"": ""37dec17d-7400-4b61-9855-e27d435e3756"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Up"",
                    ""id"": ""61a76297-f3ec-4958-abe8-2ab2b8a218df"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""K+M"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Down"",
                    ""id"": ""3b2d6ab6-4598-44e3-ac88-edbbfe8dec5d"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""K+M"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Left"",
                    ""id"": ""37068d4a-c2d4-42d2-96b8-719a85e39eca"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""K+M"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Right"",
                    ""id"": ""221f4812-a477-4029-8753-65594d91a5d9"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""K+M"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""72c284bd-15f7-4c1d-8b27-de5190302972"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""VR WMR"",
                    ""id"": ""053e915b-1455-4e58-b0b6-828009f1a5ad"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Up"",
                    ""id"": ""43f2c77c-e7da-485c-93f4-256684387539"",
                    ""path"": ""<OpenVRControllerWMR>{LeftHand}/joystick/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""VR "",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Down"",
                    ""id"": ""e9de8631-b088-4275-af03-16fb124f64ac"",
                    ""path"": ""<OpenVRControllerWMR>{LeftHand}/joystick/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""VR "",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Left"",
                    ""id"": ""8824db05-2752-4203-a423-96957ceb1eff"",
                    ""path"": ""<OpenVRControllerWMR>{LeftHand}/joystick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""VR "",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Right"",
                    ""id"": ""01feb184-00de-44ac-85b8-9e3b48150d31"",
                    ""path"": ""<OpenVRControllerWMR>{LeftHand}/joystick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""VR "",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""VR Oculus"",
                    ""id"": ""7ea74b8e-92d2-4fcd-aaa5-4aef1be4ffbe"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Up"",
                    ""id"": ""ed54cae6-0fa7-4e58-ad6a-4df1b9512e44"",
                    ""path"": ""<OpenVROculusTouchController>/thumbstick/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""VR "",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Down"",
                    ""id"": ""e0eb4130-fd73-47d9-b684-74e96598c9fb"",
                    ""path"": ""<OpenVROculusTouchController>/thumbstick/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""VR "",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Left"",
                    ""id"": ""84d4f4d4-22fa-433c-b5b3-4695237f6752"",
                    ""path"": ""<OpenVROculusTouchController>/thumbstick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""VR "",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Right"",
                    ""id"": ""4e7ca32b-4e10-444a-afc7-b5e094751a25"",
                    ""path"": ""<OpenVROculusTouchController>/thumbstick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""VR "",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""VR Vive"",
                    ""id"": ""01f8b86a-19e4-4f13-b8e9-18a3a719adfe"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Up"",
                    ""id"": ""5225ae59-1105-4d7d-a408-2a9ac99c1b16"",
                    ""path"": ""<ViveWand>{LeftHand}/trackpad/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""VR "",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Down"",
                    ""id"": ""69bedb5c-f356-430e-9481-5a2faec85a51"",
                    ""path"": ""<ViveWand>{LeftHand}/trackpad/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""VR "",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Left"",
                    ""id"": ""9d63d58e-3cb4-4554-b1d6-2c47310a9ae7"",
                    ""path"": ""<ViveWand>{LeftHand}/trackpad/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""VR "",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Right"",
                    ""id"": ""75bc1f90-1f31-4913-b016-53679a824d8a"",
                    ""path"": ""<ViveWand>{LeftHand}/trackpad/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""VR "",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""OpenVR"",
                    ""id"": ""e5b418d5-7072-4985-b749-a294574bcc86"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Up"",
                    ""id"": ""be4b54e2-7343-4ce0-819a-1d0e4cdedff4"",
                    ""path"": ""<OpenVRHMD>/devicePosition/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""VR "",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Down"",
                    ""id"": ""99eb7cc9-32bc-4919-beb9-4d639e21fc58"",
                    ""path"": ""<OpenVRHMD>/devicePosition/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""VR "",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Left"",
                    ""id"": ""46784460-cbcf-43f3-b272-b6ee2c578bf9"",
                    ""path"": ""<OpenVRHMD>/devicePosition/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""VR "",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Right"",
                    ""id"": ""64b7729d-a62c-4f7f-85b3-f44fd2d1a1ae"",
                    ""path"": ""<OpenVRHMD>/devicePosition/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""VR "",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""ca783596-a69b-445b-8a7d-4cb0a5b9493c"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""K+M"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d0d5e2dd-c0c8-4167-899b-9e6d9f1ee1bb"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""793996b0-a00c-4b96-8f7e-4ef28a739a73"",
                    ""path"": ""<OpenVRHMD>/deviceRotation"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""VR "",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""OpenVR"",
                    ""id"": ""e3b40730-b52d-47c7-90cb-56548e6f2cd6"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Up"",
                    ""id"": ""3090a387-b89a-4fb8-8295-dd3e54c3154c"",
                    ""path"": ""<OpenVRHMD>/deviceRotation/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""VR "",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Down"",
                    ""id"": ""27f8a720-aadc-4e34-966d-70b437112fd2"",
                    ""path"": ""<OpenVRHMD>/deviceRotation/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""VR "",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Left"",
                    ""id"": ""14575db6-fa9a-4cd8-a331-60131469ab5c"",
                    ""path"": ""<OpenVRHMD>/deviceRotation/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""VR "",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Right"",
                    ""id"": ""3b609991-7349-4b0d-93f3-e31bb4e706c5"",
                    ""path"": ""<OpenVRHMD>/deviceRotation/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""VR "",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""K+M"",
            ""bindingGroup"": ""K+M"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": true,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""VR "",
            ""bindingGroup"": ""VR "",
            ""devices"": [
                {
                    ""devicePath"": ""<OpenVRHMD>"",
                    ""isOptional"": true,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<XRController>{LeftHand}"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // FirstPersonController
        m_FirstPersonController = asset.FindActionMap("FirstPersonController", throwIfNotFound: true);
        m_FirstPersonController_Move = m_FirstPersonController.FindAction("Move", throwIfNotFound: true);
        m_FirstPersonController_Look = m_FirstPersonController.FindAction("Look", throwIfNotFound: true);
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

    // FirstPersonController
    private readonly InputActionMap m_FirstPersonController;
    private IFirstPersonControllerActions m_FirstPersonControllerActionsCallbackInterface;
    private readonly InputAction m_FirstPersonController_Move;
    private readonly InputAction m_FirstPersonController_Look;
    public struct FirstPersonControllerActions
    {
        private @InputMaster m_Wrapper;
        public FirstPersonControllerActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_FirstPersonController_Move;
        public InputAction @Look => m_Wrapper.m_FirstPersonController_Look;
        public InputActionMap Get() { return m_Wrapper.m_FirstPersonController; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(FirstPersonControllerActions set) { return set.Get(); }
        public void SetCallbacks(IFirstPersonControllerActions instance)
        {
            if (m_Wrapper.m_FirstPersonControllerActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_FirstPersonControllerActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_FirstPersonControllerActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_FirstPersonControllerActionsCallbackInterface.OnMove;
                @Look.started -= m_Wrapper.m_FirstPersonControllerActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_FirstPersonControllerActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_FirstPersonControllerActionsCallbackInterface.OnLook;
            }
            m_Wrapper.m_FirstPersonControllerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
            }
        }
    }
    public FirstPersonControllerActions @FirstPersonController => new FirstPersonControllerActions(this);
    private int m_KMSchemeIndex = -1;
    public InputControlScheme KMScheme
    {
        get
        {
            if (m_KMSchemeIndex == -1) m_KMSchemeIndex = asset.FindControlSchemeIndex("K+M");
            return asset.controlSchemes[m_KMSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    private int m_VRSchemeIndex = -1;
    public InputControlScheme VRScheme
    {
        get
        {
            if (m_VRSchemeIndex == -1) m_VRSchemeIndex = asset.FindControlSchemeIndex("VR ");
            return asset.controlSchemes[m_VRSchemeIndex];
        }
    }
    public interface IFirstPersonControllerActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
    }
}
