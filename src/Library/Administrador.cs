namespace Library
{
    public class Administrador : User
    {
        private Administrador(string nickname)
        : base(nickname)
        {

        }

        private void AddCategory(string categoryName)
        {
            /*Cómo administrador, quiero poder indicar categorías sobre
            las cuales se realizarán las ofertas de servicios para que
            de esa forma, pueda clasificarlos.*/
        }
        private void RemoveCategory(string categoryName)
        {
            /*Cómo administrador, quiero poder indicar categorías sobre
            las cuales se realizarán las ofertas de servicios para que
            de esa forma, pueda clasificarlos.*/
        }
        private void CancelOffer(string descripcion, int offerID)
        {
            /*Como administrador, quiero poder dar de baja ofertas de
            servicios, avisando al oferente para que de esa forma, pueda
            evitar ofertas inadecudas.*/
        }
        private GenericList<Offer> GetOfferByCategory(Category category)
        {
            /*quiero buscar ofertas de trabajo, opcionalmente filtrando
            por categoría para que de esa forma, pueda contratar un servicio.*/
        }
    }
}