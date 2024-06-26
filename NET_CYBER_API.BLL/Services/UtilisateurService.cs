﻿using Microsoft.EntityFrameworkCore;
using NET_CYBER_API.BLL.Interfaces;
using NET_CYBER_API.DAL.Interfaces;
using NET_CYBER_API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NET_CYBER_API.BLL.Services
{
    public class UtilisateurService : IUtilisateurService
    {
        private readonly IUtilisateurRepository _repository;

        public UtilisateurService(IUtilisateurRepository repository)
        {
            _repository = repository;
        }

        public Utilisateur Create(Utilisateur Utilisateur)
        {
            //Mettre le Bcrypt

            return _repository.Create(Utilisateur);
        }

        public bool Delete(int id)
        {
            try
            {
                Utilisateur? utilisateur = GetById(id);
                if (utilisateur is not null)
                {
                    return  _repository.Delete(utilisateur);
                   
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        
        }

        public IEnumerable<Utilisateur> GetAll()
        {
            throw new NotImplementedException();
        }

        public Utilisateur GetByEmail(string email)
        {
            Utilisateur? utilisateur = _service.GetByEmail(email);
        }

        public Utilisateur GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Utilisateur Update(Utilisateur Utilisateur)
        {
            throw new NotImplementedException();
        }
    }
}
