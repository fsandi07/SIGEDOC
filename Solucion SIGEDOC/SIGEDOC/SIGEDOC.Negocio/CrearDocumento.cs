using System;
namespace SIGEDOC.Negocio
{
    public class CrearDocumento
    {
        // opcion para el procedimiento almacenado;
        private int opc;
        private int total_doc_creado;
        private string nom_doc_creado;
        private string asunto_doc_creado;
        private string detalle_doc_creado;
        private int id_usuario;
        private int id_proyecto;
        private int num_consecutivo;
        private byte[] word_doc_creado;
        private byte[] pdf_doc_creado;
        private string estado_doc_creado;
        private DateTime fecha_doc_subido;
        private int id_cliente;
        private string periodo;
        private string num_referencia_creado;
        private int habilitado;
        private string ModificadoPor;
        private string NombreRealWord;
        private string NombreRealPdf;
        public int Opc { get => opc; set => opc = value; }
        public int Total_doc_creado { get => total_doc_creado; set => total_doc_creado = value; }
        public string Nom_doc_creado { get => nom_doc_creado; set => nom_doc_creado = value; }
        public string Asunto_doc_creado { get => asunto_doc_creado; set => asunto_doc_creado = value; }
        public string Detalle_doc_creado { get => detalle_doc_creado; set => detalle_doc_creado = value; }
        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
        public int Id_proyecto { get => id_proyecto; set => id_proyecto = value; }
        public int Num_consecutivo { get => num_consecutivo; set => num_consecutivo = value; }
        public byte[] Word_doc_creado { get => word_doc_creado; set => word_doc_creado = value; }
        public byte[] Pdf_doc_creado { get => pdf_doc_creado; set => pdf_doc_creado = value; }
        public string Estado_doc_creado { get => estado_doc_creado; set => estado_doc_creado = value; }
        public DateTime Fecha_doc_subido { get => fecha_doc_subido; set => fecha_doc_subido = value; }
        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
        public string Periodo { get => periodo; set => periodo = value; }
        public string Num_referencia_creado { get => num_referencia_creado; set => num_referencia_creado = value; }
        public int Habilitado { get => habilitado; set => habilitado = value; }
        public string ModificadoPor1 { get => ModificadoPor; set => ModificadoPor = value; }
        public string NombreRealWord1 { get => NombreRealWord; set => NombreRealWord = value; }
        public string NombreRealPdf1 { get => NombreRealPdf; set => NombreRealPdf = value; }

        public CrearDocumento(int opc, int total_doc_creado, string nom_doc_creado, string asunto_doc_creado,
          string detalle_doc_creado, int id_usuario, int id_proyecto, int num_consecutivo, byte[] word_doc_creado,
          byte[] pdf_doc_creado, string estado_doc_creado, DateTime fecha_doc_subido, int id_cliente, string periodo,
          string num_referencia_creado, int habilitado, string ModificadoPor, string nombreRealWord, string nombreRealPdf)
        {
            this.opc = opc;
            this.total_doc_creado = total_doc_creado;
            this.nom_doc_creado = nom_doc_creado;
            this.asunto_doc_creado = asunto_doc_creado;
            this.detalle_doc_creado = detalle_doc_creado;
            this.id_usuario = id_usuario;
            this.id_proyecto = id_proyecto;
            this.num_consecutivo = num_consecutivo;
            this.word_doc_creado = word_doc_creado;
            this.pdf_doc_creado = pdf_doc_creado;
            this.estado_doc_creado = estado_doc_creado;
            this.fecha_doc_subido = fecha_doc_subido;
            this.id_cliente = id_cliente;
            this.periodo = periodo;
            this.num_referencia_creado = num_referencia_creado;
            this.habilitado = habilitado;
            this.ModificadoPor = ModificadoPor;
            this.NombreRealWord = nombreRealWord;
            this.NombreRealPdf = nombreRealPdf;
        }
        public CrearDocumento()
        {
            this.opc = 0;
            this.total_doc_creado = 0;
            this.nom_doc_creado = "";
            this.asunto_doc_creado = "";
            this.detalle_doc_creado = "";
            this.id_usuario = 0;
            this.id_proyecto = 0;
            this.num_consecutivo = 0;
            this.word_doc_creado = null;
            this.pdf_doc_creado = null;
            this.estado_doc_creado = "";
            this.fecha_doc_subido = DateTime.Now;
            this.id_cliente = 0;
            this.periodo = "";
            this.num_referencia_creado = "";
            this.habilitado = 0;
            this.ModificadoPor = "";
            NombreRealWord = "";
            NombreRealPdf = "";
        }
    }
}
