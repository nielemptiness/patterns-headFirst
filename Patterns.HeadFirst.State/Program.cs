// See https://aka.ms/new-console-template for more information

using Patterns.HeadFirst.State;

var player = new MusicPlayer();
player.Sound(); //nothing

player.TurnOn(); // change state

player.Sound(); //yes
player.TurnOn(); //nothing