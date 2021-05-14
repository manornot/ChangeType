// GENERATED AUTOMATICALLY FROM 'Assets/LevelEditor/InputManager.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputManager : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputManager()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputManager"",
    ""maps"": [
        {
            ""name"": ""Camera"",
            ""id"": ""c8b56065-2722-42c1-961c-bbeaafdb01b9"",
            ""actions"": [
                {
                    ""name"": ""Rotation"",
                    ""type"": ""Button"",
                    ""id"": ""e9bb109f-ccd7-44ff-b779-19c9add4b700"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""1c09321d-556b-455b-a732-b7106d00577f"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Zoom"",
                    ""type"": ""Button"",
                    ""id"": ""f3b64878-28bb-4fa0-9d34-bd70dd70b243"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""ef6300f5-56de-47d2-8f8a-5e898d33cb2f"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""a99a928d-baf5-412d-9e73-3dffa1247259"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""39520e92-9261-4e3e-be0d-86225dd5a88e"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""f58103e0-7957-4908-bb5b-fccf029471ed"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""6c28fe51-e736-43c4-af00-6c97ad1604ee"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""f4433e07-a095-4941-8d2d-8c62aea04e43"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""f33a5eb7-42f4-46fa-86fb-bb599abce228"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""76909482-177e-4f4b-8233-ea121a5b44a0"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""42681eac-1015-4a8c-b710-049a552108fd"",
                    ""path"": ""<Mouse>/scroll"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Palette"",
            ""id"": ""cc49a7ce-a67a-4448-bc8e-554444d0f0f0"",
            ""actions"": [
                {
                    ""name"": ""ChangeElement"",
                    ""type"": ""Button"",
                    ""id"": ""4c6cb561-b4c2-42e5-8a30-371f3ab2b8da"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""switcher"",
                    ""id"": ""a8be586d-49ae-478c-9efb-e46432535a7c"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeElement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""488a1e13-6895-4925-8d02-bd658c7b9a40"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeElement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""72f6b6fc-d606-42f3-ac2c-94bd457852d0"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeElement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Editor"",
            ""id"": ""82b6680b-dccf-4b7a-986c-152cd80c2b69"",
            ""actions"": [
                {
                    ""name"": ""PlaceElement"",
                    ""type"": ""Button"",
                    ""id"": ""34451323-5fc4-45ce-9bcf-3d60b95816ec"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DeleteElement"",
                    ""type"": ""Button"",
                    ""id"": ""b07bafb6-fc53-477a-84ca-effd480d1cae"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ChangeMode"",
                    ""type"": ""Button"",
                    ""id"": ""140004d0-114b-45d0-9e05-b189ff4d48fb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Save"",
                    ""type"": ""Button"",
                    ""id"": ""7be66356-fe6d-434f-a876-1f682ee03a32"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Load"",
                    ""type"": ""Button"",
                    ""id"": ""d503ae01-8d9e-4e9b-a5e4-e18c794658a9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""25cbcb5b-b482-4c56-8b98-8ef087cb8474"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlaceElement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f877c7fe-37b2-4ef7-b3f9-14daf5f6cf9c"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DeleteElement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a83e92f1-7016-4b4c-9d60-a204cd3792ec"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeMode"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e0efe663-d14f-4ae7-aed6-f3c2864c0c08"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Save"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""81fb0c8c-d86f-4560-833b-d9afcbee1827"",
                    ""path"": ""<Keyboard>/v"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Load"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Player"",
            ""id"": ""091b5e2a-1df7-49ca-be80-3863d9df1c32"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""230cf223-eaab-4c76-a69f-1ef89f5e3668"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""30cc811a-1f8b-4b9f-a87c-e6dc1fc81839"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""b4f966f1-27e0-4df7-a75a-1f00746142d5"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""cdc8684b-9090-4e62-bbd7-9f78108b65b6"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""6a3404ff-c51e-498a-84a6-de6c168e6369"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""cfbc07f4-4acb-403c-b6d2-e918bdf5fe3f"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Camera
        m_Camera = asset.FindActionMap("Camera", throwIfNotFound: true);
        m_Camera_Rotation = m_Camera.FindAction("Rotation", throwIfNotFound: true);
        m_Camera_Movement = m_Camera.FindAction("Movement", throwIfNotFound: true);
        m_Camera_Zoom = m_Camera.FindAction("Zoom", throwIfNotFound: true);
        // Palette
        m_Palette = asset.FindActionMap("Palette", throwIfNotFound: true);
        m_Palette_ChangeElement = m_Palette.FindAction("ChangeElement", throwIfNotFound: true);
        // Editor
        m_Editor = asset.FindActionMap("Editor", throwIfNotFound: true);
        m_Editor_PlaceElement = m_Editor.FindAction("PlaceElement", throwIfNotFound: true);
        m_Editor_DeleteElement = m_Editor.FindAction("DeleteElement", throwIfNotFound: true);
        m_Editor_ChangeMode = m_Editor.FindAction("ChangeMode", throwIfNotFound: true);
        m_Editor_Save = m_Editor.FindAction("Save", throwIfNotFound: true);
        m_Editor_Load = m_Editor.FindAction("Load", throwIfNotFound: true);
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Movement = m_Player.FindAction("Movement", throwIfNotFound: true);
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

    // Camera
    private readonly InputActionMap m_Camera;
    private ICameraActions m_CameraActionsCallbackInterface;
    private readonly InputAction m_Camera_Rotation;
    private readonly InputAction m_Camera_Movement;
    private readonly InputAction m_Camera_Zoom;
    public struct CameraActions
    {
        private @InputManager m_Wrapper;
        public CameraActions(@InputManager wrapper) { m_Wrapper = wrapper; }
        public InputAction @Rotation => m_Wrapper.m_Camera_Rotation;
        public InputAction @Movement => m_Wrapper.m_Camera_Movement;
        public InputAction @Zoom => m_Wrapper.m_Camera_Zoom;
        public InputActionMap Get() { return m_Wrapper.m_Camera; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CameraActions set) { return set.Get(); }
        public void SetCallbacks(ICameraActions instance)
        {
            if (m_Wrapper.m_CameraActionsCallbackInterface != null)
            {
                @Rotation.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnRotation;
                @Rotation.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnRotation;
                @Rotation.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnRotation;
                @Movement.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnMovement;
                @Zoom.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnZoom;
                @Zoom.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnZoom;
                @Zoom.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnZoom;
            }
            m_Wrapper.m_CameraActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Rotation.started += instance.OnRotation;
                @Rotation.performed += instance.OnRotation;
                @Rotation.canceled += instance.OnRotation;
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Zoom.started += instance.OnZoom;
                @Zoom.performed += instance.OnZoom;
                @Zoom.canceled += instance.OnZoom;
            }
        }
    }
    public CameraActions @Camera => new CameraActions(this);

    // Palette
    private readonly InputActionMap m_Palette;
    private IPaletteActions m_PaletteActionsCallbackInterface;
    private readonly InputAction m_Palette_ChangeElement;
    public struct PaletteActions
    {
        private @InputManager m_Wrapper;
        public PaletteActions(@InputManager wrapper) { m_Wrapper = wrapper; }
        public InputAction @ChangeElement => m_Wrapper.m_Palette_ChangeElement;
        public InputActionMap Get() { return m_Wrapper.m_Palette; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PaletteActions set) { return set.Get(); }
        public void SetCallbacks(IPaletteActions instance)
        {
            if (m_Wrapper.m_PaletteActionsCallbackInterface != null)
            {
                @ChangeElement.started -= m_Wrapper.m_PaletteActionsCallbackInterface.OnChangeElement;
                @ChangeElement.performed -= m_Wrapper.m_PaletteActionsCallbackInterface.OnChangeElement;
                @ChangeElement.canceled -= m_Wrapper.m_PaletteActionsCallbackInterface.OnChangeElement;
            }
            m_Wrapper.m_PaletteActionsCallbackInterface = instance;
            if (instance != null)
            {
                @ChangeElement.started += instance.OnChangeElement;
                @ChangeElement.performed += instance.OnChangeElement;
                @ChangeElement.canceled += instance.OnChangeElement;
            }
        }
    }
    public PaletteActions @Palette => new PaletteActions(this);

    // Editor
    private readonly InputActionMap m_Editor;
    private IEditorActions m_EditorActionsCallbackInterface;
    private readonly InputAction m_Editor_PlaceElement;
    private readonly InputAction m_Editor_DeleteElement;
    private readonly InputAction m_Editor_ChangeMode;
    private readonly InputAction m_Editor_Save;
    private readonly InputAction m_Editor_Load;
    public struct EditorActions
    {
        private @InputManager m_Wrapper;
        public EditorActions(@InputManager wrapper) { m_Wrapper = wrapper; }
        public InputAction @PlaceElement => m_Wrapper.m_Editor_PlaceElement;
        public InputAction @DeleteElement => m_Wrapper.m_Editor_DeleteElement;
        public InputAction @ChangeMode => m_Wrapper.m_Editor_ChangeMode;
        public InputAction @Save => m_Wrapper.m_Editor_Save;
        public InputAction @Load => m_Wrapper.m_Editor_Load;
        public InputActionMap Get() { return m_Wrapper.m_Editor; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(EditorActions set) { return set.Get(); }
        public void SetCallbacks(IEditorActions instance)
        {
            if (m_Wrapper.m_EditorActionsCallbackInterface != null)
            {
                @PlaceElement.started -= m_Wrapper.m_EditorActionsCallbackInterface.OnPlaceElement;
                @PlaceElement.performed -= m_Wrapper.m_EditorActionsCallbackInterface.OnPlaceElement;
                @PlaceElement.canceled -= m_Wrapper.m_EditorActionsCallbackInterface.OnPlaceElement;
                @DeleteElement.started -= m_Wrapper.m_EditorActionsCallbackInterface.OnDeleteElement;
                @DeleteElement.performed -= m_Wrapper.m_EditorActionsCallbackInterface.OnDeleteElement;
                @DeleteElement.canceled -= m_Wrapper.m_EditorActionsCallbackInterface.OnDeleteElement;
                @ChangeMode.started -= m_Wrapper.m_EditorActionsCallbackInterface.OnChangeMode;
                @ChangeMode.performed -= m_Wrapper.m_EditorActionsCallbackInterface.OnChangeMode;
                @ChangeMode.canceled -= m_Wrapper.m_EditorActionsCallbackInterface.OnChangeMode;
                @Save.started -= m_Wrapper.m_EditorActionsCallbackInterface.OnSave;
                @Save.performed -= m_Wrapper.m_EditorActionsCallbackInterface.OnSave;
                @Save.canceled -= m_Wrapper.m_EditorActionsCallbackInterface.OnSave;
                @Load.started -= m_Wrapper.m_EditorActionsCallbackInterface.OnLoad;
                @Load.performed -= m_Wrapper.m_EditorActionsCallbackInterface.OnLoad;
                @Load.canceled -= m_Wrapper.m_EditorActionsCallbackInterface.OnLoad;
            }
            m_Wrapper.m_EditorActionsCallbackInterface = instance;
            if (instance != null)
            {
                @PlaceElement.started += instance.OnPlaceElement;
                @PlaceElement.performed += instance.OnPlaceElement;
                @PlaceElement.canceled += instance.OnPlaceElement;
                @DeleteElement.started += instance.OnDeleteElement;
                @DeleteElement.performed += instance.OnDeleteElement;
                @DeleteElement.canceled += instance.OnDeleteElement;
                @ChangeMode.started += instance.OnChangeMode;
                @ChangeMode.performed += instance.OnChangeMode;
                @ChangeMode.canceled += instance.OnChangeMode;
                @Save.started += instance.OnSave;
                @Save.performed += instance.OnSave;
                @Save.canceled += instance.OnSave;
                @Load.started += instance.OnLoad;
                @Load.performed += instance.OnLoad;
                @Load.canceled += instance.OnLoad;
            }
        }
    }
    public EditorActions @Editor => new EditorActions(this);

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Movement;
    public struct PlayerActions
    {
        private @InputManager m_Wrapper;
        public PlayerActions(@InputManager wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Player_Movement;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    public interface ICameraActions
    {
        void OnRotation(InputAction.CallbackContext context);
        void OnMovement(InputAction.CallbackContext context);
        void OnZoom(InputAction.CallbackContext context);
    }
    public interface IPaletteActions
    {
        void OnChangeElement(InputAction.CallbackContext context);
    }
    public interface IEditorActions
    {
        void OnPlaceElement(InputAction.CallbackContext context);
        void OnDeleteElement(InputAction.CallbackContext context);
        void OnChangeMode(InputAction.CallbackContext context);
        void OnSave(InputAction.CallbackContext context);
        void OnLoad(InputAction.CallbackContext context);
    }
    public interface IPlayerActions
    {
        void OnMovement(InputAction.CallbackContext context);
    }
}
