﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IntranetPOPS1819.Models
{
    public class LigneDeFrais
    {
        public Mission Mission { get; set; }
        public StatutLigneDeFrais statut { get; set; }

        //TODO rajouter qlq chose pour les Files
        //Maybe un id + nom de Ligne de Frais qui irait chercher sur le serveur le doc ? 
    }

    public enum StatutLigneDeFrais
    {
    }
}