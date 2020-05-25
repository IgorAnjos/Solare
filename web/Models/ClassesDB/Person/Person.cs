using System;

namespace Solare.Models
{
    public class Person : Customer
    {    
        public override string ToString()
        {
            return String.Format(
                "PersonId={0} NamePerson={1} CPF={2}",
                _personId,
                _namePerson ?? "",
                _cpf ?? ""
                );   
        }
        int _personId;
        public int PersonId
        {
            get => _personId;
            set => _personId = value;
        }

        string _namePerson;
        public string? NamePerson
        {
            get => _namePerson;
            set => _namePerson = value;
        }

        string _cpf;
        public string? CPF 
        {
            get => _cpf;
            set => _cpf = value;
        }
    }
}