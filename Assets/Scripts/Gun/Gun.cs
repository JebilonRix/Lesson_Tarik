using UnityEngine;

namespace Lesson
{
    [CreateAssetMenu(menuName = "Gun")]
    public class Gun : ScriptableObject
    {
        [SerializeField] private string _gunName;
        [SerializeField] private GunType _gunType;
        [SerializeField][Range(0.1f, 3f)] private float _fireRate = 1f;
        [SerializeField][Range(0.1f, 3f)] private float _reloadSpeed = 1f;

        [Header("Magazine/Bullet")]
        [SerializeField] private int _magazine = 30;
        [SerializeField] private int _currentBulletsCount = 0;
        [SerializeField] private int _totalBulletCount = 300;

        public string GunName { get => _gunName; private set => _gunName = value; }
        public GunType GunType { get => _gunType; private set => _gunType = value; }
        public float FireRate { get => _fireRate; private set => _fireRate = value; }
        public float ReloadSpeed { get => _reloadSpeed; set => _reloadSpeed = value; }

        public int Magazine { get => _magazine; private set => _magazine = value; }
        public int CurrentBulletsCount { get => _currentBulletsCount; set => _currentBulletsCount = value; }
        public int TotalBulletCount { get => _totalBulletCount; set => _totalBulletCount = value; }

    }
}