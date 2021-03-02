using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Shooter
{
    [CreateAssetMenu(menuName ="Scripts/ControlRigidBodySettings")]
    public class ControlRigidBodySettings: ScriptableObject
    {
        [SerializeField] private Vector3 _force;

        public Vector3 Force { get { return _force; } }

    }

}