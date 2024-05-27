﻿
using IkMvc.Application.Model.Enums;
using System.Text.Json.Serialization;

namespace Ik_Bitirme.Application.Models.DTos.UserDtos
{
    public class UserDto
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonPropertyName("userName")]
        public string UserName { get; set; }
        [JsonPropertyName("firstName")]
        public string FirstName { get; set; }
        [JsonPropertyName("middleName")]
        public string? MiddleName { get; set; }
        [JsonPropertyName("lastName")]
        public string LastName { get; set; }
        [JsonPropertyName("secondLastName")]
        public string? SecondLastName { get; set; }
        [JsonPropertyName("birthDate")]
        public DateTime BirthDate { get; set; }
        [JsonPropertyName("birthPlace")]
        public string BirthPlace { get; set; }
        [JsonPropertyName("tcIdentity")]
        public string TcIdentity { get; set; }
        [JsonPropertyName("hireDate")]
        public DateTime HireDate { get; set; }
        [JsonPropertyName("terminationDate")]
        public DateTime? TerminationDate { get; set; }
        [JsonPropertyName("phoneNumber")]
        public string PhoneNumber { get; set; }
        [JsonPropertyName("address")]
        public string Address { get; set; }
        [JsonPropertyName("salary")]
        public decimal Salary { get; set; }
        [JsonPropertyName("imageData")]
        public byte[]? ImageData { get; set; }
        [JsonPropertyName("jobId")]
        public int? JobId { get; set; }
        [JsonPropertyName("createDate")]
        
        public DateTime CreateDate { get; set; }
        [JsonPropertyName("updateDate")]
        public DateTime? UpdateDate { get; set; }
        [JsonPropertyName("deleteDate")]
        public DateTime? DeleteDate { get; set; }
        [JsonPropertyName("status")]
        public Status Status { get; set; }
        [JsonPropertyName("departmentId")]
        public int? DepartmentId { get; set; }
        [JsonPropertyName("companyId")]
        public int? CompanyId { get; set; }
        
        [JsonPropertyName("role")]
        public string Role { get; set; }
        [JsonPropertyName("email")]
        public string Email { get; set; }
    }
}