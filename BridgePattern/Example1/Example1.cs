using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Example1
{
    public class VideoAbstraction
    {
        protected IVideoMode _videoMode;

        public IVideoMode VideoMode
        {
            set { _videoMode = value; }
        }

        public virtual void ShowScreen()
        {
            Console.WriteLine(_videoMode.GetScreen());
        }
    }

    public class VideoRefined : VideoAbstraction
    {
        public override void ShowScreen()
        {
            Console.WriteLine(_videoMode.GetScreen());
        }
    }

    public interface IVideoMode
    {
        public string GetScreen();
    }
    public class OpenGLMode : IVideoMode
    {
        const string MODE_NAME = "OpenGL";
        public string GetScreen()
        {
            return MODE_NAME;
        }
    }
    public class Direct3DMode : IVideoMode
    {
        const string MODE_NAME = "Direct3D";

        public string GetScreen()
        {
            return (MODE_NAME);
        }
    }
}
