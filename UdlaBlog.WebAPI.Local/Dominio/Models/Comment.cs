﻿using System;
using System.ComponentModel.DataAnnotations;

namespace UdlaBlog.Domain.Entities
{
    public class Comment
    {
        [Key]
        public Guid Id { get; set; }
        public string Contenido { get; set; }

        public DateTime Fecha { get; set; }

        public Guid? BlogFicaId { get; set; }
        public BlogFica BlogFica { get; set; }

        public Guid? BlogNodoId { get; set; }
        public BlogNodo BlogNodo { get; set; }
    }
}
