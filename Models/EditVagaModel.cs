using ONGLIVES.API.Entidades;

public class EditVagaModel 
{
        //vagaEdit.VoluntarioId = vaga.VoluntarioId;
        //vagaEdit.Voluntario = vaga.Voluntario;
        //vagaEdit.OngId = vaga.OngId;
        // vagaEdit.Ong = vaga.Ong;
        //vagaEdit.Tipo = vaga.Tipo;
        public int Id {get; set;}
        public string? Tipo {get; set;}
        //vagaEdit.Turno = vaga.Turno;
        public string? Turno {get; set;}
        //vagaEdit.Descricao = vaga.Descricao;
        public string? Descricao {get; set;}      
        //vagaEdit.Habilidade = vaga.Habilidade;
        public string? Habilidade {get; set;}
        //vagaEdit.DataInicio = vaga.DataInicio;
        public DateTime DataInicio {get; set;}
        //vagaEdit.DataFim = vaga.DataFim;
        public DateTime DataFim {get; set;}
}