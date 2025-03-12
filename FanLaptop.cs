using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_103022300016
{
    public enum fanState { Quiet, Balanced, Performance, Turbo };
    public enum trigger { modeDown, modeUp, turboShortcut };
    internal class FanLaptop
    {
        private fanState fanState; // variabel status fan

        public FanLaptop()
        // Construtor untuk membuat status awal fan menjadi quiet
        {
            fanState = fanState.Quiet;
        }

        public void ubahStateFan(trigger opsi)
        {
            switch (fanState)
            {
                case fanState.Quiet:
                // kasus untuk pemilihan status fan quiet
                    if (opsi == trigger.modeUp) // jika terpilih modeUp
                    {
                        fanState = fanState.Balanced; // mengubah status fan menjadi balanced
                        Console.WriteLine("Fan Mode Quite berubah menjadi Mode Balanced");
                    }
                    else if (opsi == trigger.turboShortcut) // jika terpilih turboShortcut
                    {
                        fanState = fanState.Turbo; // mengubah status fan menjadi turbo
                        Console.WriteLine("Fan Mode Quite berubah menjadi Mode Turbo");
                    }
                    else // jika terpilih modeDown maka akan menampilkan pesan sudah di mode quiet
                    {
                        Console.WriteLine("Fan sudah di Mode Quiet");
                    }
                    break;
                case fanState.Balanced:
                // kasus untuk pemilihan status fan balanced
                    if (opsi == trigger.modeDown) // jika terpilih mode down
                    {
                        fanState = fanState.Quiet; // mengubah status fan menjadi quiet
                        Console.WriteLine("Fan Mode Balanced berubah menjadi Mode Quiet");
                    }
                    else if (opsi == trigger.modeUp) // jika terpilih mode up
                    {
                        fanState = fanState.Performance; // mengubah status fan menjadi performance
                        Console.WriteLine("Fan Mode Balanced berubah menjadi Mode Performance");
                    }
                    break;
                case fanState.Performance:
                // kasus untuk pemilihan status fan performance
                    if (opsi == trigger.modeDown) // jika terpilih modeDown
                    {
                        fanState = fanState.Balanced; // merubah status fan menjadi balanced
                        Console.WriteLine("Fan Mode Performance berubah menjadi Mode Balanced");
                    }
                    else if (opsi == trigger.modeUp) // jika terpilih modeUp
                    {
                        fanState = fanState.Turbo; // merubah status fan menjadi turbo
                        Console.WriteLine("Fan Mode Performance berubah menjadi Mode Turbo");

                    }
                    break;
                case fanState.Turbo:
                // kasus untuk pemilihan status fan turbo
                    if (opsi == trigger.modeDown) // jika terpilih modeDown
                    {
                        fanState = fanState.Performance; // mengubah status fan menjadi performance
                        Console.WriteLine("Fan Mode Turbo berubah menjadi Mode Performance");
                    }
                    else if (opsi == trigger.turboShortcut) // jika terpilih turboShortcut
                    {
                        fanState = fanState.Quiet; // mengubah status fan menjadi quiet
                        Console.WriteLine("Fan Mode Turbo berubah menjadi Mode Quiet");
                    }
                    else // jika terpilih modeUp maka akan menampilkan pesan sudah di mode turbo
                    {
                        Console.WriteLine("Posisi Fan Sudah di Turbo");
                    }
                    break;
            }
        }

        public void getStatusFan()
        // method untuk menampilkan status fan
        {
            Console.WriteLine("Status Fan: " + fanState);
        }
    }
}
