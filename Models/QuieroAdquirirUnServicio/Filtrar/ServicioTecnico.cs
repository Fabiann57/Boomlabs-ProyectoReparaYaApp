using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace REPARA_YA_APP.Models {

    //a cada clase se le asigno una base de datos y su respectiva libreria
    public class ServicioTecnico : QuieroAdquirirUnServicio 
    {
        [key, DatabaseGenerated(DatabaseGeneratedOption.None)]

        public string ID { get; set; } = Guid.NewGuid().ToString();

        //propiedades de la clase usuario
        public string Nombre { get; set; }
        public string Ciudad { get; set; }
        public string Direccion { get; set; }
        public string Pais { get; set; }
    }

}