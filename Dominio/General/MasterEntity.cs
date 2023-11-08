using System;

namespace hp_prueba_backend.Dominio.General
{
    public class MasterEntity
    {
        public Guid Id { get; set; }
        public bool Activo { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateTime { get; set; }
        public string UpdateBy { get; set; }
        public DateTime UpdateTime { get; set; }

        public MasterEntity()
        {
            Id = Guid.NewGuid();
            Activo = true;
            CreateTime = DateTime.Now;
            UpdateTime = DateTime.Now;
        }
    }
}
