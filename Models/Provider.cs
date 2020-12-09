using System;
using System.Linq;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using Discord.WebSocket;

public class Provider
{
    public string Name { get; set; }
    public string Description { get; set; }
    public bool State { get; set; }
}