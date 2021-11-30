using UnityEngine;

namespace App.Scripts.Lobby
{
    public static class LobbyUtility
    {
        public static void Log(this Unity.Services.Lobbies.Models.Lobby lobby)
        {
            Debug.Log($@"lobby.Id: {lobby.Id}
lobby.Name: {lobby.Name}
lobby.LobbyCode: {lobby.LobbyCode}
lobby.Upid: {lobby.Upid}
lobby.EnvironmentId: {lobby.EnvironmentId}
                ");
        }
    }
}
