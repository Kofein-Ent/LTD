using UnityEngine;
using UnityEngine.EventSystems;

namespace UI
{
    public class UICloser : MonoBehaviour, IPointerDownHandler
    {
        [SerializeField] private GameObject _UIPanel;

        public void OnPointerDown(PointerEventData data)
        {
            if (!UIPlaceOpener.IsPressed && data.button != PointerEventData.InputButton.Right)
            {
                Close();
            }
            else
            {
                UIPlaceOpener.IsPressed = false;
            }
        }

        public void Close()
        {
            _UIPanel.SetActive(false);
            foreach (Transform child in _UIPanel.transform)
            {
                child.gameObject.SetActive(false);
            }
        }
    }
}
