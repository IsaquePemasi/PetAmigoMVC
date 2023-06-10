using System;
using System.Collections.Generic;

namespace PetAmigoMVC;

public partial class Doacao
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public string Raca { get; set; } = null!;

    public string Usuario { get; set; } = null!;

    public string Tipo { get; set; } = null!;

    public string Imgurl { get; set; } = null!;

    public string Cidade { get; set; } = null!;

    public string Estado { get; set; } = null!;

    public string Cep { get; set; } = null!;

    public string Descricao { get; set; } = null!;
}
