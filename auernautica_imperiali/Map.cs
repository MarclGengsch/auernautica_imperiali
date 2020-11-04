using System;
using System.Text;
using System.Threading;

namespace auernautica_imperiali {
    public class Map {
        public const int Altitude = 5, Width = 15, Height = 15;

        public Map() {
        }

        public void PrintMap() {
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= Height; i++) {
                for (int j = 1; j <= Altitude; j++) {
                    for (int k = 1; k <= Width; k++) {
                        bool written = false;
                        foreach (AOrk _orks in GameEngine.OrkList) {
                            if (_orks.Equals(new Point(k,i,j))) {        //funktioniert nicht mehr !!!!!!!
                                sb.Append("o ");
                                written = true;
                            }
                        }

                        foreach (AImperiali _imperiali in GameEngine.ImperialiList) {
                            if (_imperiali.Equals(new Point(k, i, j))) {
                                sb.Append("i ");
                                written = true;
                            }
                        }

                        if (!written) {
                            sb.Append("_ ");
                        }
                    }

                    sb.Append("  ");
                }

                sb.AppendLine();
            }

            Console.WriteLine(sb.ToString());
        }
    }
}