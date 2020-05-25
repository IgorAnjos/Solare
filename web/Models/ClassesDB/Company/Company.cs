using System;
using System.Collections.Generic;
using System.Text;

namespace Solare.Models
{
    public class Company : Customer
    {
        public override string ToString()
        {
            return String.Format(
                "CompanyId={0} CNPJ={1} CompanyName={2} FantasyName={3} Description={4}",
                _companyId,
                _cnpj ?? "",
                _companyName ?? "",
                _fantasyName ?? "",
                _description ?? ""
                );
        }
        int _companyId;
        public int CompanyId
        {
            get => _companyId;
            set => _companyId = value;
        }

        string? _cnpj;
        public string? CNPJ
        {
            get => _cnpj;
            set => _cnpj = value;
        }

        string? _companyName;
        public string? CompanyName
        {
            get => _companyName;
            set => _companyName = value;
        }

        string? _fantasyName;
        public string? FantasyName
        {
            get => _fantasyName;
            set => _fantasyName = value;
        }

        string? _description;
        public string? Description
        {
            get => _description;
            set => _description = value;
        }
    }
}