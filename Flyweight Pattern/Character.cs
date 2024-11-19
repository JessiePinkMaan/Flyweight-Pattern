using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight_Pattern
{
    public class Character
    {
        public string Name { 
            get; 
            private set; 
        }

        public string Type { 
            get;
            private set;
        }

        public string Image {
            get;
            private set;
        }



        private Character(string name, string type, string image)
        {
            Name = name;
            Type = type;
            Image = image;

        }

        // Внутренняя фабрика
        public class CharacterFactory
        {
            private readonly Dictionary<string, Character> charlist = new Dictionary<string, Character>();//словарь для хранения ключей 
        

            public Character GetCharacter(string name, string type, string image)
            {
                string key = $"{name}_{type}";//создания ключа 

                if (charlist.TryGetValue(key, out var existingCharacter))// ищем ключ в словаре или добавляем новый
                {
                    return existingCharacter;
                }

                var newC = new Character(name, type, image);
                charlist[key] = newC;

               
                return newC ;
            }
        }
    }
}
