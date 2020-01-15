﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Simple_CRUD_With_IoC.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }

        [ForeignKey("Company")]
        public int? CompanyId { get; set; }

        [JsonIgnore]
        public Company Company { get; set; }

        [ForeignKey("Pasport")]
        public int? PasportId { get; set; }

        [JsonIgnore]
        public Pasport Pasport { get; set; }
    }
    public class Company
    {
        [Key]
        public int Companyid { get; set; }

        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
    }
    public class Pasport
    {
        [Key]
        public int Pasportid { get; set; }
        public string Type { get; set; }
        public string Number { get; set; }
    }
}