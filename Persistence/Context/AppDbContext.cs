using Microsoft.EntityFrameworkCore;
using Barinbar.API.Domain.Model;
using System.Collections.Generic;

namespace Barinbar.API.Persistence.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Profissao> Profissao { get; set; }
        public DbSet<Pessoa> Pessoa { get; set; }

        protected override void OnModelCreating (ModelBuilder builder) 
        {

            builder.Entity<Profissao>().HasKey(p => p.Id);
            builder.Entity<Profissao>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Profissao>().Property(p => p.Descricao).IsRequired().HasMaxLength(30);

            builder.Entity<Profissao>().HasData
            (
                new Profissao { Id = 100, Descricao = "Cozinheiro(a)" },
                new Profissao { Id = 101, Descricao = "Garçom e Garçonete"}
            );

            builder.Entity<Pessoa>().HasKey(p => p.Id);
            builder.Entity<Pessoa>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Pessoa>().Property(p => p.Nome).IsRequired().HasMaxLength(100);

            builder.Entity<Pessoa>().HasData
            (
                new Pessoa
                {
                    Id = 1,
                    Nome = "Samuel Antunes",
                    Imagem = "imgs/people_002.jpg",
                    Posicao = "Chefe de cozinha - especialidade em comida Mineira",
                    Linkedin = "https://linkedin.com",
                    Whatsapp = "https://web.whatsapp.com/",
                    Experiencia = "Experiencia - Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla aliquam purus neque, vel laoreet dui tincidunt eu. Phasellus porta nisl quis nunc fringilla, nec aliquam nisi accumsan. Pellentesque tempus dignissim massa ac mattis.",
                    Formacao = "Formação - Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla aliquam purus neque, vel laoreet dui tincidunt eu. Phasellus porta nisl quis nunc fringilla, nec aliquam nisi accumsan. Pellentesque tempus dignissim massa ac mattis.",
                    Habilidades = "Habilidades - Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla aliquam purus neque, vel laoreet dui tincidunt eu. Phasellus porta nisl quis nunc fringilla, nec aliquam nisi accumsan. Pellentesque tempus dignissim massa ac mattis."
                },
                new Pessoa
                {
                    Id = 2,
                    Nome = "Kenya Azeredo",
                    Imagem = "imgs/people_001.jpg",
                    Posicao = "Chefe de cozinha - especialidade em comida Mexicana",
                    Linkedin = "https://linkedin.com",
                    Whatsapp = "https://web.whatsapp.com/",
                    Experiencia = "Experiencia - Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla aliquam purus neque, vel laoreet dui tincidunt eu. Phasellus porta nisl quis nunc fringilla, nec aliquam nisi accumsan. Pellentesque tempus dignissim massa ac mattis.",
                    Formacao = "Formação - Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla aliquam purus neque, vel laoreet dui tincidunt eu. Phasellus porta nisl quis nunc fringilla, nec aliquam nisi accumsan. Pellentesque tempus dignissim massa ac mattis.",
                    Habilidades = "Habilidades - Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla aliquam purus neque, vel laoreet dui tincidunt eu. Phasellus porta nisl quis nunc fringilla, nec aliquam nisi accumsan. Pellentesque tempus dignissim massa ac mattis."
                },
                new Pessoa
                {
                    Id = 3,
                    Nome = "Cicero Melo",
                    Imagem = "imgs/people_004.jpg",
                    Posicao = "Garçom com conhecimento em drinks",
                    Linkedin = "https://linkedin.com",
                    Whatsapp = "https://web.whatsapp.com/",
                    Experiencia = "Experiencia - Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla aliquam purus neque, vel laoreet dui tincidunt eu. Phasellus porta nisl quis nunc fringilla, nec aliquam nisi accumsan. Pellentesque tempus dignissim massa ac mattis.",
                    Formacao = "Formação - Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla aliquam purus neque, vel laoreet dui tincidunt eu. Phasellus porta nisl quis nunc fringilla, nec aliquam nisi accumsan. Pellentesque tempus dignissim massa ac mattis.",
                    Habilidades = "Habilidades - Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla aliquam purus neque, vel laoreet dui tincidunt eu. Phasellus porta nisl quis nunc fringilla, nec aliquam nisi accumsan. Pellentesque tempus dignissim massa ac mattis."
                }
            );


        }

    }
}