@echo off
start LoginServer.exe
ping -n 15 > NUL

start CharServer.exe
ping -n 15 > NUL

start GameServer.exe
ping -n 15 > NUL