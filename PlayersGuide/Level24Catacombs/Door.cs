using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Level24Catacombs.DoorStates;

namespace Level24Catacombs
{
    public class Door
    {
        public DoorState CurrentState { get; private set; }
        private int _passcode;

        public Door(int passcode)
        {
            _passcode = passcode;
        }

        public void CloseDoor()
        {

            if (CurrentState == DoorState.Open)
            {
                CurrentState = DoorState.Closed;
            }
        }

        public void OpenDoor()
        {
            if (CurrentState == DoorState.Closed)
            {
                CurrentState = DoorState.Open;
            }
        }

        public void LockDoor()
        {
            if (CurrentState == DoorState.Closed)
            {
                CurrentState = DoorState.Locked;
            }
        }
        public void UnlockDoor(int passcode)
        {
            if (passcode == _passcode)
            {
                CurrentState = DoorState.Closed;
            }
        }
        public void ChangePasscode(int oldPasscode, int newPasscode)
        {
            if (oldPasscode == _passcode)
            {
                _passcode = newPasscode;
            }
        }
    }
}
