using System;
using System.ComponentModel.DataAnnotations;

namespace Solare.Models
{
    public class User
    {
        // Verificar se vamos utilizar 'AccessGroup' como propriedade ou separado numa 'enum'
        public override string ToString()
        {
            return string.Format(
                "Email={0} Password={1} Name={2} CreatedOn={3} CreatedById={4} ModifiedOn={5} ModifiedById={6} Enabled={7} Notes={8}",
                _email,
                _password,
                _name,
                _createdOn,
                _createdById,
                _modifiedOn,
                _modifiedById,
                _enabled,
                _notes ?? ""
                );
        }

        string _email;
        public string Email
        {
            get => _email;
            set => _email = value;
        }

        string _password;
        public string Password
        {
            get => _password;
            set => _password = value;
        }

        string _name;
        public string Name
        {
            get => _name;
            set => _name = value;
        }
        // string _accessGroup;
        // public string AccessGroup
        // {
        //     get => _accessGroup;
        //     set => _accessGroup = value;
        // }
        DateTime _createdOn;
        public DateTime CreatedOn
        {
            get => _createdOn;
            set => _createdOn = value;
        }
        int _createdById;
        public int CreatedById
        {
            get => _createdById;
            set => _createdById = value;
        }
        DateTime _modifiedOn;
        public DateTime ModifiedOn
        {
            get => _modifiedOn;
            set => _modifiedOn = value;
        }
        int _modifiedById;
        public int ModifiedById
        {
            get => _modifiedById;
            set => _modifiedById = value;
        }
        bool _enabled;
        public bool Enabled
        {
            get => _enabled;
            set => _enabled = value;
        }
        string? _notes;
        public string? Notes
        {
            get => _notes;
            set => _notes = value;
        }
    }
}