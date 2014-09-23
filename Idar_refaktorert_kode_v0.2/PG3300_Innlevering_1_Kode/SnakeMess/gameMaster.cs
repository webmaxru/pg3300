﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SnakeMess
{
    // Game master is master of gamez
    public class GameMaster{
        private ConsoleKeyInfo _inputKey;
        private Boolean gameOver;

        
        // Method for reading keys
        public int ReadKeys(int lastDirection)  {

            // If key is pressed, read it
            if(Console.KeyAvailable)
             _inputKey = Console.ReadKey();
            
           
            // Return diffrent ints for different inputs from different keys, different
            switch (_inputKey.Key) {
              /*  case ConsoleKey.Escape: // THIS IS FOR ESCAPE DO NOT REMOVE ME
                    return 4;*/
                case ConsoleKey.Spacebar:
                    return 5;
                case ConsoleKey.UpArrow: // 0
                    if(lastDirection != 2)
                        return 0;
                    return lastDirection;

                case ConsoleKey.RightArrow: // 1
                    if(lastDirection != 3)
                        return 1;
                    return lastDirection;

                case ConsoleKey.DownArrow: // 2
                    if(lastDirection != 0)
                        return 2;
                    return lastDirection;

                case ConsoleKey.LeftArrow: // 3
                    if(lastDirection != 1)
                        return 3;
                    return lastDirection;

                default:
                    return lastDirection;

                   
            }
        }

        // Set game over
        public void setGameOver(Boolean gameState){
            gameOver = gameState;
            //Environment.Exit(1); // FOR EXITING GAME
        }
    }
 }



