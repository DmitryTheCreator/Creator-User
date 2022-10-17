namespace Creator_User.Model
{
    internal class FirstBuffer
    {
        private string message;
        private int character_index;

        public void Write(string message)
        {
            this.message = message + '\n';
            character_index = 0;
        }

        public char Read()
        {
            if (message.Length == 0 || message == "\n")
                throw new System.Exception("Буфер пуст!");
            return message[character_index++];
        }
    }
}
