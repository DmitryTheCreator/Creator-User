using System.Collections.Generic;

namespace Creator_User.Model
{
    internal class SecondBuffer
    {
        private List<string> messages;
        private int message_index;
        private int character_index;


        public SecondBuffer(int size = 3)
        {        
            if (size < 2)
                throw new System.Exception("Минимальный размер второго буфера - 2 сообщения!");
            messages = new List<string>(size);
            message_index = 0;
            character_index = 0;
        }

        public void Write(char character)
        {
            if (character == '\n')
            {
                if (message_index == messages.Count - 1)
                    messages.RemoveAt(0);
                else
                    message_index++;
                character_index = 0;
                messages.Add("");
            }
            else
                messages[message_index] += character;
        }

        public char Read()
        {
            return messages[message_index][character_index];
        }
    }
}
