using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace PG2 
{ 
    public class GameManager : MonoBehaviour
    {
        [Range(0,1)]
        [SerializeField]
        private int lvl;
        PaletteController paletteController;
        // Start is called before the first frame update
        List<GameObject> sampleBuffer;

        private Object[] palette;
        private void Awake()
        {
            palette = Resources.LoadAll("DefaultPalette/", typeof(GameObject));
        }

        void Start()
        {
            paletteController = new PaletteController();
            paletteController.LoadPalette();
            var path = "C:/Users/orman/AppData/LocalLow/DefaultCompany/ChangeType()/level" + lvl.ToString() + ".fun";
            Debug.Log(path);
            sampleBuffer = new List<GameObject>();

            // LoadLevel(SaveSystem.LoadLevel(path));
        }

        // Update is called once per frame
        void Update()
        {

            // if clicked 
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {

                RaycastHit hit = new RaycastHit();
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                // if clicked on block
                if (Physics.Raycast(ray, out hit))
                {
                    var hitColider = hit.collider as MeshCollider;
                    if (hitColider != null)
                    {
                        // add block to block buffer
                        // if buffer is full
                        var sampleID = hitColider.gameObject.GetComponent<BlockUUID>().UUID;
                        sampleBuffer.Add(palette[sampleID] as GameObject);
                        Debug.Log(sampleBuffer);
                        if (sampleBuffer.Count == 2)
                        {

                            List<List<GameObject>> objectsBuffers = new List<List<GameObject>>();
                            foreach (GameObject sample in sampleBuffer)
                            {
                                // find all blocks of typeof(sample) type

                                var tempUUIDBuffer = GameObject.FindObjectsOfType<BlockUUID>();
                                List<GameObject> tempBlockBuffer = new List<GameObject>();
                                foreach(var uuid in tempUUIDBuffer)
                                {
                                    if (uuid.UUID == sample.GetComponent<BlockUUID>().UUID)
                                    { 
                                        tempBlockBuffer.Add(uuid.gameObject); 
                                    }
                                }
                                objectsBuffers.Add(tempBlockBuffer);
                                
                                
                            }
                            int counter = 1;
                            foreach(List<GameObject> objectBuffer in objectsBuffers)
                            {
                                foreach(GameObject block in objectBuffer)
                                {
                                    block.TryGetComponent<BlockTypeManager>(out var blockTypeManager);
                                    sampleBuffer[counter].TryGetComponent<BlockUUID>(out var newUUID);
                                    blockTypeManager.ChangeType(newUUID);
                                        
                                }
                                counter--;
                                
                            }

                            // find all blocks with types like in buffer
                            // switch types of there blocks to oposyte
                            sampleBuffer = new List<GameObject>();

                        }
                    }
                }
            }
        }
        
        void LoadLevel(LevelData levelData)
        {
            var levelElements = GameObject.FindGameObjectsWithTag("Selectable");
            foreach (GameObject blck in levelElements)
            {
                Destroy(blck);
            }
            var level = levelData.levelArray;
            //Debug.Log("level size 0 = " + level.GetLength(0).ToString());
            //Debug.Log("level size 1 = " + level.GetLength(1).ToString());
            //Debug.Log("level size 2 = " + level.GetLength(2).ToString());
            for (int i = 0; i < level.GetLength(0); i++)
            {
                for (int j = 0; j < level.GetLength(1); j++)
                {
                    for (int k = 0; k < level.GetLength(2); k++)
                    {
                        Vector3 gridCellCoordinates = new Vector3(i, j, k);
                        //Debug.Log("i = " + i.ToString());
                        //Debug.Log("j = " + j.ToString());
                        //Debug.Log("k = " + k.ToString());
                        if (level[i, j, k] != 0)
                        {
                            //Debug.Log(level[i, j, k]);
                            Instantiate(paletteController.GetElementByID(level[i, j, k]), gridCellCoordinates, new Quaternion());
                        }
                    }
                }
            }
        }
    }
}