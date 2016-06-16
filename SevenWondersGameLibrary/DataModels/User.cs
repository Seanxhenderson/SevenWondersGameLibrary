using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenWondersGameLibrary.DataModels
{
    public class User : IUser
    {
        public User(string displayName, string imagePath, uint position, Guid associatedWonderBoard)
        {
            this.Id = Guid.NewGuid();
            this.CreationTime = DateTime.Now;
            this.DisplayName = displayName;
            this.ImagePath = imagePath;
            this.Position = position;
            this.AssociatedWonderBoard = associatedWonderBoard;
        }

        public Guid Id
        {
            get;
            private set;
        }

        public DateTime CreationTime
        {
            get;
            private set;
        }

        public string DisplayName
        {
            get;
            private set;
        }

        public string ImagePath
        {
            get;
            private set;
        }

        public uint Position
        {
            get;
            private set;
        }

        public Guid AssociatedWonderBoard
        {
            get;
            set;
        }
    }
}
