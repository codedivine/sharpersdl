//Copyright (c) 2018, Rahul Garg
//This file is distributed as part of SharperSDL project under the BSD 3-clause "new" license 
//See the LICENSE file for details

using System;
using System.Runtime.InteropServices;

namespace SharperSDL
{
    public class SDL
    {
        [System.Flags]
        public enum InitFlags
        {
            SDL_INIT_TIMER =  0x1,
            SDL_INIT_AUDIO =  0x10,
            SDL_INIT_VIDEO = 0x20,
            SDL_INIT_JOYSTICK = 0x200,
            SDL_INIT_HAPTIC = 0x1000,
            SDL_INIT_GAMECONTROLLER = 0x2000,
            SDL_INIT_EVENTS = 0x4000,
            SDL_INIT_SENSOR = 0x8000,
            SDL_INIT_PARACHUTE = 0x10000
        }
        [DllImport("SDL",EntryPoint="SDL_Init",CallingConvention=CallingConvention.Cdecl)]
        public static extern int Init(InitFlags i);

        [DllImport("SDL",EntryPoint="SDL_Quit", CallingConvention = CallingConvention.Cdecl)]
        public static extern void Quit();
    }
}
