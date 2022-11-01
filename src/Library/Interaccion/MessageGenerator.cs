namespace Library
{
    public class MessageGenerator
    {
        public static string Login()
        {
            string message = 
            "Hola! Esto es un Chat de Bot automatizado.\n" +
            "Tengo una lista de cosas que puedo hacer. Por favor, envíame el número de la acción que desee:\n" +
            "1 - Registrarme\n" +
            "2 - Iniciar sesión\n" +
            "3 - Ingresar como Administrador";
            return message;
        }

        public static string Register()
        {
            string message =
            $"Usted seleccionó registrarse.\n" +
            "Necesito que me envíe la siguiente información en el formato que se muestra:\n" +
            "'Nickname, Nombre, Apellido'" +
            "El Nickname es el identificador de su cuenta y distingue mayúsculas y minúsculas. Recuérdelo para iniciar sesión.\n" + 
            "1 - Si desea cancelar el registro, ingrese 1.";
            return message;
        }

        public static string RegisterSuccess()
        {
            string message =
            "¡Bien!\n" +
            "Ahora, ¿desea registrarse como Empleador o como Trabajador?\n" +
            "1 - Registrarme como Trabajador.\n" +
            "2 - Registrarme como Empleador.";
            return message;
        }

        public static string RegisterEmployee()
        {
            string message =
            "Usted seleccionó registrarse como Trabajador.\n" +
            "Necesito que me ingrese su información de contacto en el siguiente formato:\n" +
            "'número telefónico, e-mail, calle, ciudad, departamento/estado, país, código postal'";
            return message;
        }

        public static string LobbyEmployee()
        {
            string message =
            "Usted ingresó como Trabajador\n" +
            "Por favor, envíeme el número de la acción que desee:\n" +
            "1 - Crear oferta.\n" +
            "2 - Calificar Empleador.\n" +
            "3 - Ver Reputación de empleador.\n";
            return message;
        }
    }
}