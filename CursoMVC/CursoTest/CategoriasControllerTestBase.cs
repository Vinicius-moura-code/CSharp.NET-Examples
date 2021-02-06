namespace CursoTest
{
    public class CategoriasControllerTestBase
    {
        private readonly Categoria _categoria;

        [Fact]

        public async Task Get_Categoria()
        {
            var service = new CategoriasController(_mockContext.Object);

            await service.GetCategoria(1);

            _mockSet.Verify(m => m.FindAsync(1),
                Times.Once());

        }
    }
}