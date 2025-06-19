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

        public void Hover() {
            Debug.Log("Hover");            
        }

        public void HoverExit() {
            Debug.Log("HoverExit");
        }

        public void Click() {
            Debug.Log("Click");
        }

        public void RightClick() {
            Debug.Log("RightClick");
        }
    }
}
