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
                    ""name"": ""TeleportPos1"",
                    ""type"": ""PassThrough"",
                    ""id"": ""143b2a00-3118-463b-81ec-89d4fe377200"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TeleportPos2"",
                    ""type"": ""PassThrough"",
                    ""id"": ""f85dd838-e35d-44cf-8e67-9a7631a9fc96"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TeleportPos3"",
                    ""type"": ""PassThrough"",
                    ""id"": ""654b44b1-d9f7-457a-8057-020eb78eb795"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TeleportPos4"",
                    ""type"": ""PassThrough"",
                    ""id"": ""4d9aa048-f302-4ac5-a0b2-d40272548daa"",
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
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""46c7d098-78a3-4e4a-a898-846929b51eda"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TeleportPos1"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""right"",
                    ""id"": ""76b69a12-e53e-4f06-a923-e3444ee67f4f"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TeleportPos1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""bd350e95-b5d4-4a68-b242-f228ae2b89a6"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TeleportPos2"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""fbafdbb9-2025-430a-8fb0-72631dc28c1f"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TeleportPos2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""74d6dd7b-922f-42d6-ae34-e36e0d25aaea"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TeleportPos3"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""609488ff-64e7-4bbd-baf5-1115a7190e72"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TeleportPos3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""3b05a115-d7c3-4d7a-b870-a11e5e17a295"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TeleportPos4"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""down"",
                    ""id"": ""9e4c8ca8-903d-4a7c-a944-c235e7694387"",
                    ""path"": ""<Keyboard>/4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TeleportPos4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
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
        m_Locomotion_TeleportPos1 = m_Locomotion.FindAction("TeleportPos1", throwIfNotFound: true);
        m_Locomotion_TeleportPos2 = m_Locomotion.FindAction("TeleportPos2", throwIfNotFound: true);
        m_Locomotion_TeleportPos3 = m_Locomotion.FindAction("TeleportPos3", throwIfNotFound: true);
        m_Locomotion_TeleportPos4 = m_Locomotion.FindAction("TeleportPos4", throwIfNotFound: true);
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
    private readonly InputAction m_Locomotion_TeleportPos1;
    private readonly InputAction m_Locomotion_TeleportPos2;
    private readonly InputAction m_Locomotion_TeleportPos3;
    private readonly InputAction m_Locomotion_TeleportPos4;
    public struct LocomotionActions
    {
        private @Controls m_Wrapper;
        public LocomotionActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Look => m_Wrapper.m_Locomotion_Look;
        public InputAction @Reset => m_Wrapper.m_Locomotion_Reset;
        public InputAction @Shoot => m_Wrapper.m_Locomotion_Shoot;
        public InputAction @TeleportPos1 => m_Wrapper.m_Locomotion_TeleportPos1;
        public InputAction @TeleportPos2 => m_Wrapper.m_Locomotion_TeleportPos2;
        public InputAction @TeleportPos3 => m_Wrapper.m_Locomotion_TeleportPos3;
        public InputAction @TeleportPos4 => m_Wrapper.m_Locomotion_TeleportPos4;
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
                @TeleportPos1.started -= m_Wrapper.m_LocomotionActionsCallbackInterface.OnTeleportPos1;
                @TeleportPos1.performed -= m_Wrapper.m_LocomotionActionsCallbackInterface.OnTeleportPos1;
                @TeleportPos1.canceled -= m_Wrapper.m_LocomotionActionsCallbackInterface.OnTeleportPos1;
                @TeleportPos2.started -= m_Wrapper.m_LocomotionActionsCallbackInterface.OnTeleportPos2;
                @TeleportPos2.performed -= m_Wrapper.m_LocomotionActionsCallbackInterface.OnTeleportPos2;
                @TeleportPos2.canceled -= m_Wrapper.m_LocomotionActionsCallbackInterface.OnTeleportPos2;
                @TeleportPos3.started -= m_Wrapper.m_LocomotionActionsCallbackInterface.OnTeleportPos3;
                @TeleportPos3.performed -= m_Wrapper.m_LocomotionActionsCallbackInterface.OnTeleportPos3;
                @TeleportPos3.canceled -= m_Wrapper.m_LocomotionActionsCallbackInterface.OnTeleportPos3;
                @TeleportPos4.started -= m_Wrapper.m_LocomotionActionsCallbackInterface.OnTeleportPos4;
                @TeleportPos4.performed -= m_Wrapper.m_LocomotionActionsCallbackInterface.OnTeleportPos4;
                @TeleportPos4.canceled -= m_Wrapper.m_LocomotionActionsCallbackInterface.OnTeleportPos4;
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
                @TeleportPos1.started += instance.OnTeleportPos1;
                @TeleportPos1.performed += instance.OnTeleportPos1;
                @TeleportPos1.canceled += instance.OnTeleportPos1;
                @TeleportPos2.started += instance.OnTeleportPos2;
                @TeleportPos2.performed += instance.OnTeleportPos2;
                @TeleportPos2.canceled += instance.OnTeleportPos2;
                @TeleportPos3.started += instance.OnTeleportPos3;
                @TeleportPos3.performed += instance.OnTeleportPos3;
                @TeleportPos3.canceled += instance.OnTeleportPos3;
                @TeleportPos4.started += instance.OnTeleportPos4;
                @TeleportPos4.performed += instance.OnTeleportPos4;
                @TeleportPos4.canceled += instance.OnTeleportPos4;
            }
        }
    }
    public LocomotionActions @Locomotion => new LocomotionActions(this);
    public interface ILocomotionActions
    {
        void OnLook(InputAction.CallbackContext context);
        void OnReset(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnTeleportPos1(InputAction.CallbackContext context);
        void OnTeleportPos2(InputAction.CallbackContext context);
        void OnTeleportPos3(InputAction.CallbackContext context);
        void OnTeleportPos4(InputAction.CallbackContext context);
    }
}
