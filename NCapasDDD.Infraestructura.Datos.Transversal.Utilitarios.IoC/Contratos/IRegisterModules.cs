namespace NCapasDDD.Infraestructura.Datos.Transversal.Utilitarios.IoC
{
    public interface IRegisterModules
    {
        void RegisterType<TFrom, TTo>(bool withIterception = false) where TTo : TFrom;
        void RegisterTypeWithLifeTime<TFrom, TTo>(bool withIterception = false) where TTo : TFrom;
    }
}
