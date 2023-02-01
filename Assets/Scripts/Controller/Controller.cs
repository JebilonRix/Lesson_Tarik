using UnityEngine;

namespace Lesson
{
    [CreateAssetMenu(menuName = "Controller")]
    public class Controller : ScriptableObject
    {
        [SerializeField] private KeyCode _shoot = KeyCode.Space;
        [SerializeField] private KeyCode _reload = KeyCode.R;
        [SerializeField] private KeyCode _changeGunNegative = KeyCode.Q;
        [SerializeField] private KeyCode _changeGunPositive = KeyCode.E;

        public KeyCode Shoot { get => _shoot; private set => _shoot = value; }
        public KeyCode Reload { get => _reload; private set => _reload = value; }
        public KeyCode ChangeGunNegative { get => _changeGunNegative; private set => _changeGunNegative = value; }
        public KeyCode ChangeGunPositive { get => _changeGunPositive; private set => _changeGunPositive = value; }
    }
}
