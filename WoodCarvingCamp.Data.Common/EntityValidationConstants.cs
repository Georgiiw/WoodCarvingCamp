namespace WoodCarvingCamp.Data.Common
{
    public static class EntityValidationConstants
    {
        public static class ProductValidations
        {
            public const int NameMinLength = 2;
            public const int NameMaxLength = 100;
            public const int DescriptionMinLength = 20;
            public const int DescriptionMaxLength = 500;
            public const int ImageUrlMaxLength = 2048;

        }
        public static class DiscountValidations
        {
            public const int NameMinLength = 10;
            public const int NameMaxLength = 120;
            public const int DescriptionMinLength = 20;
            public const int DescriptionMaxLength = 500;
        }
        public static class CommentValidations
        {
            public const int DescriptionMinLength = 2;
            public const int DescriptionMaxLength = 100;
        }
        public static class GalleryPhotoValidations
        {
            public const int TitleMinLength = 2;
            public const int TitleMaxLength = 40;
            public const int DescriptionMinLength = 10;
            public const int DescriptionMaxLength = 150;
            public const int ImageUrlMaxLength = 2048;
        }
        public static class CarvingCourseValidations
        {
            public const int NameMinLength = 10;
            public const int NameMaxLength = 100;
            public const int DescriptionMinLength = 50;
            public const int DescriptionMaxLength = 500;
            public const int ImageUrlMaxLength = 2048;
        }
        public static class CategoryValidations
        {
            public const int NameMinLength = 2;
            public const int NameMaxLength = 30;
        }
        public static class UserValidations
        {
            public const int FirstNameMinLength = 2;
            public const int FirstNameMaxLength = 20;  
            
            public const int LastNameMinLength = 2;     
            public const int LastNameMaxLength = 20;     
            
            public const int PasswordMinLength = 6;
            public const int PasswordMaxLength = 100;

        }
        public static class OrderValidations
        {
            public const int PaymentStatusMaxLength = 50;
            public const int OrderStatusMaxLength = 50;
            public const int TransactionIdMaxLength = 50;
        }
    }
}