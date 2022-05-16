using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementacionClases.DTO
{
    public class DatoDTO
    {
        private int id;
        private float flujo;
        private float nivel;
        private float temperatura;
        private float voltaje;
        private BancoDTO banco;
        private CeldaDTO celda;

        private static List<DatoDTO> datos = new List<DatoDTO>()
        {
            new DatoDTO() { id = 1, flujo = 0, nivel = 0, temperatura = 0, voltaje = 0},
            new DatoDTO() { id = 2, flujo = 1.1f, nivel = 2.0f, temperatura = 4.3f, voltaje = 1.1f},
            new DatoDTO() { id = 3, flujo = 2.3f, nivel = 3.0f, temperatura = 3.1f, voltaje = 2.0f}
        }

        public int Id { get => id; set => id = value; }
        public float Flujo { get => flujo; set => flujo = value; }
        public float Nivel { get => nivel; set => nivel = value; }
        public float Temperatura { get => temperatura; set => temperatura = value; }
        public float Voltaje { get => voltaje; set => voltaje = value; }
        public float TemperaturaFarenheit { get => temperatura * (9 / 5) + 32; }
        public BancoDTO Banco { get => banco; set => banco = value; }
        public CeldaDTO Celda { get => celda; set => celda = value; }
        // (0 °C × 9/5) + 32 = 32 °F
        public BancoDTO Banco { get => banco; set => banco = value; }
        public CeldaDTO Celda { get => celda; set => celda = value; }

        //Métodos: 
        public static bool Add(DatoDTO datos)
        {
            try
            {
                datos.Add(nuevosDAtos);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static List<DatoDTO> List()
        {
            return datos;
        }

        public static int Find(int id)
        {
            for(int i=0; i<datos.Count; i++) // Recorrer lista a través de gor y su conteo
            {
                if(datos[i].id == id) //Verificar si el atributo id es igual al enviado
                {
                    return i; //en caso de encontrarse, se devuelve la posicion
                }
            }

            return -1; //si no se encuentra, pasa del for y devuelve -1
        }

        public static DatoDTO Find(DatoDTO dato)
        {
            for(int i=0; i< datos.Count; i++)
            {
                if(datos[i].id == dato.Id)
                {
                    return datos[i]; //en caso de encontrarse, devuelve el objeto de tipo DatoDTO
                }
            }

            return new DatoDTO(); // si no se encuentra, pasa del for y devuelve un objeto vacio
        }
            

        public static bool Remove(int id)
        {
            int idEncontrado = Find(id);
            if(idEncontrado >= 0) //si no se encuentra ID, devuelve -1
            {
                datos.RemoveAt(idEncontrado);
                return true;
            }
            else
            {
                return false; //no se encontró el id para eliminar
            }
        }
    }
}

