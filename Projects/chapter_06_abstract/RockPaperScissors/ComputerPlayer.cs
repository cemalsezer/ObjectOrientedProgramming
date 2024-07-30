public abstract class ComputerPlayer: Player
    {
   
        protected ComputerPlayer(string name) : base(name) { }

        public abstract override void SelectMove();

    }   

