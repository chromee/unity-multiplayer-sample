using Unity.Netcode;
using UnityEngine;

namespace App.Scripts.Ngo
{
    public class GameInitializer : MonoBehaviour
    {
        private void OnGUI()
        {
            if (GUILayout.Button("Start Host")) NetworkManager.Singleton.StartHost();
            if (GUILayout.Button("Start Client")) NetworkManager.Singleton.StartClient();
        }
    }
}
