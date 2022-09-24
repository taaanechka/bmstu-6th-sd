using DB;
using BL;

namespace TechnologicalUI
{
    class StartUp
    {
        private Presenter _presenter;

        private Permissions AccessPermissions = Permissions.UNAUTHORIZED;

        public StartUp(BL.Facade facade, BL.User user)
        {
            _presenter = new Presenter(facade, (int) user.UserType);
            AccessPermissions = user.UserType;
        }

        public void Run()
        {
            switch ((int) AccessPermissions)
            {
                case 1:
                    EmployeeFunctionality();
                    break;
                case 2:
                    AnalystFunctionality();
                    break;
                case 3:
                    AdminFunctionality();
                    break;
                default:
                    Console.WriteLine("Выход из приложения выполнен\n");
                    break;
            }            
        }

        void EmployeeFunctionality()
        {
            int choice = 0;

            while (choice != 3)
            {
                Console.WriteLine("\nВыберете действие:\n1. Посмотреть приходы\n2. Посмотреть уходы\n3. Выход\n");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        try
                        {
                            Console.WriteLine("Введите offset:");
                            int offset = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите limit:");
                            int limit = Convert.ToInt32(Console.ReadLine());
                            GetComings(offset, limit);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Пределы введены неверно\n");
                        }
                        break;
                    case 2:
                        try
                        {
                            Console.WriteLine("Введите offset:");
                            int offset = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите limit:");
                            int limit = Convert.ToInt32(Console.ReadLine());
                            GetDepartures(offset, limit);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Пределы введены неверно\n");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Выход\n");
                        break;
                    default:
                        Console.WriteLine("Введен неверный пункт меню\n");
                        break;
                }
            }
        }

        void AnalystFunctionality()
        {
            int choice = 0;

            while (choice != 5)
            {
                Console.WriteLine("\nВыберете действие:\n1. Посмотреть приходы\n2. Посмотреть уходы\n" + 
                    "3. Получить приходы по дате \n4. Получить уходы по дате\n5. Выход\n");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        try
                        {
                            Console.WriteLine("Введите offset:");
                            int offset = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите limit:");
                            int limit = Convert.ToInt32(Console.ReadLine());
                            GetComings(offset, limit);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Пределы введены неверно\n");
                        }
                        break;
                    case 2:
                        try
                        {
                            Console.WriteLine("Введите offset:");
                            int offset = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите limit:");
                            int limit = Convert.ToInt32(Console.ReadLine());
                            GetDepartures(offset, limit);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Пределы введены неверно\n");
                        }
                        break;
                    case 3:
                        try
                        {
                            Console.WriteLine("Введите offset:");
                            int offset = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите limit:");
                            int limit = Convert.ToInt32(Console.ReadLine());
                            GetComings(offset, limit);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Пределы введены неверно\n");
                        }
                        break;
                    case 4:
                        try
                        {
                            Console.WriteLine("Введите offset:");
                            int offset = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите limit:");
                            int limit = Convert.ToInt32(Console.ReadLine());
                            GetDepartures(offset, limit);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Пределы введены неверно\n");
                        }
                        break;
                    case 5:
                        Console.WriteLine("Выход\n");
                        break;
                    default:
                        Console.WriteLine("Введен неверный пункт меню\n");
                        break;
                }
            }
        }

        void AdminFunctionality()
        {
            int choice = 0;

            while (choice != 10)
            {
                Console.WriteLine("\nВыберете действие:\n" + 
                    "1. Посмотреть приходы\n2. Посмотреть уходы\n3. Посмотреть пользователей\n" +
                    "4. Посмотреть автомобили\n5. Посмотреть цвета\n6. Посмотреть модели автомобилей\n" +
                    "7. Посмотреть марки автомобилей\n8. Посмотреть всех владельцев автомобилей\n" +
                    "9. Посмотреть VIP владельцев автомобилей (id владельцев)\n10. Выход\n");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        try
                        {
                            Console.WriteLine("Введите offset:");
                            int offset = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите limit:");
                            int limit = Convert.ToInt32(Console.ReadLine());
                            GetComings(offset, limit);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Пределы введены неверно\n");
                        }
                        break;
                    case 2:
                        try
                        {
                            Console.WriteLine("Введите offset:");
                            int offset = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите limit:");
                            int limit = Convert.ToInt32(Console.ReadLine());
                            GetDepartures(offset, limit);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Пределы введены неверно\n");
                        }
                        break;
                    case 3:
                        try
                        {
                            Console.WriteLine("Введите offset:");
                            int offset = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите limit:");
                            int limit = Convert.ToInt32(Console.ReadLine());
                            GetUsers(offset, limit);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Пределы введены неверно\n");
                        }
                        break;
                    case 4:
                        try
                        {
                            Console.WriteLine("Введите offset:");
                            int offset = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите limit:");
                            int limit = Convert.ToInt32(Console.ReadLine());
                            GetCars(offset, limit);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Пределы введены неверно\n");
                        }
                        break;
                    case 5:
                        try
                        {
                            Console.WriteLine("Введите offset:");
                            int offset = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите limit:");
                            int limit = Convert.ToInt32(Console.ReadLine());
                            GetColors(offset, limit);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Пределы введены неверно\n");
                        }
                        break;
                    case 6:
                        try
                        {
                            Console.WriteLine("Введите offset:");
                            int offset = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите limit:");
                            int limit = Convert.ToInt32(Console.ReadLine());
                            GetModels(offset, limit);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Пределы введены неверно\n");
                        }
                        break;
                    case 7:
                        try
                        {
                            Console.WriteLine("Введите offset:");
                            int offset = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите limit:");
                            int limit = Convert.ToInt32(Console.ReadLine());
                            GetBrands(offset, limit);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Пределы введены неверно\n");
                        }
                        break;
                    case 8:
                        try
                        {
                            Console.WriteLine("Введите offset:");
                            int offset = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите limit:");
                            int limit = Convert.ToInt32(Console.ReadLine());
                            GetCarOwners(offset, limit);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Пределы введены неверно\n");
                        }
                        break;
                    case 9:
                        try
                        {
                            Console.WriteLine("Введите offset:");
                            int offset = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите limit:");
                            int limit = Convert.ToInt32(Console.ReadLine());
                            GetVIPCarOwners(offset, limit);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Пределы введены неверно\n");
                        }
                        break;
                    case 10:
                        Console.WriteLine("Выход\n");
                        break;
                    default:
                        Console.WriteLine("Введен неверный пункт меню\n");
                        break;
                }
            }
        }

        // !!EmployeeFunctionality
        void GetComings(int offset = 0, int limit = -1)
        {
            List<BL.Coming> res = _presenter.GetComings(offset, limit);

            if (res != null)
            {
                Console.WriteLine("Результат:");
                foreach(var coming in res)
                {
                    Console.WriteLine(
                        Convert.ToString(coming.Id) + " " +
                        Convert.ToString(coming.UserId) + " " +
                        Convert.ToString(coming.ComingDate));
                }
            }
            else
            {
                Console.WriteLine("Приходы не найдены");
            }
        }

        void GetDepartures(int offset = 0, int limit = -1)
        {
            List<BL.Departure> res = _presenter.GetDepartures(offset, limit);

            if (res != null)
            {
                Console.WriteLine("Результат:");
                foreach(var departure in res)
                {
                    Console.WriteLine(
                        Convert.ToString(departure.Id) + " " +
                        Convert.ToString(departure.UserId) + " " +
                        Convert.ToString(departure.DepartureDate));
                }
            }
            else
            {
                Console.WriteLine("Уходы не найдены");
            }
        }


        // !!AnalystFunctionality
        void GetComingsByDate(string datep)
        {
            DateTime Date1 = DateTime.ParseExact(datep, "yyyy-MM-dd",
                                    System.Globalization.CultureInfo.InvariantCulture);
            List<BL.Coming> res = _presenter.GetComingsByDate(Date1);

            if (res != null)
            {
                Console.WriteLine("Результат:");
                foreach(var coming in res)
                {
                    Console.WriteLine(
                        Convert.ToString(coming.Id) + " " +
                        Convert.ToString(coming.UserId) + " " +
                        Convert.ToString(coming.ComingDate));
                }
            }
            else
            {
                Console.WriteLine("Приходы не найдены");
            }
        }

        void GetDeparturesByDate(string datep)
        {
            DateTime Date1 = DateTime.ParseExact(datep, "yyyy-MM-dd",
                                    System.Globalization.CultureInfo.InvariantCulture);
            List<BL.Departure> res = _presenter.GetDeparturesByDate(Date1);

            if (res != null)
            {
                Console.WriteLine("Результат:");
                foreach(var departure in res)
                {
                    Console.WriteLine(
                        Convert.ToString(departure.Id) + " " +
                        Convert.ToString(departure.UserId) + " " +
                        Convert.ToString(departure.DepartureDate));
                }
            }
            else
            {
                Console.WriteLine("Уходы не найдены");
            }
        }

        // !!AdminFunctionality
        void GetUsers(int offset = 0, int limit = -1)
        {
            List<BL.User> res = _presenter.GetUsers(offset, limit);

            if (res != null)
            {
                Console.WriteLine("Результат:");
                foreach(var user in res)
                {
                    Console.WriteLine(
                        Convert.ToString(user.Id) + " " +
                        Convert.ToString(user.Name) + " " +
                        Convert.ToString(user.Surname) + " " +
                        Convert.ToString(user.Login) + " " +
                        Convert.ToString(user.Password) + " " +
                        Convert.ToString(user.UserType));
                }
            }
            else
            {
                Console.WriteLine("Пользователи не найдены");
            }
        }

        void GetCars(int offset = 0, int limit = -1)
        {
            List<BL.Car> res = _presenter.GetCars(offset, limit);

            if (res != null)
            {
                Console.WriteLine("Результат:");
                foreach(var user in res)
                {
                    Console.WriteLine(
                        Convert.ToString(user.Id) + " " +
                        Convert.ToString(user.ModelId) + " " +
                        Convert.ToString(user.EquipmentId) + " " +
                        Convert.ToString(user.ColorId) + " " +
                        Convert.ToString(user.ComingId));
                }
            }
            else
            {
                Console.WriteLine("Пользователи не найдены");
            }
        }

        void GetColors(int offset = 0, int limit = -1)
        {
            List<BL.Color> res = _presenter.GetColors(offset, limit);

            if (res != null)
            {
                Console.WriteLine("Результат:");
                foreach(var color in res)
                {
                    Console.WriteLine(
                        Convert.ToString(color.Id) + " " +
                        Convert.ToString(color.Name));
                }
            }
            else
            {
                Console.WriteLine("Цвета не найдены");
            }
        }

        void GetModels(int offset = 0, int limit = -1)
        {
            List<BL.Model> res = _presenter.GetModels(offset, limit);

            if (res != null)
            {
                Console.WriteLine("Результат:");
                foreach(var model in res)
                {
                    Console.WriteLine(
                        Convert.ToString(model.Id) + " " +
                        Convert.ToString(model.BrandId) + " " +
                        Convert.ToString(model.Name));
                }
            }
            else
            {
                Console.WriteLine("Модели автомобилей не найдены");
            }
        }

        void GetBrands(int offset = 0, int limit = -1)
        {
            List<BL.Brand> res = _presenter.GetBrands(offset, limit);

            if (res != null)
            {
                Console.WriteLine("Результат:");
                foreach(var brand in res)
                {
                    Console.WriteLine(
                        Convert.ToString(brand.Id) + " " +
                        Convert.ToString(brand.Name) + " " +
                        Convert.ToString(brand.ManufactCountry) + " " +
                        Convert.ToString(brand.Wheel));
                }
            }
            else
            {
                Console.WriteLine("Марки не найдены");
            }
        }

        void GetCarOwners(int offset = 0, int limit = -1)
        {
            List<BL.CarOwner> res = _presenter.GetCarOwners(offset, limit);

            if (res != null)
            {
                Console.WriteLine("Результат:");
                foreach(var owner in res)
                {
                    Console.WriteLine(
                        Convert.ToString(owner.Id) + " " +
                        Convert.ToString(owner.Name) + " " +
                        Convert.ToString(owner.Surname) + " " +
                        Convert.ToString(owner.Email));
                }
            }
            else
            {
                Console.WriteLine("Владельцы автомобилей не найдены");
            }
        }

        void GetVIPCarOwners(int offset = 0, int limit = -1)
        {
            List<BL.VIPCarOwner> res = _presenter.GetVIPCarOwners(offset, limit);

            if (res != null)
            {
                Console.WriteLine("Результат:");
                foreach(var owner in res)
                {
                    Console.WriteLine(
                        Convert.ToString(owner.Id) + " " +
                        Convert.ToString(owner.CarOwnerId));
                }
            }
            else
            {
                Console.WriteLine("VIP Владельцы автомобилей не найдены");
            }
        }
    }
}