using System;

namespace SevenWondersGameLibrary.DataModels
{
    public interface IUser
    {
        Guid AssociatedWonderBoard { get; set; }

        DateTime CreationTime { get; }

        string DisplayName { get; }

        Guid Id { get; }

        string ImagePath { get; }

        uint Position { get; }
    }
}