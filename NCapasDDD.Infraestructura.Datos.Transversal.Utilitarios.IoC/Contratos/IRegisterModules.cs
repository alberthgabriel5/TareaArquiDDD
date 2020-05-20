namespace NCapasDDD.Infraestructura.Datos.Transversal.Utilitarios.IoC
{
    public interface IRegisterModules
    {
        void RegisterTyper<TFrom, TTo>(bool withIterception = false) where TTo : TFrom;
        void RegisterTypeWithLifeTime<TFrom, TTo>(bool withIterception = false) where TTo : TFrom;
    }
}
