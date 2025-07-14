using System.Collections.Generic;
using System.Reflection.Emit;

using Microsoft.EntityFrameworkCore;
using Eddian_Vasquez_Ap1_P2.Models;
namespace Eddian_Vasquez_Ap1_P2
{

    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

