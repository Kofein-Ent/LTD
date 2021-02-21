using UnityEngine;
using UnityEngine.UIElements;

[RequireComponent(typeof(Camera))]
public class CameraController : MonoBehaviour
{
    [Header("Zooming")]
    [SerializeField] private float _zoomSpeed;
    [Space(10)]
    [SerializeField] private float _minZoom;
    [SerializeField] private float _maxZoom;
    
    [Header("Movement")]
    [SerializeField] private float _dragSpeed;
    [Space(10)] 
    [SerializeField] private Vector2 _minMovementCap;
    [SerializeField] private Vector2 _maxMovementCap;
    
    private Camera _camera;
    private Transform _transform;
    private Vector3 _previousMouseVector;
    
    private void Start()
    {
        _transform = transform;
        _camera = GetComponent<Camera>();
        _previousMouseVector = Vector3.zero; 
    }
    private void Update()
    {
        if (Input.GetMouseButton(1))
        {
            Vector3 position = _transform.position;
            Vector3 movementVector = position +
                                     -(Input.mousePosition - _previousMouseVector).normalized *
                                     (_dragSpeed * Time.deltaTime);
                
            position = new Vector3(Mathf.Clamp(movementVector.x, _minMovementCap.x, _maxMovementCap.x),
                Mathf.Clamp(movementVector.y, _minMovementCap.y, _maxMovementCap.y), position.z);
                
            _transform.position = position;
            _previousMouseVector = Input.mousePosition;
        }
        if (Input.GetAxis("Mouse ScrollWheel") != 0)
        {
            _camera.orthographicSize =
                Mathf.Clamp(
                    _camera.orthographicSize +
                    _zoomSpeed * Time.deltaTime * (Input.GetAxis("Mouse ScrollWheel") < 0 ? 1 : -1), _minZoom,
                    _maxZoom);
        }
    }
}
