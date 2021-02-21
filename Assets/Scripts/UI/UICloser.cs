using UnityEngine;
using UnityEngine.EventSystems;

namespace UI
{
    public class UICloser : MonoBehaviour, IPointerDownHandler
    {
        [SerializeField] private GameObject _UIPanel;

        public void OnPointerDown(PointerEventData data)
        {
            if (!UIOpener.IsPressed && data.button != PointerEventData.InputButton.Right)
                _UIPanel.SetActive(false);
            else
                UIOpener.IsPressed = false;
        }
    }
}
