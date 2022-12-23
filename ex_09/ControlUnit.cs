namespace ex_09
{
    internal class ControlUnit
    {
        private List<Command> commands = new List<Command>();
        private int current = 0;

        public void StoreCommand(Command command)
        {
            commands.Add(command);
        }

     
        public void ExecuteCommand()
        {
            commands[current].Execute();
            current++;
        }

    
        public void Undo()
        {
            commands[current - 1].UnExecute();
        }

    
        public void Undo(int element)
        {
            for (int i = 0; i < element; i++)
            {
                commands[current - 1].UnExecute();
            }
        }

        public void Redo()
        {
            commands[current - 1].Execute();
        }

        public void Redo(int element)
        {
            for (int i = 0; i < element; i++)
            {
                commands[current - 1].Execute();
            }
        }
    }
}
