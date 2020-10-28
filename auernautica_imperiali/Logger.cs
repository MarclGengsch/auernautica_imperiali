using System;

namespace auernautica_imperiali {
    public class Logger {
        private Logger() {
        }

        private static Logger instance = new Logger();
        public static bool LOG_TO_CONSOLE = true;

        public static Logger GetInstance() {
            return instance;
        }

        public void Info(string info) {
            if (LOG_TO_CONSOLE) {
                Console.WriteLine(info);
            }
        }
    }
}