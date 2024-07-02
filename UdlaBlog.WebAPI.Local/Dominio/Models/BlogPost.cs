﻿using System.ComponentModel.DataAnnotations;
using UdlaBlog.WebAPI.Local.Domain.Models;

public class BlogPost
{
    public Guid Id { get; set; }

    [Required]
    public string Encabezado { get; set; }

    [Required]
    public string TituloPagina { get; set; }

    [Required]
    public string Contenido { get; set; }

    [Required]
    public string DescripcionCorta { get; set; }

    public string UrlImagenDestacada { get; set; }

    public string ManejadorUrl { get; set; }

    [Required]
    public DateTime FechaPublicacion { get; set; }

    [Required]
    public string Autor { get; set; }

    [Required]
    public bool Visible { get; set; }

    [Required]
    public ICollection<Tag> Tags { get; set; } = new List<Tag>();

    public ICollection<Comment> Comments { get; set; } = new List<Comment>();

    public string RutaImagen { get; set; }

    [Required]
    public string Section { get; set; }
}
