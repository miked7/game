using CanvasTest.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CanvasTest
{
    public class MainViewModel : AbstractViewModelBase
    {
        private enum EDirection
        {
            Left,
            Right,
            Up,
            Down
        }

        private ICommand leftCommand;
        private ICommand rightCommand;
        private ICommand upCommand;
        private ICommand downCommand;

        private double width;
        private double height;

        private double xPosition;
        private double yPosition;

        private EDirection currentDirection;

        public MainViewModel()
        {
            this.leftCommand = new ActionCommand(this.LeftCommandReq);
            this.rightCommand = new ActionCommand(this.RightCommandReq);
            this.upCommand = new ActionCommand(this.UpCommandReq);
            this.downCommand = new ActionCommand(this.DownCommandReq);

            this.width = 300;
            this.height = 300;

            this.currentDirection = EDirection.Right;
        }

        public ICommand LeftCommand
        {
            get
            {
                return this.leftCommand;
            }
        }

        public ICommand RightCommand
        {
            get
            {
                return this.rightCommand;
            }
        }

        public ICommand UpCommand
        {
            get
            {
                return this.upCommand;
            }
        }

        public ICommand DownCommand
        {
            get
            {
                return this.downCommand;
            }
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            private set
            {
                if (this.width != value)
                {
                    this.width = value;
                    this.OnPropertyChanged("Width");
                }
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            private set
            {
                if (this.height != value)
                {
                    this.height = value;
                    this.OnPropertyChanged("Height");
                }
            }
        }

        public double XPostion
        {
            get
            {
                return this.xPosition;
            }

            private set
            {
                if (this.xPosition != value)
                {
                    this.xPosition = value;
                    this.OnPropertyChanged("XPostion");
                }
            }
        }

        public double YPostion
        {
            get
            {
                return this.yPosition;
            }

            private set
            {
                if (this.yPosition != value)
                {
                    this.yPosition = value;
                    this.OnPropertyChanged("YPostion");
                }
            }
        }

        private void LeftCommandReq()
        {
            this.Width -= 5;
        }

        private void RightCommandReq()
        {
            this.Width += 5;
        }

        private void UpCommandReq()
        {
            this.Height -= 5;
        }

        private void DownCommandReq()
        {
            this.Height += 5;
        }

    }
}
