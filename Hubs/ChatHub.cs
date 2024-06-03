using Insurance.ChatService.Models;
using Microsoft.AspNetCore.SignalR;

namespace Insurances.ChatService.Hubs;

public class ChatHub : Hub
{
    public async Task JoinChat(UserConnection conn)
    {
        await Clients.All
            .SendAsync("ReceiveMessage", "admin", $"{conn.Username} has joined");
    }

    public async Task JoinSpecificChatRoom(UserConnection conn)
    {
        await Groups.AddToGroupAsync(Context.CinnectionId, conn.ChatRoom);
    }
}
