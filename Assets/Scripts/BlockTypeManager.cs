using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using UnityEngine;
namespace PG2
{
    public class BlockTypeManager : MonoBehaviour
    {



        private Object[] palette;
        private void Awake()
        {
            palette = Resources.LoadAll("DefaultPalette/", typeof(GameObject));
        }
        private void Start()
        {
            gameObject.TryGetComponent<BlockUUID>(out var blockUUID);
            if (blockUUID.UUID == 5)
            {
                gameObject.TryGetComponent<Rigidbody>(out var rigidbody);
                //rigidbody.collisionDetectionMode = false;
            }
        }
        public void ChangeType(BlockUUID newUUID)
        {
            if (gameObject.TryGetComponent<BlockUUID>(out var localUUID))
            {
                localUUID.UUID = newUUID.UUID;
                _applyChanges();
            }


        }

        private void _applyChanges()
        {
            gameObject.TryGetComponent<BlockUUID>(out var localUUID);
            this.gameObject.TryGetComponent<MeshRenderer>(out var meshRenderer);
            this.gameObject.TryGetComponent<Rigidbody>(out var rigidBody);

            GameObject sample = palette[localUUID.UUID] as GameObject;

            sample.TryGetComponent<MeshRenderer>(out var newMeshRenderer);
            sample.TryGetComponent<Rigidbody>(out var newRigidBody);


            //Destroy(meshRenderer);
            //Destroy(rigidBody);

            rigidBody.mass = newRigidBody.mass;
            rigidBody.drag = newRigidBody.drag;
            rigidBody.angularDrag = newRigidBody.angularDrag;
            rigidBody.useGravity = newRigidBody.useGravity;
            rigidBody.isKinematic = newRigidBody.isKinematic;
            rigidBody.interpolation = newRigidBody.interpolation;
            rigidBody.collisionDetectionMode = newRigidBody.collisionDetectionMode;

            meshRenderer.sharedMaterials = newMeshRenderer.sharedMaterials;


        }




        public BlockUUID GetType()
        {
            gameObject.TryGetComponent<BlockUUID>(out var localUUID);
            return localUUID;
        }

    }
}

