using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;

namespace API.Hubs;
[Authorize]
public class VideoChatHub:Hub
{

  public async Task SendOffer(string recieverId, string offer){
    await Clients.User(recieverId).SendAsync("ReceiveOffer", Context.UserIdentifier, offer);
  }
  public async Task SendAnswer(string recieverId, string answer){
    await Clients.User(recieverId).SendAsync("ReceiveAnswer", Context.UserIdentifier, answer);
  }

  public async Task SendIceCandidate(string recieverId, string candidate){
    await Clients.User(recieverId).SendAsync("ReceiveIceCandidate", Context.UserIdentifier, candidate);
  }
  public async Task EndCall(string recieverId){
    await Clients.User(recieverId).SendAsync("CallEnded");
  }
}
