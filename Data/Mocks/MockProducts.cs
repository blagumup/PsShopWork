using PlayStation_Shop.Data.Interfaces;
using PlayStation_Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayStation_Shop.Data.Mocks
{
    public class MockProducts : IAllProducts
    {
        private readonly IProductsCategory _productsCategory = new MockCategory();
        public IEnumerable<Product> Products
        {
            get
            {
                return new List<Product>
                {
                    new Product {
                        Name = "Sony Playstation PRO 1TB",
                        ShortDesc = "Sony Playstation PRO 1TB с двумя джойстиками + FIFA 19",
                        LongDesc = "Sony Playstation PRO 1TB с двумя джойстиками + FIFA 19",
                        Img = "/img/46918214_42860986.jpeg",
                        Price = 12749,
                        IsFavourite = true,
                        Available = true,
                        Category = _productsCategory.AllCategories.First()
                    },

                    new Product {
                        Name = "Sony Playstation 4 Slim Glacier White",
                        ShortDesc = "Sony Playstation 4 Slim Glacier White",
                        LongDesc = "Sony Playstation 4 Slim Glacier White",
                        Img = "/img/28671674_21989352.png",
                        Price = 6799,
                        IsFavourite = false,
                        Available = false,
                        Category = _productsCategory.AllCategories.First()
                    },

                    new Product {
                        Name = "Sony Playstation 4 Slim 1TB",
                        ShortDesc = "Sony Playstation 4 Slim 1TB",
                        LongDesc = "Sony Playstation 4 Slim 1TB",
                        Img = "/img/84179173_52294249.png",
                        Price = 8399,
                        IsFavourite = true,
                        Available = true,
                        Category = _productsCategory.AllCategories.First()
                    },

                    new Product {
                        Name = "Sony Playstation 4 Slim",
                        ShortDesc = "Sony Playstation 4 Slim",
                        LongDesc = "Sony Playstation 4 Slim",
                        Img = "/img/56489515_52026902.png",
                        Price = 7399,
                        IsFavourite = true,
                        Available = false,
                        Category = _productsCategory.AllCategories.First()
                    },

                    new Product {
                        Name = "Sony Playstation 4 Slim с двумя джойстиками",
                        ShortDesc = "Sony Playstation 4 Slim с двумя джойстиками",
                        LongDesc = "Sony Playstation 4 Slim с двумя джойстиками",
                        Img = "/img/34894975_1243034.png",
                        Price = 8599,
                        IsFavourite = false,
                        Available = true,
                        Category = _productsCategory.AllCategories.First()
                    },

                    new Product {
                        Name = "Sony Playstation 4 Slim 1TB с двумя джойстиками",
                        ShortDesc = "Sony Playstation 4 Slim 1TB с двумя джойстиками",
                        LongDesc = "Sony Playstation 4 Slim 1TB с двумя джойстиками",
                        Img = "/img/60765824_73917174.jpeg",
                        Price = 9699,
                        IsFavourite = true,
                        Available = true,
                        Category = _productsCategory.AllCategories.First()
                    },

                    new Product {
                        Name = "Джойстик Sony Dualshock 4 Red V2",
                        ShortDesc = "Новый контроллер Dualshock 4 V2 для PlayStation 4 от Sony создан для того, чтобы каждое действие с ним стало ещё лучше, точнее и удобнее.",
                        LongDesc = @"Каждая деталь в джойстике Dualshock 4 продумана до мелочей. Аналоговые стики и боковые кнопки стали ещё лучше, благодаря чему точность управления существенно повысилась. Помочь в этом также может встроенная сенсорная панель. На ней вы сможете увидеть цвет вашей световой панели, которая отображает важные события в игре и помогает PS Camera отслеживать положение беспроводного геймпада.
Внутри геймпада находятся чувствительный акселерометр и гироскоп. Они способны отслеживать каждый поворот, наклон и движение Dualshock 4.
Контроллер имеет встроенный динамик, который позволит услышать каждый, даже мельчайший звук. Также вы можете подключить свои наушники в 3,5 мм разъем, чтобы ещё больше погрузиться в игровой процесс.",
                        Img = "/img/6467713_24633753.jpeg",
                        Price = 1499,
                        IsFavourite = false,
                        Available = true,
                        Category = _productsCategory.AllCategories.ElementAt(2) //Проверить работу функции
                    },

                    new Product {
                        Name = "Джойстик Sony Dualshock 4 V2",
                        ShortDesc = "Новый контроллер Dualshock 4 V2 для PlayStation 4 от Sony создан для того, чтобы каждое действие с ним стало ещё лучше, точнее и удобнее.",
                        LongDesc = @"Каждая деталь в джойстике Dualshock 4 продумана до мелочей. Аналоговые стики и боковые кнопки стали ещё лучше, благодаря чему точность управления существенно повысилась. Помочь в этом также может встроенная сенсорная панель. На ней вы сможете увидеть цвет вашей световой панели, которая отображает важные события в игре и помогает PS Camera отслеживать положение беспроводного геймпада.
Внутри геймпада находятся чувствительный акселерометр и гироскоп. Они способны отслеживать каждый поворот, наклон и движение Dualshock 4.
Контроллер имеет встроенный динамик, который позволит услышать каждый, даже мельчайший звук. Также вы можете подключить свои наушники в 3,5 мм разъем, чтобы ещё больше погрузиться в игровой процесс.",
                        Img = "/img/48814818_15542392.png",
                        Price = 1449,
                        IsFavourite = true,
                        Available = true,
                        Category = _productsCategory.AllCategories.ElementAt(2) //Проверить работу функции
                    },

                    new Product {
                        Name = "Джойстик Sony Dualshock 4 Silver V2",
                        ShortDesc = "Новый контроллер Dualshock 4 V2 для PlayStation 4 от Sony создан для того, чтобы каждое действие с ним стало ещё лучше, точнее и удобнее.",
                        LongDesc = @"Каждая деталь в джойстике Dualshock 4 продумана до мелочей. Аналоговые стики и боковые кнопки стали ещё лучше, благодаря чему точность управления существенно повысилась. Помочь в этом также может встроенная сенсорная панель. На ней вы сможете увидеть цвет вашей световой панели, которая отображает важные события в игре и помогает PS Camera отслеживать положение беспроводного геймпада.
Внутри геймпада находятся чувствительный акселерометр и гироскоп. Они способны отслеживать каждый поворот, наклон и движение Dualshock 4.
Контроллер имеет встроенный динамик, который позволит услышать каждый, даже мельчайший звук. Также вы можете подключить свои наушники в 3,5 мм разъем, чтобы ещё больше погрузиться в игровой процесс.",
                        Img = "/img/69898438_87760759.jpeg",
                        Price = 1549,
                        IsFavourite = false,
                        Available = true,
                        Category = _productsCategory.AllCategories.ElementAt(2) //Проверить работу функции
                    },

                    new Product {
                        Name = "Зарядная станция для контроллера PS4",
                        ShortDesc = "Зарядная станция для контроллера PS4",
                        LongDesc = @"Dualshock 4 Charging Station – идеальный способ для одновременной зарядки и удобного хранения двух игровых контроллеров Dualshock 4. Корпус зарядной станции изготовлен из пластика черного цвета.
Станция имеет компактные размеры и стильный внешний вид, который отлично сочетается с дизайном консоли PS4. Информация о зарядке контроллеров отображается с помощью специальных LED индикаторов. Зарядная станция питается от собственного блока питания, что позволит оставить свободными USB порты консоли.
Используя Dualshock 4 Charging Station, вы никогда не попадете в ситуацию, когда придется отложить игру из-за разряженного контроллера. Геймпады всегда будут храниться на своих местах с готовностью в любой момент вступить в бой с полным зарядом батареи.",
                        Img = "/img/6378960.jpeg",
                        Price = 849,
                        IsFavourite = true,
                        Available = true,
                        Category = _productsCategory.AllCategories.ElementAt(2) //Проверить работу функции
                    },

                    new Product {
                        Name = "Камера PlayStation Camera (PS4)",
                        ShortDesc = "Камера PlayStation Camera (PS4)",
                        LongDesc = @"Ваша игра в эфире
Станьте звездой сообщества благодаря потоковой передаче видео игрового процесса с поддержкой функции «Картинка в картинке».

Записывайте прохождения игр
Хотите показать миру, как это делается? Создавайте видеоролики в высоком разрешении о ваших прохождениях любимых игр.

Общайтесь с друзьями
Используйте PlayStation Camera и входящую в комплект монофоническую гарнитуру, чтобы разговаривать с друзьями.",
                        Img = "/img/67298913_26603749.jpeg",
                        Price = 1699,
                        IsFavourite = true,
                        Available = true,
                        Category = _productsCategory.AllCategories.ElementAt(2) //Проверить работу функции
                    },

                    new Product {
                        Name = "Вертикальная подставка для PS4 slim/Pro",
                        ShortDesc = "Вертикальная подставка для PS4 slim/Pro",
                        LongDesc = "Установите PS4 так, как удобно вам, освободив место рядом с телевизором.",
                        Img = "/img/50860368_79746576.jpeg",
                        Price = 649,
                        IsFavourite = true,
                        Available = true,
                        Category = _productsCategory.AllCategories.ElementAt(2) //Проверить работу функции
                    },


                    new Product {
                        Name = "Sekiro: Shadows Die Twice",
                        ShortDesc = "Проложите свой собственный умный путь к мести в совершенно новом приключении от разработчика FromSoftware, создателей Bloodborne и серии Dark Souls.",
                        LongDesc = "В Sekiro: Shadows Die Twice вы - «однорукий волк», опальный и изуродованный воин, спасенный на грани смерти. Стремясь защитить молодого хозяина, который является потомком древней родословной, вы становитесь целью многих злобных врагов, включая опасный клан Ашина. Когда молодой хозяин будет захвачен, ничто не остановит вас в опасном стремлении вернуть себе честь, даже сама смерть.",
                        Img = "/img/46298402_41674497.jpeg",
                        Price = 1549,
                        IsFavourite = true,
                        Available = true,
                        Category = _productsCategory.AllCategories.Last()
                    },

                    new Product {
                        Name = "Days Gone",
                        ShortDesc = "Days Gone",
                        LongDesc = "Вам предстоит играть в сеттинге мира после зомби апокалипсиса. Главный герой Дикон Сент-Джонс, в прошлом участник байкерского клуба. Во время происшествия которое привело к глобальной трагедии протагонист теряет жену, а его лучший друг Бухарь попадает в неприятности, из которых вам предстоит его вытащить. У вас в распоряжении ваш мотоцикл, который является главным и единственным средством передвижения по огромному открытому миру. Байк можно улучшать и кастомизировать, его необходимо постоянно обеспечивать бензином, если вы не хотите остаться посреди пустоши, окруженным толпой фрикеров (местный аналог зомби), а моментов с толпами врагов в игре предостаточно.",
                        Img = "/img/17996667_62194147.jpeg",
                        Price = 899,
                        IsFavourite = true,
                        Available = true,
                        Category = _productsCategory.AllCategories.Last()
                    },

                    new Product {
                        Name = "Metro Exodus",
                        ShortDesc = "Metro Exodus",
                        LongDesc = @"Metro Exodus – это эффектный шутер с захватывающим сюжетом. 4A Games совместили напряженные сражения, исследования и пугающую атмосферу, создав один из самых убедительных игровых миров.

Оставьте позади руины метро и странствуйте по разрушенной России. Вас ждут нелинейные уровни, открытый мир и захватывающий сюжет по мотивам романов Дмитрия Глуховского. Испытайте на себе весну, лето, осень и ужасы ядерной зимы.",
                        Img = "/img/85889075_6848333.jpeg",
                        Price = 1199,
                        IsFavourite = false,
                        Available = true,
                        Category = _productsCategory.AllCategories.Last()
                    },
                };
            }
        }
        public IEnumerable<Product> GetFavProducts { get; set; }

        public Product GetObjectProduct(Guid productId)
        {
            throw new NotImplementedException();
        }
    }
}
