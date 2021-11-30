using Cysharp.Threading.Tasks;
using Unity.Services.Authentication;
using Unity.Services.Lobbies;
using Unity.Services.Lobbies.Models;
using UnityEngine;

namespace App.Scripts.Lobby.Commands
{
    public class JoinByLobbyCode
    {
        public static async UniTask Execute(string code)
        {
            try
            {
                await Lobbies.Instance.JoinLobbyByCodeAsync(code);
            }
            catch (LobbyServiceException e)
            {
                Debug.Log(e);
            }
        }
    }
}
