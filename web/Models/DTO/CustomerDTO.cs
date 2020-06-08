using System;
using System.ComponentModel.DataAnnotations;

namespace web.Models.DTO
{
    public class CustomerDTO
    {
        
        public override string ToString()
        {
            return String.Format(
                "CustomerId={0} FullName={17} Type={1} DateOfBirth={2} BirthTime={3} CityOfBirth={4} BirthState={5} DaylightSaving={6} CityCurrent={7} CurrentState={8}" +
                "CurrentAddress={9} CEP={10} Email1={11} Email2={12} Mobile1={13} Mobile2={14} Telephone1={15} Telephone2={16}",
                _customerId,
                _type,
                _dateOfBirth ?? throw new ArgumentNullException(nameof(_dateOfBirth), "Data de Nascimento não pode ser nula"),
                _birthTime ?? throw new ArgumentNullException(nameof(_birthTime), "Horário de Nascimento não pode ser nula"),
                _cityOfBirth ?? throw new ArgumentNullException(nameof(_cityOfBirth), "Cidade de Nascimento não pode ser nula"),
                _birthState ?? throw new ArgumentNullException(nameof(_birthState), "Estado de Nascimento não pode ser nula"),
                _daylightSaving,
                _cityCurrent ?? "",
                _currentState ?? "",
                _currentAddress ?? "",
                _cep ?? "",
                _email1 ?? "",
                _email2 ?? "",
                _mobile1 ?? "",
                _mobile2 ?? "",
                _telephone1 ?? "",
                _telephone2 ?? "",
                _fullName
                );
        }
        int _customerId; 
        public int CustomerId
        {
            get => _customerId;
            set => _customerId = value;
        }
        
        string _fullName;
        public string FullName
        {
            get => _fullName;
            set => _fullName = value;
        }

        CustomerType _type;
        public CustomerType Type
        {
            get => _type;
            set => _type = value;
        }

        #region Informações de Nascimento
        string _dateOfBirth;
        public string DateOfBirth
        {
            get => _dateOfBirth;
            set => _dateOfBirth = value;
        }
        string _birthTime;
        public string BirthTime
        {
            get => _birthTime;
            set => _birthTime = value;
        }
        string _cityOfBirth;
        public string CityOfBirth
        {
            get => _cityOfBirth;
            set => _cityOfBirth = value;
        }
        string _birthState;
        public string BirthState
        {
            get => _birthState;
            set => _birthState= value;
        }
        bool _daylightSaving;
        public bool DaylightSaving
        {
            get => _daylightSaving;
            set => _daylightSaving = value;
        }
        #endregion

        #region Endereço Local
        string? _cityCurrent;
        public string CityCurrent
        {
            get => _cityCurrent;
            set => _cityCurrent = value;
        }
        string? _currentState;
        public string CurrentState
        {
            get => _currentState;
            set => _currentState = value;
        }
        string? _currentAddress;
        public string CurrentAddress
        {
            get => _currentAddress;
            set => _currentAddress = value;
        }
        string? _cep;
        public string CEP
        {
            get => _cep;
            set => _cep = value;
        }
            
        #endregion

        #region Contato
        string? _email1;
        public string? Email1
        {
            get => _email1;
            set => _email1 = value;
        }
        string? _email2;
        public string Email2
        {
            get => _email2;
            set => _email2 = value;
        }

        string? _mobile1;
        public string Mobile1
        {
            get => _mobile1;
            set => _mobile1 = value;
        }

        string? _mobile2;
        public string Mobile2
        {
            get => _mobile2;
            set => _mobile2 = value;
        }

        string? _telephone1;
        public string Telephone1
        {
            get => _telephone1;
            set => _telephone1 = value;
        }

        string? _telephone2;
        public string Telephone2
        {
            get => _telephone2;
            set => _telephone2 = value;
        }
        #endregion
    }
}