using UnityEngine;
using UnityEngine.InputSystem;

namespace Selectable {
    public class SelectableEngine : MonoBehaviour
    {
        private Selectable _currentSelectable;
        private Camera _camera;

        private void Start() {
            _camera = Camera.main;
        }
        private void Update() {
            if (FindSelectableUnderMouse(out Selectable found)) {
                UpdateSelectable(found);
            } else {
                DiscardOldSelectable();
            }
        }

        private bool FindSelectableUnderMouse(out Selectable foundSelectable) {
            foundSelectable = null;
            
            Ray ray = _camera.ScreenPointToRay(Mouse.current.position.ReadValue());
            if (Physics.Raycast(ray, out RaycastHit hitInfo))
            {
                var selectable = hitInfo.collider.GetComponent<Selectable>();
                if (selectable != null) {
                    foundSelectable = selectable;
                    return true;
                }
                return false;
            }
            return false;
        }

        private void UpdateSelectable(Selectable selectable) {
            if (selectable != _currentSelectable) {
                DiscardOldSelectable();
                SetNewSelectable(selectable);
            }
        }

        private void SetNewSelectable(Selectable selectable) {
            _currentSelectable = selectable;
            _currentSelectable.Hover();
        }

        private void DiscardOldSelectable() {
            _currentSelectable?.HoverExit();
            _currentSelectable = null;
        }
    }
}
