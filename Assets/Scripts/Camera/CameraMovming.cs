using MushroomMadness.Player;
using UnityEngine;

public class CameraMoving : MonoBehaviour
{
    [SerializeField] private Player _target;

    [Space]
    [Header("�������� ������")]

    [Min(0)]
    [Tooltip("�������� ������")]
    [SerializeField] private float _dumping = 0.22f;

    [Tooltip("������ �� ������ ������ �������� �� ���������")]
    [SerializeField] private bool _isLookOnTarget = true;


    [Space]
    [Header("������������ ������")]

    [Tooltip("������ ������")]
    [SerializeField] private Vector3 _offset;


    private void LateUpdate() => MoveToTarget();

    private void MoveToTarget()
    {
        var newPostion = _target.transform.position - _offset;
        transform.position = Vector3.Lerp(transform.position, newPostion, _dumping * Time.deltaTime);

        if (_isLookOnTarget)
            transform.LookAt(_target.transform);
    }

    private void FastMoveToTarget()
    {
        var newPostion = _target.transform.position - _offset;
        transform.position = newPostion;

        if (_isLookOnTarget)
            transform.LookAt(_target.transform);
    }

    private void OnValidate()
    {
        FastMoveToTarget();
    }
}
