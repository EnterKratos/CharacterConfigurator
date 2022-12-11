using CharacterConfigurator.ScriptableObjects;
using Cinemachine;
using UnityEngine;

namespace CharacterConfigurator
{
    public class CameraPriorityUpdater : MonoBehaviour
    {
        public CinemachineVirtualCamera virtualCamera;
        public IntVariable cameraPriority;

        public void Update()
        {
            virtualCamera.Priority = cameraPriority.value;
        }

        private void OnEnable()
        {
            Update();
        }
    }
}