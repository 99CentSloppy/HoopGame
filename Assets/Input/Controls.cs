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
                    ""name"": ""Teleport"",
                    ""type"": ""PassThrough"",
                    ""id"": ""143b2a00-3118-463b-81ec-89d4fe377200"",
                    ""expectedControlType"": ""Vector3"",
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
        m_Locomotion_Teleport = m_Locomotion.FindAction("Teleport", throwIfNotFound: true);
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
    private readonly InputAction m_Locomotion_Teleport;
    public struct LocomotionActions
    {
        private @Controls m_Wrapper;
        public LocomotionActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Look => m_Wrapper.m_Locomotion_Look;
        public InputAction @Reset => m_Wrapper.m_Locomotion_Reset;
        public InputAction @Shoot => m_Wrapper.m_Locomotion_Shoot;
        public InputAction @Teleport => m_Wrapper.m_Locomotion_Teleport;
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
                @Teleport.started -= m_Wrapper.m_LocomotionActionsCallbackInterface.OnTeleport;
                @Teleport.performed -= m_Wrapper.m_LocomotionActionsCallbackInterface.OnTeleport;
                @Teleport.canceled -= m_Wrapper.m_LocomotionActionsCallbackInterface.OnTeleport;
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
                @Teleport.started += instance.OnTeleport;
                @Teleport.performed += instance.OnTeleport;
                @Teleport.canceled += instance.OnTeleport;
            }
        }
    }
    public LocomotionActions @Locomotion => new LocomotionActions(this);
    public interface ILocomotionActions
    {
        void OnLook(InputAction.CallbackContext context);
        void OnReset(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnTeleport(InputAction.CallbackContext context);
    }
}
