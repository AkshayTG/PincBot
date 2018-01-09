using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;

namespace PincBot.Modules
{
    public class Misc : ModuleBase<SocketCommandContext>
    {
        public float c;
        public string d, f1s, f2s;

        //ChatBot
        [Command("Hello")]
        public async Task Hello()
        {
            await Context.Channel.SendMessageAsync("Hey "+ Context.User.Username);
        }
        [Command("Hey")]
        public async Task Hey()
        {
            await Context.Channel.SendMessageAsync("Hi " + Context.User.Username);
        }
        [Command("WhoAreYou?")]
        public async Task AreYou()
        {
            await Context.Channel.SendMessageAsync("Im Pinc Bot, a discord bot made by Akshay" + Context.User.Username);
        }
        [Command("chatbot")]
        public async Task ChatBot()
        {
            var embed = new EmbedBuilder();
            embed.WithTitle("Chatbot - Commands");
            embed.WithDescription("\n!hey" + Environment.NewLine + "!hello" + Environment.NewLine + "!WhoAreYou");
            embed.WithColor(new Color(255, 20, 147));
            await Context.Channel.SendMessageAsync("", false, embed);
        }
        //ChatBot Ends
        [Command("pick")]
        public async Task Pick(string message)
        {
            string[] options = message.Split('-');
            var embed = new EmbedBuilder();
            embed.WithTitle("Chatbot - Commands");
            embed.WithDescription("\n!hey" + Environment.NewLine + "!hello" + Environment.NewLine + "!WhoAreYou");
            embed.WithColor(new Color(255, 20, 147));
            await Context.Channel.SendMessageAsync("", false, embed);
        }
        //Math
        [Command("math")]
        public async Task Hello(float f1, char thing, float f2)
        {
            f1s = f1.ToString();
            f2s = f2.ToString();

            if (thing == '*')
            {
                c = f1 * f2;
                d = c.ToString();
            }
            if (thing == '+')
            {
                c = f1 + f2;
                d = c.ToString();
            }
            if (thing == '-')
            {
                c = f1 - f2;
                d = c.ToString();
            }
            if (thing == '/')
            {
                c = f1 / f2;
                d = c.ToString();
            }

            var embed = new EmbedBuilder();
            embed.WithTitle(f1s + " " + thing + " " + f2s + " equals");
            embed.WithDescription(d);
            embed.WithColor(new Color(255, 20, 147));
            await Context.Channel.SendMessageAsync("", false, embed);
        }
        //Math Ends
        //Help
        [Command("help")]
        public async Task Help()
        {
            var embed = new EmbedBuilder();
            embed.WithTitle("Help - Commands\n");
            embed.WithDescription("\n!help - View all the commands " + Environment.NewLine +  "!math - Do Basic Math(number1, operation, number2) e.g 1 * 2" + Environment.NewLine
                + "\nYou can also chat with the bot, like !hi, !hello. If you want the chatbot commands, type !chatbot");
            embed.WithColor(new Color(255, 20, 147));
            await Context.Channel.SendMessageAsync("", false, embed);
        }
        //Help Ends
    }
}
