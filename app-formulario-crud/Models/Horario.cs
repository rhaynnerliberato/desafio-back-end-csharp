using System;

namespace app_formulario_crud.Models
{
    public class Horario
    {
        public int Id {get; set;}
        public string DiaDaSemana { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFim { get; set; }
        public int TempoDeDescanso { get; set; }
        public TimeSpan CargaHoraria { get; set; }
        public TimeSpan CargaHorariaSemanal { get; set; }

    }
}
