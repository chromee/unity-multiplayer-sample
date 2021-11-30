using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using Unity.Services.Lobbies;
using Unity.Services.Lobbies.Models;
using UnityEngine;

namespace App.Scripts.Lobby.Commands
{
    public class QuickJoin
    {
        public static async UniTask Execute()
        {
            try
            {
                // Quick-join a random lobby with a maximum capacity of 10 or more players.
                QuickJoinLobbyOptions options = new QuickJoinLobbyOptions();
                options.Filter = new List<QueryFilter>()
                {
                    new QueryFilter(
                        field: QueryFilter.FieldOptions.MaxPlayers,
                        op: QueryFilter.OpOptions.GE,
                        value: "10")
                };

                var lobby = await Lobbies.Instance.QuickJoinLobbyAsync(options);
                lobby.Log();
            }
            catch (LobbyServiceException e)
            {
                Debug.Log(e);
            }
        }
    }
}
