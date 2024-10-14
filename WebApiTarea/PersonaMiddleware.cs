namespace WebApiTarea
{
    public class PersonaMiddleware
    {
        public static bool esAdulto(DateTime fechaNacimiento)
        {
            var hoy = DateTime.Today;
            var edad = hoy.Year - fechaNacimiento.Year;

            if (fechaNacimiento.Date > hoy.AddYears(-edad))
            {
                edad--;
            }
            return edad >= 18;
        }
    }
}
