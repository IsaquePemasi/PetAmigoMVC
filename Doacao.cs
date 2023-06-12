using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PetAmigoMVC;

public partial class Doacao
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "O nome do animal deve ser informado")]
    [Display(Name = "Nome do animal")]
    [StringLength(80, MinimumLength = 10, ErrorMessage = "O {0} tamanho minimo é maximo é {1} caracteres e no maximo {2} caracteres")]
    public string Nome { get; set; } = null!;

    [Required(ErrorMessage = "A raça do animal deve ser informado")]
    [Display(Name = "Raça do animal")]
    [StringLength(80, MinimumLength = 10, ErrorMessage = "O {0} tamanho minimo é maximo é {1} caracteres e no maximo {2} caracteres")]
    public string Raca { get; set; } = null!;

    [Required(ErrorMessage = "O nome do usuário deve ser informado")]
    [Display(Name = "Nome do usuário")]
    [StringLength(80, MinimumLength = 10, ErrorMessage = "O {0} tamanho minimo é maximo é {1} caracteres e no maximo {2} caracteres")]
    public string Usuario { get; set; } = null!;

    [Required(ErrorMessage = "O tipo do animal deve ser informado")]
    [Display(Name = "Tipo do animal")]
    [StringLength(80, MinimumLength = 10, ErrorMessage = "O {0} tamanho minimo é maximo é {1} caracteres e no maximo {2} caracteres")]
    public string Tipo { get; set; } = null!;

    [Display(Name = "Foto do animal")]
    [StringLength(250, MinimumLength = 10, ErrorMessage = "A {0} tamanho minimo é maximo é {1} caracteres e no maximo {2} caracteres")]
    public string Imgurl { get; set; } = null!;

    [Required(ErrorMessage = "A cidade do usuário deve ser informado")]
    [Display(Name = "Cidade do usuário")]
    [StringLength(80, MinimumLength = 10, ErrorMessage = "O {0} tamanho minimo é maximo é {1} caracteres e no maximo {2} caracteres")]
    public string Cidade { get; set; } = null!;

    [Required(ErrorMessage = "O estado do usuário deve ser informado")]
    [Display(Name = "Estado do usuário")]
    [StringLength(80, MinimumLength = 10, ErrorMessage = "O {0} tamanho minimo é maximo é {1} caracteres e no maximo {2} caracteres")]
    public string Estado { get; set; } = null!;

    [Required(ErrorMessage = "O CEP do usuário deve ser informado")]
    [Display(Name = "CEP do usuário")]
    [StringLength(80, MinimumLength = 10, ErrorMessage = "O {0} tamanho minimo é maximo é {1} caracteres e no maximo {2} caracteres")]
    public string Cep { get; set; } = null!;

    [Required(ErrorMessage = "A descrição do animal deve ser informado")]
    [Display(Name = "Descrição do animal")]
    [StringLength(250, MinimumLength = 10, ErrorMessage = "A {0} tamanho minimo é maximo é {1} caracteres e no maximo {2} caracteres")]
    public string Descricao { get; set; } = null!;
}
