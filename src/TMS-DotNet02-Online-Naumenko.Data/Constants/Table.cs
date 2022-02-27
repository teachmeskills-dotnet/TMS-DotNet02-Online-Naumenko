using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_DotNet02_Online_Naumenko.Data.Constants
{
    public static class Table
    {
        /// <summary>
        /// Profiles.
        /// </summary>
        public const string Users = nameof(Users);

        /// <summary>
        /// DeliveryAddresses.
        /// </summary>
        public const string UserRoles = nameof(UserRoles);

        /// <summary>
        /// Orders.
        /// </summary>
        public const string Files = nameof(Files);

        /// <summary>
        /// OrderProducts.
        /// </summary>
        public const string FileExtensions = nameof(FileExtensions);

        /// <summary>
        /// Products.
        /// </summary>
        public const string FileTerms = nameof(FileTerms);

        /// <summary>
        /// ProductDetails.
        /// </summary>
        public const string Options = nameof(Options);

        /// <summary>
        /// ProductIngredients.
        /// </summary>
        public const string Posts = nameof(Posts);

        /// <summary>
        /// Ingredients.
        /// </summary>
        public const string PostTerms = nameof(PostTerms);

        /// <summary>
        /// Promo codes.
        /// </summary>
        public const string Terms = nameof(Terms);
    }
}
