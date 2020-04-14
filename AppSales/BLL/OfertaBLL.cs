using AppSales.DAL;
using AppSales.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSales.BLL
{
    public class OfertaBLL
    {
        public OfertaBLL()
        { }

        public static Oferta rowToDto(OfertaDS.OfertasRow row)
        {
            Oferta objOferta = new Oferta();

            objOferta.id_Ofertas = row.pkOferta;
            objOferta.nombre = row.txtNombre;
            objOferta.fechaInicio = row.dateFechaInicio;
            objOferta.fechaFin = row.dateFechafin;
            objOferta.descripcion = row.txtDescripcion;

            return objOferta;
        }
        public static List<Oferta> SelectAll()
        {
            List<Oferta> listadeOfertas = new List<Oferta>();
            AppSales.DAL.OfertaDSTableAdapters.OfertasTableAdapter objDataSet = new AppSales.DAL.OfertaDSTableAdapters.OfertasTableAdapter();
            OfertaDS.OfertasDataTable dtOferta = objDataSet.GetAllOffers();

            foreach (OfertaDS.OfertasRow row in dtOferta)
            {
                Oferta objOferta = rowToDto(row);
                listadeOfertas.Add(objOferta);
            }
            return listadeOfertas;
        }
        public static int InsertObjetoOferta(Oferta objOferta)
        {
            return InsertDatosOferta(objOferta.nombre, objOferta.fechaInicio, objOferta.fechaFin, objOferta.descripcion, objOferta.intIdUsuarioCreacion);
        }


        public static int InsertDatosOferta(string nombre, DateTime fechaIni, DateTime fechaFin, string desc, int usuarioCreacion)
        {

            AppSales.DAL.OfertaDSTableAdapters.OfertasTableAdapter objDataSet = new AppSales.DAL.OfertaDSTableAdapters.OfertasTableAdapter();
            int? OfertaId = 0;
            objDataSet.InsertOffers(ref OfertaId, nombre, fechaIni, fechaFin, desc, usuarioCreacion);

            return (int)OfertaId;
        }

        public static Oferta GetOfertaById(int pk)
        {
            AppSales.DAL.OfertaDSTableAdapters.OfertasTableAdapter objDataSet = new AppSales.DAL.OfertaDSTableAdapters.OfertasTableAdapter();
            OfertaDS.OfertasDataTable dtOferta = objDataSet.GetOfferByID(pk);
            Oferta objOferta = rowToDto(dtOferta[0]);

            return objOferta;
        }
        public static void UpdateOferta(Oferta objOferta)
        {
            UpdateOferta(objOferta.id_Ofertas, objOferta.nombre, objOferta.fechaInicio, objOferta.fechaFin, objOferta.descripcion, objOferta.intIdUsuarioModificacion);
        }

        public static void UpdateOferta(int? pk, string nombre, DateTime fechaIni, DateTime fechaFin, string desc, int usuarioModificacion)
        {
            AppSales.DAL.OfertaDSTableAdapters.OfertasTableAdapter objDataSet = new AppSales.DAL.OfertaDSTableAdapters.OfertasTableAdapter();

            objDataSet.UpdateOffers(pk, nombre, fechaIni, fechaFin, desc, usuarioModificacion);
        }
        public static void DeleteOferta(int id)
        {
            AppSales.DAL.OfertaDSTableAdapters.OfertasTableAdapter objDataSet = new AppSales.DAL.OfertaDSTableAdapters.OfertasTableAdapter();
            objDataSet.DeleteOffers(id);
        }
    }
}
