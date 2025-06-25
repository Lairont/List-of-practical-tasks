using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    // Интерфейс для воспроизведения
    interface IPlayable
    {
        void Play();  // Метод для начала воспроизведения
        void Pause(); // Метод для приостановки воспроизведения
        void Stop();  // Метод для остановки воспроизведения
    }

    // Интерфейс для записи
    interface IRecodable
    {
        void Record(); // Метод для начала записи
        void Pause();  // Метод для приостановки записи
        void Stop();   // Метод для остановки записи
    }

    // Класс Player реализует оба интерфейса: IPlayable и IRecodable
    class Player : IPlayable, IRecodable
    {
        // Реализация метода Play из интерфейса IPlayable (открытая реализация)
        public void Play()
        {
            Console.WriteLine("Playing...");
        }

        // Явная реализация метода Pause для интерфейса IPlayable
        void IPlayable.Pause()
        {
            Console.WriteLine("Paused...");
        }

        // Явная реализация метода Stop для интерфейса IPlayable
        void IPlayable.Stop()
        {
            Console.WriteLine("Stopped...");
        }

        // Реализация метода Record из интерфейса IRecodable (открытая реализация)
        public void Record()
        {
            Console.WriteLine("Recording...");
        }

        // Явная реализация метода Pause для интерфейса IRecodable
        void IRecodable.Pause()
        {
            Console.WriteLine("Paused...");
        }

        // Явная реализация метода Stop для интерфейса IRecodable
        void IRecodable.Stop()
        {
            Console.WriteLine("Stopped...");
        }
    }
}