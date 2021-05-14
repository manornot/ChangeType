using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace PG2 { 
    public class NormalsMode : MonoBehaviour
    {
        private Transform _selection;
        [SerializeField] private string selectableTag = "Selectable";
        [SerializeField] private Material hightlightMaterial;
        private Vector3 mouseCoordinates;


        // Start is called before the first frame update
        void Start()
        {
        
        }


        public Vector3? GetPlacementPositio(Vector3 mousePos)
        {
            Ray ray = Camera.main.ScreenPointToRay(mousePos);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                var meshColider = hit.collider as MeshCollider;
                if (meshColider == null || meshColider.sharedMesh == null)
                {
                    Debug.LogError("i hit some shit!");
                    return null;
                }
                Mesh mesh = meshColider.sharedMesh;
                var normals = mesh.normals;
                var triangles = mesh.triangles;
                var firstNormal = normals[triangles[hit.triangleIndex*3+0]];
                firstNormal.Normalize();
                mouseCoordinates = hit.collider.transform.position + firstNormal;
                return mouseCoordinates;
            }
            else
            {
                return null;
            }
            
        }

        // Update is called once per frame
        void Update()
        {
            if (_selection != null)
            {
                //var selectionRenderer = _selection.GetComponent<BlockMaterialController>();
                //selectionRenderer.SetNormal();
                _selection = null;

            }
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                var selection = hit.transform;
                if (selection.CompareTag(selectableTag))
                {
                    //var selectedBlock = selection.gameObject.GetComponent<BlockMaterialController>();
                    //if (selectedBlock != null)
                    //{
                    //    selectedBlock.SetMaterial(hightlightMaterial);
                    //}
                    _selection = selection;
                #region placing Object on hit surface

                MeshCollider meshCollider = hit.collider as MeshCollider;
                if (meshCollider == null || meshCollider.sharedMesh == null)
                    return;

                Mesh mesh = meshCollider.sharedMesh;
                Vector3[] vertices = mesh.vertices;
                Vector3[] normals = mesh.normals;
                int[] triangles = mesh.triangles;

                //Vector3 p0 = vertices[triangles[hit.triangleIndex * 3 + 0]];
                //Vector3 p1 = vertices[triangles[hit.triangleIndex * 3 + 1]];
                //Vector3 p2 = vertices[triangles[hit.triangleIndex * 3 + 2]];

                Vector3 n0 = normals[triangles[hit.triangleIndex * 3 + 0]];
                //Vector3 n1 = normals[triangles[hit.triangleIndex * 3 + 1]];
                //Vector3 n2 = normals[triangles[hit.triangleIndex * 3 + 2]];

                Transform hitTransform = hit.collider.transform;
                n0.Normalize();
                    mouseCoordinates = hitTransform.position + n0;

                #endregion
            }
            else
            {
                    mouseCoordinates = transform.InverseTransformPoint(hit.point);
            }

            if (Input.GetKeyDown(KeyCode.Mouse0))
            {


                //var new_cube = Instantiate(prefabPalette[0], clickCoordinates, new Quaternion());
                //new_cube.transform.position = clickCoordinates;
                //new_cube.transform.Translate(n0 * 0.1f,Space.World);
                //Vector3 arrayIndexes = new_cube.transform.position;
                //if (arrayIndexes.LessThan(levelSize))
                //{
                    //levelArray[(int)arrayIndexes.x, (int)arrayIndexes.y, (int)arrayIndexes.z].prefab = 1;
                //}
            }
            if (Input.GetButtonDown("Fire2"))
            {
                if (hit.transform.CompareTag(selectableTag))
                {
                    Destroy(hit.transform.gameObject);
                }


                //Vector3 arrayIndexes = new_cube.transform.position / spacing;
                //levelArray[(int)arrayIndexes.x, (int)arrayIndexes.y, (int)arrayIndexes.z].prefab = 1;

            }

        }
    }
}
}