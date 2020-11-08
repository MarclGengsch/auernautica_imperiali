using System;
using System.Collections.Generic;

namespace auernautica_imperiali {
    public class GameEngine {        //well i dont know
        private static List<AOrk> _orkList = new List<AOrk>();
        private static List<AImperiali> _imperialiList = new List<AImperiali>();
        public Map map = new Map();
        
        public static List<AOrk> OrkList {
            get => _orkList;
            set => _orkList = value;
        }

        public static List<AImperiali> ImperialiList {
            get => _imperialiList;
            set => _imperialiList = value;
        }

        private GameEngine()
        {
        }
        
        static GameEngine _gameEngine = new GameEngine();

        public static GameEngine GetInstance()
        {
            return _gameEngine;
        }

        public void ExecuteCommands(List<ICommand> commands) {
            foreach (var command in commands) {
                if (!command.Execute()) {
                    throw new ArgumentException();
                }
            }
        }
    }
}