using GraphQL.Types;

namespace VirtoCommerce.ProfileExperienceApiModule.Data.Schemas
{
    public class AddressTypeEnum : EnumerationGraphType
    {
        public AddressTypeEnum()
        {
            Name = "AddressTypeEnum";
            AddValue("Undefined", "Undefined", 0);
            AddValue("Billing", "Billing", 1);
            AddValue("Shipping", "Shipping", 2);
            AddValue("Pickup", "Pickup", 4);
            AddValue("BillingAndShipping", "BillingAndShipping", 3);
        }
    }
}
