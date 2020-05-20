using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Commands
{
    public class RemoveFromCartCommand : ICommand
    {

        private readonly IShoppingCartRepository shoppingCartRepository;
        private readonly IProductRepository productRepository;

        public RemoveFromCartCommand()
        {

        }
        public bool CanExecute()
        {
            if (product == null) return false;

            return shoppingCartRepository.Get(product.ArticleId).Quantity > 0;
        }

        public void Execute()
        {
            if (product == null) return;

            var lineItem = shoppingCartRepository.Get(product.ArticleId);
            productRepository.IncreaseStockBy(product.ArticleId, lineItem.Quantity);
            shoppingCartRepository.RemoveAll(product.ArticleId);
        }

        public void Undo()
        {

        }
    }
}
