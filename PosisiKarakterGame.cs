using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_1302223027
{

    internal class PosisiKarakterGame
    {
        public enum PosisiState { Jongkok, Berdiri, Terbang, Terungkurap}


        public void runState() { 
            PosisiState state = PosisiState.Berdiri;

            string command = "";

           

          
            while (command != "exit") {
                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine("STATE SAAT INI ADALAH "+state);  
                Console.WriteLine("ENTER COMMAND");    
                command = Console.ReadLine();


                switch (state)
                {
                    case PosisiState.Jongkok:
                        if (command =="S")
                        {
                            state = PosisiState.Terungkurap;
                        }
                        else if (command =="W")
                        {
                            state = PosisiState.Berdiri;
                        }
                        break;
                    case PosisiState.Terungkurap:
                        if (command =="W") {
                            state = PosisiState.Jongkok;
                        }
                        break;
                    case PosisiState.Berdiri:
                        if (command == "W")
                        {
                            state = PosisiState.Terbang;
                        } 
                        if (command == "S")
                        {
                            state = PosisiState.Jongkok;
                        }
                        break;

                    case PosisiState.Terbang:
                        if (command =="S")
                        {
                            state = PosisiState.Berdiri;
                        }

                        if(command == "X")
                        {
                            state = PosisiState.Jongkok;
                        }
                        break;

                }

                if (command =="W")
                {
                    Console.WriteLine("tombol w ditekan");
                }

                if (state == PosisiState.Berdiri)
                {
                    Console.WriteLine("posisi standby");
                }

                if (state == PosisiState.Terungkurap)
                {
                    Console.WriteLine("posisi istirahat");
                }

            }
        }
    }
}
