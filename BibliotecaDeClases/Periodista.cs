using System;

namespace BibliotecaDeClases
{
    public class Periodista
    {
        private static int UltimoId { get; set; } = 1;
        public int Id { get; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public Periodista(string nombre, string apellido, string email, string password)
        {
            Id = UltimoId++;
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
            Password = password;
        }

        private void ValidarCampos()
        {
            bool nom = Nombre.Length != 0;
            bool ape = Apellido.Length != 0;
            bool email = Email.Length != 0;
            bool pass = Password.Length != 0;
            if (!nom || !ape || !email || !pass)
            {
                throw new Exception("Debe completar todos los campos.");
            }
        }

        private void ValidarEmail()
        {
            bool tieneArroba = false;
            bool arrobaValido = false;
            foreach (char letra in Email)
            {
                if (letra == '@')
                    tieneArroba = true;
            }
            if (tieneArroba)
            {
                int largoEmail = Email.Length;
                arrobaValido = (Email[0] != '@' || Email[largoEmail] != '@');
            }
            if (!arrobaValido || !tieneArroba)
            {
                throw new Exception("El email ingresado no es valido.");
            }
        }

        private void ValidarPass()
        {
            if (Password.Length < 8)
            {
                throw new Exception("El largo de la password es menor a 8.");
            }
        }

        public void EsValido()
        {
            try
            {
                ValidarCampos();
                ValidarEmail();
                ValidarPass();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public override string ToString()
        {
            return ($"{Nombre} fue dado de Alta correctamente!");
        }
    }

}
