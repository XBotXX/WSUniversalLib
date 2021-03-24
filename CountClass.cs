using System;

namespace WSUniversalLib
{
    public class CountClass
    {
        public static decimal? Method(int countProduct, double widthProduct, double LenghtProduct, int id_product_type, int id_material_type)
        {
            try
            {
                double? buff = widthProduct * LenghtProduct * product_type_res(id_product_type) * countProduct;
                return Math.Ceiling(Convert.ToDecimal(buff * material_type_res(buff, id_material_type)));
            }
            catch (Exception ex)
            {
                return -1;
            }
        }

        public static double? product_type_res(int id_product_type)
        {
            switch (id_product_type)
            {
                case 1:
                    return 1.1;
                case 2:
                    return 2.5;
                case 3:
                    return 8.43;
                default:
                    return null;
            }
        }

        public static double? material_type_res(double? res, int id_material_type)
        {
            switch (id_material_type)
            {
                case 1:
                    return res * 0.3 / 100;
                case 2:
                    return res * 0.12 / 100;
                default:
                    return null;
            }
        }
    }
}
