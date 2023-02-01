using System.Collections.Generic;
using UnityEngine;

namespace Lesson
{
    public class GunHandler : MonoBehaviour
    {
        [SerializeField] private Controller _controller;
        [SerializeField] private List<Gun> _guns = new();
        private Gun _currentGun;
        private int _index = 0;

        public int Index
        {
            get => _index; set
            {
                _index = value;

                //Sinirlarin asmasini engeller
                // indek = eleman sayýsý - 1
                if (_index > Guns.Count - 1)
                {
                    _index = 0;
                }
                else if (_index < 0)
                {
                    _index = Guns.Count - 1;
                }
            }
        }

        public List<Gun> Guns { get => _guns; private set => _guns = value; }

        private void Start()
        {
            _currentGun = Guns[0];
            Index = 0;
        }

        // Update is called once per frame
        private void Update()
        {
            //Changes current index of list
            if (Input.GetKeyDown(_controller.ChangeGunPositive))
            {
                ChangeGun(1);
            }
            else if (Input.GetKeyDown(_controller.ChangeGunNegative))
            {
                ChangeGun(-1);
            }

            //Reload
            if (Input.GetKeyDown(_controller.Reload))
            {
                GunMethods.Reload(_currentGun);
            }

            //Shoot
            if (Input.GetKeyDown(_controller.Shoot))
            {
                GunMethods.Shoot(_currentGun);
            }
        }

        private void ChangeGun(int direction)
        {
            //Sets index
            Index += direction;

            //Sets current gun
            _currentGun = Guns[Index];

            Debug.Log($"Þuanki silah = {_currentGun.GunName}");
        }
    }
}