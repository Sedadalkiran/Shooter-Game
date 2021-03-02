using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Shooter
{
    public class ControlRigidBody : MonoBehaviour
    {
        [SerializeField] private Rigidbody _rigidbody;
        [SerializeField] private ControlRigidBodySettings rbSettings;

        private void Update()
        {
            bool keyDown = Input.GetKeyDown(KeyCode.Space);
                if (keyDown)
               {
                _rigidbody.AddForce(rbSettings.Force, ForceMode.Impulse);
                }
        }
    }
}