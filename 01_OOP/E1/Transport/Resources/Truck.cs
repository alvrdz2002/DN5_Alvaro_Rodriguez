using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;

namespace AudioManager
{
    public class Truck : Vehicle
    {
        public override void TransportSound()
        {

            AudioFileReader audioFile = new AudioFileReader("Resources/truck.mp3");
            WaveOutEvent waveOutEvent = new WaveOutEvent();

            waveOutEvent.Init(audioFile);
            waveOutEvent.Play();
            while(waveOutEvent.PlaybackState == PlaybackState.Playing)
            {
                System.Threading.Thread.Sleep(500);
            }

            waveOutEvent.Dispose();
            audioFile.Dispose();
        }
    }
}
