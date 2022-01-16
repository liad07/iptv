import discord
from discord.ext import  commands
import asyncio

Token ="token"

client = commands.Bot(command_prefix='-')



@client.event
async def on_ready():
    print('{0.user} Bot is runing sucsess!'.format(client))


@client.command()
async def sport1(comm):
 await comm.send('https://sites.google.com/view/crackapps/iptv2/sport-1')


@client.command()
async def sport2(comm):
 await comm.send('https://sites.google.com/view/crackapps/iptv2/sport-2')



@client.command()
async def sport3(comm):
 await comm.send('https://sites.google.com/view/crackapps/iptv2/sport-3')


@client.command()
async def sport4(comm):
 await comm.send('https://sites.google.com/view/crackapps/iptv2/sport-4')


@client.command()
async def sport5(comm):
 await comm.send('https://sites.google.com/view/crackapps/iptv2/sport-5')



@client.command()
async def sport5plus(comm):
 await comm.send('https://sites.google.com/view/crackapps/iptv2/sport-5-plus')


@client.command()
async def sport5live(comm):
 await comm.send('https://sites.google.com/view/crackapps/iptv2/sport-5-live')



@client.command()
async def sport5gold(comm):
 await comm.send('https://sites.google.com/view/crackapps/iptv2/sport-5-gold')


@client.command()
async def reshet13 (comm):
 await comm.send('https://sites.google.com/view/crackapps/iptv2/reshet-13')



@client.command()
async def kan11 (comm):
 await comm.send('https://sites.google.com/view/crackapps/iptv2/kan-11')



client.run(Token)
