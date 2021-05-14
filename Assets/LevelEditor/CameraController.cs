using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PG2
{
    public class CameraController : MonoBehaviour
    {

        [SerializeField]
        private float movementSpeed;
        [SerializeField]
        private float movementTime;
        [SerializeField]
        private float rotationSpeed;
        [SerializeField]
        private float rotationTime;
        [SerializeField]
        private float rotDirection;
        [SerializeField]
        private float zoomDirection;
        [SerializeField]
        private Vector3 movDirection;
        [SerializeField]
        private float zoomSpeed = 30;
        Vector3 newPosition;
        Quaternion newRotation;
        bool snapRotation = false;
        // Start is called before the first frame update
        void Awake()
        {
            newPosition = transform.position;
            newRotation = transform.rotation;
            StartCoroutine(rotator());
            StartCoroutine(mover());
            StartCoroutine(zoomer());
        }


        #region rotation
        public void RotationHandler(float direction)
        {
            rotDirection = direction;
        }
        public void RotationHandler()
        {
            rotDirection = 0f;
        }
        private IEnumerator rotator()
        {
            while (true)
            {
                newRotation *= Quaternion.Euler(Vector3.up * rotDirection * rotationSpeed);
                transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, Time.deltaTime * rotationTime);
                yield return new WaitForSeconds(0.05f);
            }
        }
        #endregion

        #region movement
        public void MovementHandler(Vector2 direction)
        {
            movDirection = new Vector3(direction.x, .0f, direction.y);
            Debug.Log(transform.forward);
        }
        public void MovementHandler()
        {
            movDirection = Vector3.zero;
        }     

        private IEnumerator mover()
        {
            while (true)
            { 
                newPosition += (transform.forward* movDirection.z) + (transform.right * movDirection.x) * movementSpeed;
                transform.position = Vector3.Lerp(transform.position, newPosition, Time.deltaTime * movementTime);
                yield return new WaitForSeconds(0.05f);
            }
        }
        #endregion

        #region zoom
        public void ZoomHandler(Vector2 direction)
        {
            direction.Normalize();
            zoomDirection = direction.y;
        }


        private IEnumerator zoomer()
        {
            while (true)
            {
                transform.GetChild(0).gameObject.transform.Translate(new Vector3(0, 0, zoomSpeed * zoomDirection));
                zoomDirection = .0f;
                yield return new WaitForSeconds(0.1f);
                
            }
        }
        #endregion

    }
}


