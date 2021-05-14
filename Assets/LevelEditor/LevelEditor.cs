using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace PG2 {
    public class LevelEditor : MonoBehaviour
    {

        [SerializeField] private string selectableTag = "Selectable";
        [SerializeField] private GameObject cameraRig;
        [SerializeField] private GameObject palette;
        //[SerializeField] private GameObject[,,] level;
        public System.Action<InputAction.CallbackContext> handler;
        private CameraController cameraRigController;
        private PaletteController paletteController;
        private NormalsMode normalsModeController;
        private enum editorStates 
        {
            Normals,
            Plane
        };

        editorStates editorCurrentState;
        private InputManager controls;
        // Start is called before the first frame update
        void Awake()
        {
            cameraRigController = cameraRig.GetComponent<CameraController>();
            paletteController = palette.GetComponent<PaletteController>();
            controls = new InputManager();
            normalsModeController = new NormalsMode();
            #region Camera Controls
            controls.Camera.Rotation.performed += ctx => cameraRigController.RotationHandler(ctx.ReadValue<float>());
            controls.Camera.Rotation.canceled += _ => cameraRigController.RotationHandler();
            controls.Camera.Movement.performed += ctx => cameraRigController.MovementHandler(ctx.ReadValue<Vector2>());
            controls.Camera.Movement.canceled += _ => cameraRigController.MovementHandler();
            controls.Camera.Zoom.performed += ctx => cameraRigController.ZoomHandler(ctx.ReadValue<Vector2>());
            #endregion
            
            #region Palette Control
            controls.Palette.ChangeElement.performed += ctx => paletteController.RotatePalette(ctx.ReadValue<float>());
            #endregion

            #region Edit Modes Controls
            handler = (InputAction.CallbackContext ctx) => PlaceElement();
            controls.Editor.ChangeMode.performed += _ => ModeSwap();
            #endregion

            #region Save
            controls.Editor.Save.performed += _ => SaveLevel();
            #endregion

            #region Load
            controls.Editor.Load.performed += _ => LoadLevel();
            #endregion
            ModeSwap();
        }

        private void OnEnable()
        {
            controls.Enable();
        }

        private void OnDisable()
        {
            controls.Disable();
        }
        
        private void ModeSwap()
        {
            
            if(editorCurrentState == editorStates.Normals)
            {
                editorCurrentState++;
                
                controls.Editor.PlaceElement.performed -= handler;

        //assign Normals controll
        //remove Plane controll 
            }
            else if(editorCurrentState == editorStates.Plane)
            {
                editorCurrentState--;
                controls.Editor.PlaceElement.performed += handler;
                //remove Normals controll
                //assign Plane controll
            }
            Debug.Log(editorCurrentState);
        }


        void PlaceElement()
        {
            var element = paletteController.GetCurrentActivePaletteElement();
            Vector3? pos = normalsModeController.GetPlacementPositio(Input.mousePosition);
            if(pos != null) 
            {
                var elementPosition = pos.Value;
                Instantiate(element, elementPosition, new Quaternion());
            }
        }
        void Start()
        {
            //initEditModes();
            //initElementSelector();
            //initCameraRig();
            //initUI();
            //initSelector();
            //palleteController();
        }

        // Update is called once per frame
        void Update()
        {

        }
        void LoadLevel(Vector3 levelSize, float spacing, List<GameObject> prefabPalette)
        {
            for (int i = 0; i < (int)levelSize.x; i++)
            {
                for (int j = 0; j < (int)levelSize.z; j++)
                {
                    Vector3 gridCellCoordinates = new Vector3(i * spacing, 0, j * spacing);
                    Instantiate(prefabPalette[0], gridCellCoordinates, new Quaternion());
                }
            }
        }
        public void LoadLevel()
        {
            var levelElements = GameObject.FindGameObjectsWithTag(selectableTag);
            foreach(GameObject blck in levelElements)
            {
                Destroy(blck);
            }
            var level = SaveSystem.LoadLevel().levelArray;
            Debug.Log("level size 0 = " + level.GetLength(0).ToString());
            Debug.Log("level size 1 = " + level.GetLength(1).ToString());
            Debug.Log("level size 2 = " + level.GetLength(2).ToString());
            for (int i = 0; i < level.GetLength(0); i++)
            {
                for (int j = 0; j < level.GetLength(1); j++)
                {
                    for (int k = 0; k < level.GetLength(2); k++)
                    {
                        Vector3 gridCellCoordinates = new Vector3(i, j, k);
                        Debug.Log("i = " + i.ToString());
                        Debug.Log("j = " + j.ToString());
                        Debug.Log("k = " + k.ToString());
                        if (level[i, j, k] != 0)
                        {
                            Debug.Log(level[i, j, k]);
                            Instantiate(paletteController.GetElementByID(level[i, j, k]), gridCellCoordinates, new Quaternion());
                        }
                    }
                }
            }
        }
        void SaveLevel()
        {

                var levelElements = GameObject.FindGameObjectsWithTag(selectableTag);

                var elementCoordinates = new Vector3[levelElements.Length];
                for (int i = 0; i < levelElements.Length; i++)
                {
                    elementCoordinates[i] = levelElements[i].transform.position;
                }
                //Debug.Log(elementCoordinates.Length);
                Vector3 a = new Vector3(1, 2, 3);
                //find min/max coordingates for x,y,z
                var axis = new[] { "x", "y", "z" };
                Vector3 minAxisValues = elementCoordinates.Min();
                Vector3 maxAxisValues = elementCoordinates.Max();




                //Debug.Log("min Axis Values = " + minAxisValues.ToString());
                //Debug.Log("max Axis Values = " + maxAxisValues.ToString());
                var arraySize = maxAxisValues - minAxisValues;
                var level =  new int[(int)arraySize.x + 1, (int)arraySize.y + 1, (int)arraySize.z + 1];
                //Debug.Log("array Size = (x - " + ((int)arraySize.x).ToString() + ", " + "y - " + ((int)arraySize.y).ToString() + ", " + "z - " + ((int)arraySize.z).ToString() + ")");
                Debug.Log("level Length 0 = " + level.GetLength(0).ToString());
                Debug.Log("level Length 1 = " + level.GetLength(1).ToString());
                Debug.Log("level Length 2 = " + level.GetLength(2).ToString());
                foreach (GameObject element in levelElements)
                {
                    var xIndex = (int)(element.transform.position.x - minAxisValues.x);
                    var yIndex = (int)(element.transform.position.y - minAxisValues.y);
                    var zIndex = (int)(element.transform.position.z - minAxisValues.z);
                    level[xIndex, yIndex, zIndex] = element.GetComponent<BlockUUID>().UUID;//new LevelObject(); 
                }

            Debug.Log(level);


            var lvlData = new LevelData();
            lvlData.levelArray = level;
            SaveSystem.SaveLevel(lvlData);
        }

    }

  
}