using System;

namespace Practica1_p2.Domain
{
    //Variables para la consulta de datos
    public record Person(int Id, string FirstName, string LastName, string Email, string Gender, string Job, int Age);
}