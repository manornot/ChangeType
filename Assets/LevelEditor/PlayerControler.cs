using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace PG2
{ 
    public class PlayerControler : MonoBehaviour
    {

        [SerializeField]
        private float movementSpeed = 1;
        [SerializeField]
        private float movementTime = 1;
        [SerializeField]
        private float rotationSpeed;
        [SerializeField]
        private float rotationTime;
        [SerializeField]
        private float rotDirection;
        [SerializeField]
        private Vector3 movDirection;

        Vector3 newPosition;
        Quaternion newRotation;
        InputManager playerController;
        // Start is called before the first frame update
        void Awake()
        {
            newPosition = transform.position;
            newRotation = transform.rotation;
            playerController = new InputManager();

        }
        private void OnEnable()
        {
            playerController.Enable();
        }
        private void OnDisable()
        {
            playerController.Disable();
        }
        // Update is called once per frame
        void Move(Vector2 direction)
        {
            //Debug.Log(direction);
            var dir = new Vector3(direction.x, 0, direction.y);
            var timeConstant = Time.deltaTime * 0 +1 ;
            this.transform.Translate(dir* timeConstant);
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
                float horizontal = Input.GetAxisRaw("Horizontal");
                float vertical = Input.GetAxisRaw("Vertical");
                Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;
                if(direction.magnitude >= 0.1f) 
                {
                    float targetAngle = Mathf.Atan2(direction.x, direction.y) * Mathf.Rad2Deg;
                    newRotation *= Quaternion.Euler(0f, targetAngle, 0f);
                    transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, Time.deltaTime * rotationTime);
                }
                yield return new WaitForSeconds(0.05f);
            }
        }
        #endregion

        #region movement
        public void MovementHandler(Vector2 direction)
        {
            movDirection = new Vector3(direction.x, .0f, direction.y);
        }
        public void MovementHandler()
        {
            movDirection = Vector3.zero;
        }

        private IEnumerator mover()
        {
            while (true)
            {
                
                newPosition += ((transform.forward * movDirection.z) + (transform.right * movDirection.x)) * movementSpeed;
                this.transform.position = Vector3.Lerp(transform.position, newPosition, Time.deltaTime * movementTime);
                yield return new WaitForSeconds(0.05f);
            }
        }
        #endregion


    }
}