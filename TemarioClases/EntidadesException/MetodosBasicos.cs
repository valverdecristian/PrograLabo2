namespace EntidadesException
{
    public class MetodosBasicos
    {
        public static void Metodo1() { Metodo2(); }

        public static void Metodo2() { Metodo3(); }

        public static void Metodo3()
        {
            try // codigo que puede llegar a romper, si no rompe, no entra al catch
            {
                int valor = 0;
                int resultado = 5 / valor;
            }
            catch (DivideByZeroException ex)
            {
                // Console.WriteLine("ocurrio una division por cero");
                throw new MiException(ex.Message, ex);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("estoy fuera de rango");
            }
            finally // bloque que se va a ejecutar SIEMPRE.
            {
                // bloque para cerrar archivos
                Console.WriteLine("Estoy en el bloque finally");
            }

            Console.WriteLine("********************************");
            Console.WriteLine("Estoy fuera del bloque Try-Catch");

            // throw: vuelve a lanzar la excepcion [no estaria controlandola] hasta donde yo quiera controlarla
        }
    }
}