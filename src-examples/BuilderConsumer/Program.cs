using System;
using System.Collections.Generic;

namespace BuilderConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            var email = new GeneratedClassBuilders.EmailDtoBuilder()
                .WithValue("x@x.nl")
                .Build();

            var user = new GeneratedClassBuilders.UserDtoBuilder()
                        .WithFirstName("Stef")
                        .WithLastName("Heyenrath")
                        .WithPrimaryEmail(email)
                        .Build();

            Console.WriteLine($"{user.FirstName} {user.LastName} {user.PrimaryEmail.Value}");
        }
    }

    [GeneratedClassBuilders.AutoGenerateBuilder]
    public class UserDto
    {
       public string FirstName { get; set; }

        public string LastName { get; set; }

        public EmailDto PrimaryEmail { get; set; }

        public IEnumerable<EmailDto> SecondaryEmails { get; set; }

        public DateTime? QuitDate { get; set; }
    }

    [GeneratedClassBuilders.AutoGenerateBuilder]
    public class EmailDto
    {
        public string Value { get; set; }
    }
}