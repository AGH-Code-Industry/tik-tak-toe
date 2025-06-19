using InputSystem;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

namespace Selectable {
    public class Selectable : MonoBehaviour {
        [Header("Customization")]
        [SerializeField] private SelectableOptions selectableOptions;
        
        [Header("Events")]
        public UnityEvent onClick;
        public UnityEvent onRightClick;
        public UnityEvent onHover;
        public UnityEvent onHoverExit;
        
        [DoNotSerialize] public bool IsSelectable { get; set; }

        private void Start() {
            
        }

        private void Update() {
            Debug.Log("Position: " + Mouse.current.position.ReadValue());
        }
    }
}
