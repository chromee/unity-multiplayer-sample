using System;
using App.Scripts.Lobby.Commands;
using Cysharp.Threading.Tasks;
using Unity.Services.Authentication;
using Unity.Services.Core;
using UnityEngine;

namespace App.Scripts.Lobby
{
    public class LobbyExecutor : MonoBehaviour
    {
        private bool _initialized;

        private string _lobbyCode;

        private async void Start()
        {
            await UnityServices.InitializeAsync();
            await AuthenticationService.Instance.SignInAnonymouslyAsync();
            _initialized = true;
        }

        private void OnGUI()
        {
            if (!_initialized) return;

            if (GUILayout.Button("CreateLobby")) CreateLobby.Execute().Forget();
            if (GUILayout.Button("QuickJoin")) QuickJoin.Execute().Forget();

            GUILayout.BeginHorizontal();
            _lobbyCode = GUILayout.TextField(_lobbyCode, GUILayout.Width(100));
            if (GUILayout.Button("JoinByLobbyCode")) JoinByLobbyCode.Execute(_lobbyCode).Forget();
            GUILayout.EndHorizontal();
        }
    }
}
