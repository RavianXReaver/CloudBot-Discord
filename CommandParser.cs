using System;
using System.Linq;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using Discord.WebSocket;

public static class CommandParser
{
    private static string[] _providerList = {"AWS", "AZURE", "LINODE", "DIGITALOCEAN"};

    public static void CheckCommand(Provider command)
    {
        
    }
}