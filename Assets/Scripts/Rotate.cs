using UnityEngine;

namespace CharacterConfigurator
{
    public class Rotate : MonoBehaviour
    {
        public float speed;
        
        private void Update()
        {
            transform.Rotate(new Vector3(0, Time.deltaTime * speed, 0));
        }
    }
}
