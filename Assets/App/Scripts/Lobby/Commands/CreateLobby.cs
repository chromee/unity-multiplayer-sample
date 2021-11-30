using System.Collections.Generic;
using System.Linq;
using Cysharp.Threading.Tasks;
using Unity.Services.Authentication;
using Unity.Services.Lobbies;
using Unity.Services.Lobbies.Models;
using UnityEngine;

namespace App.Scripts.Lobby.Commands
{
    public class CreateLobby
    {
        public static async UniTask Execute()
        {
            try
            {
                var lobbyName = "test lobby";
                var maxPlayers = 4;
                var options = new CreateLobbyOptions();
                options.IsPrivate = false;

                Debug.Log(AuthenticationService.Instance.PlayerId);

                var lobby = await Lobbies.Instance.CreateLobbyAsync(lobbyName, maxPlayers, options);
                lobby.Log();
            }
            catch (LobbyServiceException e)
            {
                Debug.LogError(e);
            }
        }
    }
}
