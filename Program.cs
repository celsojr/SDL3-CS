using SDL3;

namespace SDL3_CS
{
    class Program
    {
        private static IntPtr window = IntPtr.Zero;
        private static IntPtr renderer = IntPtr.Zero;
        private static bool running = true;

        static void Main(string[] args)
        {
            // if (SDL.SDL_Init(SDL.SDL_INIT_VIDEO) < 0)
            // if (SDL.SDL_Init(SDL.SDL_InitFlags.SDL_INIT_VIDEO))
            // {
            //     Console.WriteLine($"Couldn't initialize SDL: {SDL3.SDL.SDL_GetError()}");
            //     return;
            // }

            window = SDL.SDL_CreateWindow("SDL3 with C#", 640, 480, 0);
            if (window == IntPtr.Zero)
            {
                Console.WriteLine($"Couldn't create window: {SDL.SDL_GetError()}");
                SDL.SDL_Quit();
                return;
            }

            // renderer = SDL.SDL_CreateRenderer(window, null, 0);
            renderer = SDL.SDL_CreateRenderer(window, null);
            if (renderer == IntPtr.Zero)
            {
                Console.WriteLine($"Couldn't create renderer: {SDL.SDL_GetError()}");
                SDL.SDL_DestroyWindow(window);
                SDL.SDL_Quit();
                return;
            }

            RunMainLoop();

            SDL.SDL_DestroyRenderer(renderer);
            SDL.SDL_DestroyWindow(window);
            SDL.SDL_Quit();
        }

        static void RunMainLoop()
        {
            while (running)
            {
                HandleEvents();
                RenderFrame();
                SDL.SDL_Delay(16); // ~60 FPS
            }
        }

        static void HandleEvents()
        {
            SDL.SDL_Event e;
            while (SDL.SDL_PollEvent(out e))
            {
                // if (e.type == SDL.SDL_EVENT_QUIT)
                if (e.type == (nint)SDL.SDL_EventType.SDL_EVENT_QUIT)
                {
                    running = false;
                }
            }
        }

        static void RenderFrame()
        {
            double now = SDL.SDL_GetTicks() / 1000.0;
            
            // Scale the color values to the 0-255 range
            byte red   = (byte)((0.5 + 0.5 * Math.Sin(now)) * 255);
            byte green = (byte)((0.5 + 0.5 * Math.Sin(now + Math.PI * 2 / 3)) * 255);
            byte blue  = (byte)((0.5 + 0.5 * Math.Sin(now + Math.PI * 4 / 3)) * 255);

            SDL.SDL_SetRenderDrawColor(renderer, red, green, blue, 255);  // 255 = full opacity
            SDL.SDL_RenderClear(renderer);
            SDL.SDL_RenderPresent(renderer);
        }
    }
}
