
namespace LibMascotas
{
    public class Mascota
    {
        #region Atributos
        private string nombre;
        private string especie;
        private string dueño;
        #endregion

        #region Propiedades
        public string Nombre { get => nombre; set => nombre = value; }
        public string Especie { get => especie; set => especie = value; }
        public string Dueño { get => dueño; set => dueño = value; }
        #endregion

        #region Constructor
        public Mascota(string nombre, string especie, string dueño)
        {
            Nombre = nombre;
            Especie = especie;
            Dueño = dueño;
        }
        #endregion
    }
}
