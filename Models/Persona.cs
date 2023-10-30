namespace DojoSurveyMVC.Models;
#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;

public class Persona{

    [Required(ErrorMessage ="Por favor proporciona este dato")]
    [MinLength(2, ErrorMessage ="Tu nombre debe tener almenos 2 caracteres")]
    public string Nombre {get; set;}

    public string Direccion {get; set;}

    public string Lenguaje {get; set;}

    [StringLength(20, MinimumLength = 20, ErrorMessage = "El comentario debe tener al menos 20 caracteres.")]
    public string Comentario {get; set;}
}