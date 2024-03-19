using MushroomMadness.InputSystem;
using UnityEngine;

namespace MushroomMadness.Config.Player
{
    [CreateAssetMenu(fileName = "ConfigPlayer/Move", order = 51)]
    public class ConfigMove : ScriptableObject
    {
        [SerializeField] private InputManager _input;

        [Space]
        [Header("��������")]

        [Tooltip("�������� ��������")]
        [SerializeField][Min(0)] private float _moveSpeed = 3f;
        [Tooltip("���������� ������� ��������� �� ���������")]
        [SerializeField][Range(-0.99f, -100)] private float _gravity = -9.81f;

        [Space]
        [Header("������")]

        [Tooltip("�������� ������")]
        [SerializeField] private AnimationCurve _animationJump;
        [Tooltip("����� ������")]
        [SerializeField][Min(0)] private float _durationJump = 0.1f;
        [Tooltip("������ ������")]
        [SerializeField][Min(0)] private float _heightJump = 3f;

        [Space]
        [Header("�������")]
        [Tooltip("�������� ��������")]
        [SerializeField][Min(0)] private float _rotationSpeed = 1f;


        public IInputMove Input => _input;

        public float MoveSpeed => _moveSpeed;
        public float Gravity => _gravity;

        public AnimationCurve AnimationJump => _animationJump;
        public float DurationJump => _durationJump;
        public float HeightJump => _heightJump;

        public float RotationSpeed => _rotationSpeed;
    }
}
