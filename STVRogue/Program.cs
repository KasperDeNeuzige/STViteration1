﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using STVRogue.GameLogic;
namespace STVRogue
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game(5);
            game.player.location = new Node("a dummy node");
            while(true)
            {
                Console.ReadKey();
                game.update(game.player.location);
            }
        }
    }
}