﻿namespace NotasFiscaisAPI.Models
{
    public class User
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Password { get; set; }


        public User()
        {
            this.Id = new Guid();
        }
    }
}
