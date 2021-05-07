// GENERATED AUTOMATICALLY FROM 'Assets/Input/Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Locomotion"",
            ""id"": ""6ce63e2a-fe7f-4a28-8210-52ab98d1dc3f"",
            ""actions"": [
                {
                    ""name"": ""Look"",
                    ""type"": ""PassThrough"",
                    ""id"": ""aec5ad23-f982-41fe-8562-9e1653cef961"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Reset"",
                    ""type"": ""Button"",
                    ""id"": ""43eff502-ce15-4e61-9f56-d36a56ad5748"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""7c6cf64c-e009-4ef3-96a4-cb9cf3859533"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Teleport1"",
                    ""type"": ""Button"",
                    ""id"": ""32f8df4b-df9e-47b0-99d4-c40140c2d379"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Teleport2"",
                    ""type"": ""Button"",
                    ""id"": ""1e0307a1-b895-47a0-aeac-4f7943a16747"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Teleport3"",
                    ""type"": ""Button"",
                    ""id"": ""7b5aa28a-907c-42c2-b81e-8bd7b5d2ecd5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Teleport4"",
                    ""type"": ""Button"",
                    ""id"": ""2861aeae-f38d-4771-8343-b07671904e6d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""060f4681-5e60-4cc8-9a90-ffc6b01c82e9"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ebfb98cd-c769-4ecd-b549-54e42d1fe2c4"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Reset"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7cd8e61f-cc9b-4a33-9ea2-cd1599189a37"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b920ab21-6737-4e7a-8126-57cc590a756b"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Teleport1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a51f4950-fd1a-4ce2-8720-636e0e5602b9"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Teleport2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cb92c493-897e-4305-97c6-8b4b793fda4f"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Teleport3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4121f443-ecee-4a8f-b9d2-3e617e98a919"",
                    ""path"": ""<Keyboard>/4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Teleport4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Locomotion
        m_Locomotion = asset.FindActionMap("Locomotion", throwIfNotFound: true);
        m_Locomotion_Look = m_Locomotion.FindAction("Look", throwIfNotFound: true);
        m_Locomotion_Reset = m_Locomotion.FindAction("Reset", throwIfNotFound: true);
        m_Locomotion_Shoot = m_Locomotion.FindAction("Shoot", throwIfNotFound: true);
        m_Locomotion_Teleport1 = m_Locomotion.FindAction("Teleport1", throwIfNotFound: true);
        m_Locomotion_Teleport2 = m_Locomotion.FindAction("Teleport2", throwIfNotFound: true);
        m_Locomotion_Teleport3 = m_Locomotion.FindAction("Teleport3", throwIfNotFound: true);
        m_Locomotion_Teleport4 = m_Locomotion.FindAction("Teleport4", throwIfNotFound: true);
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

    // Locomotion
    private readonly InputActionMap m_Locomotion;
    private ILocomotionActions m_LocomotionActionsCallbackInterface;
    private readonly InputAction m_Locomotion_Look;
    private readonly InputAction m_Locomotion_Reset;
    private readonly InputAction m_Locomotion_Shoot;
    private readonly InputAction m_Locomotion_Teleport1;
    private readonly InputAction m_Locomotion_Teleport2;
    private readonly InputAction m_Locomotion_Teleport3;
    private readonly InputAction m_Locomotion_Teleport4;
    public struct LocomotionActions
    {
        private @Controls m_Wrapper;
        public LocomotionActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Look => m_Wrapper.m_Locomotion_Look;
        public InputAction @Reset => m_Wrapper.m_Locomotion_Reset;
        public InputAction @Shoot => m_Wrapper.m_Locomotion_Shoot;
        public InputAction @Teleport1 => m_Wrapper.m_Locomotion_Teleport1;
        public InputAction @Teleport2 => m_Wrapper.m_Locomotion_Teleport2;
        public InputAction @Teleport3 => m_Wrapper.m_Locomotion_Teleport3;
        public InputAction @Teleport4 => m_Wrapper.m_Locomotion_Teleport4;
        public InputActionMap Get() { return m_Wrapper.m_Locomotion; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(LocomotionActions set) { return set.Get(); }
        public void SetCallbacks(ILocomotionActions instance)
        {
            if (m_Wrapper.m_LocomotionActionsCallbackInterface != null)
            {
                @Look.started -= m_Wrapper.m_LocomotionActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_LocomotionActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_LocomotionActionsCallbackInterface.OnLook;
                @Reset.started -= m_Wrapper.m_LocomotionActionsCallbackInterface.OnReset;
                @Reset.performed -= m_Wrapper.m_LocomotionActionsCallbackInterface.OnReset;
                @Reset.canceled -= m_Wrapper.m_LocomotionActionsCallbackInterface.OnReset;
                @Shoot.started -= m_Wrapper.m_LocomotionActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_LocomotionActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_LocomotionActionsCallbackInterface.OnShoot;
                @Teleport1.started -= m_Wrapper.m_LocomotionActionsCallbackInterface.OnTeleport1;
                @Teleport1.performed -= m_Wrapper.m_LocomotionActionsCallbackInterface.OnTeleport1;
                @Teleport1.canceled -= m_Wrapper.m_LocomotionActionsCallbackInterface.OnTeleport1;
                @Teleport2.started -= m_Wrapper.m_LocomotionActionsCallbackInterface.OnTeleport2;
                @Teleport2.performed -= m_Wrapper.m_LocomotionActionsCallbackInterface.OnTeleport2;
                @Teleport2.canceled -= m_Wrapper.m_LocomotionActionsCallbackInterface.OnTeleport2;
                @Teleport3.started -= m_Wrapper.m_LocomotionActionsCallbackInterface.OnTeleport3;
                @Teleport3.performed -= m_Wrapper.m_LocomotionActionsCallbackInterface.OnTeleport3;
                @Teleport3.canceled -= m_Wrapper.m_LocomotionActionsCallbackInterface.OnTeleport3;
                @Teleport4.started -= m_Wrapper.m_LocomotionActionsCallbackInterface.OnTeleport4;
                @Teleport4.performed -= m_Wrapper.m_LocomotionActionsCallbackInterface.OnTeleport4;
                @Teleport4.canceled -= m_Wrapper.m_LocomotionActionsCallbackInterface.OnTeleport4;
            }
            m_Wrapper.m_LocomotionActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @Reset.started += instance.OnReset;
                @Reset.performed += instance.OnReset;
                @Reset.canceled += instance.OnReset;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @Teleport1.started += instance.OnTeleport1;
                @Teleport1.performed += instance.OnTeleport1;
                @Teleport1.canceled += instance.OnTeleport1;
                @Teleport2.started += instance.OnTeleport2;
                @Teleport2.performed += instance.OnTeleport2;
                @Teleport2.canceled += instance.OnTeleport2;
                @Teleport3.started += instance.OnTeleport3;
                @Teleport3.performed += instance.OnTeleport3;
                @Teleport3.canceled += instance.OnTeleport3;
                @Teleport4.started += instance.OnTeleport4;
                @Teleport4.performed += instance.OnTeleport4;
                @Teleport4.canceled += instance.OnTeleport4;
            }
        }
    }
    public LocomotionActions @Locomotion => new LocomotionActions(this);
    public interface ILocomotionActions
    {
        void OnLook(InputAction.CallbackContext context);
        void OnReset(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnTeleport1(InputAction.CallbackContext context);
        void OnTeleport2(InputAction.CallbackContext context);
        void OnTeleport3(InputAction.CallbackContext context);
        void OnTeleport4(InputAction.CallbackContext context);
    }
}
