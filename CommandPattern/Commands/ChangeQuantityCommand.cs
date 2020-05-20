using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Commands
{
    public class ChangeQuantityCommand : ICommand
    {
        public enum Operation
        {
            Increase,
            Decrease
        }

        private readonly Operation operation;
        private readonly IShoppingCartRepository shoppingCartRepository;
        private readonly IProductRepository productRepository;
        private readonly Product product;

        public ChangeQuantityCommand(Operation operation, IShoppingCartRepository shoppingCartRepository, IProductRepository productRepository, Product product)
        {
            this.operation = operation;
            this.shoppingCartRepository = shoppingCartRepository;
            this.productRepository = productRepository;
            this.product = product;
        }

        public void Execute()
        {
            switch (operation)
            {
                case Operation.Increase:
                    productRepository.DecreaseStockBy(product.ArticleId, 1);
                    shoppingCartRepository.IncreaseQuantity(product.ArticleId);
                    break;
                case Operation.Decrease:
                    productRepository.IncreaseStockBy(product.ArticleId, 1);
                    shoppingCartRepository.DecreaseQuantity(product.ArticleId);
                    break;
                default:
                    break;
            }
        }

        public bool CanExecute()
        {
            switch (operation)
            {
                case Operation.Increase:
                    return (productRepository.GetStockFor(product.ArticleId) - 1) >= 0;
                    break;
                case Operation.Decrease:
                    return shoppingCartRepository.Get(product.ArticleId).Quantity != 0;
                    break;
                default:
                    break;
            }

            return false;
        }

        public void Undo()
        {
            switch (operation)
            {
                case Operation.Increase:
                    productRepository.IncreaseStockBy(product.ArticleId, 1);
                    shoppingCartRepository.DecreaseQuantity(product.ArticleId);
                    break;
                case Operation.Decrease:
                    productRepository.DecreaseStockBy(product.ArticleId, 1);
                    shoppingCartRepository.IncreaseQuantity(product.ArticleId);
                    break;
                default:
                    break;
            }
        }

    }
}
