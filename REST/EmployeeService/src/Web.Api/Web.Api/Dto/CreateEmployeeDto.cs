﻿namespace Web.Api.Dto
{
    public record CreateEmployeeDto
    {
        public int Id { get; set; }
        public string Position { get; set; }

        public decimal Salary { get; set; }

        public string Department { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }
    }
}
