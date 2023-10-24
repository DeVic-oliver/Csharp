using TMPro;
using UnityEngine;

namespace Assets.Scripts
{
    public class AnimalPrinter : MonoBehaviour
    {
        public TextMeshProUGUI Animal;

        public enum Animals
        {
            Crab,
            Lion,
            Armadillo
        }

        void Update()
        {
            KeyCode keyPressed = GetKeyPressed();
            switch (keyPressed)
            {
                case KeyCode.A:
                    Animal.text = Animals.Crab.ToString();
                    break;
                case KeyCode.S:
                    Animal.text = Animals.Lion.ToString();
                    break;
                case KeyCode.D:
                    Animal.text = Animals.Armadillo.ToString();
                    break;
                default:
                    break;
            }
        }

        private KeyCode GetKeyPressed()
        {
            if(Input.GetKeyDown(KeyCode.A))
                return KeyCode.A;

            if (Input.GetKeyDown(KeyCode.S))
                return KeyCode.S;

            if (Input.GetKeyDown(KeyCode.D))
                return KeyCode.D;

            return KeyCode.None;
        }
    }
}