using System.Collections.ObjectModel;

namespace TestTaskTwo.Models
{
    public class PizzaModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Image { get; set; }
        public string? Ingredients { get; set; }
        public string? Price { get; set; }
    }
    public class PizzaRepository
    {
        public readonly List<PizzaModel> pizzas = new List<PizzaModel>() {
            new PizzaModel {
                Id = 1,
                Name = "Мама мия",
                Ingredients = "Соус 'Томатный', Сыр моцарелла, Фарш говяжий, Куриная грудка, " +
             "Бекон, Лук фри, Пепперони, Соус сырный 'Пармеджано', Халапеньо, Соус 'Медово-горчичный'",
                Price = "590",
                Image = "mama_miya.jpg"
            },

            new PizzaModel {
                Id = 2,
                Name = "Новогодняя",
                Ingredients = "Соус Гавайский, Сыр моцарелла, Куриная грудка, Мандарины консервированные," +
             " Стружка миндаля, Кокосовая стружка",
                Price = "560",
                Image = "novogodnyaya_1.jpg"
            },
             new PizzaModel {
                Id = 3,    
                Name = "Пестория",
                Ingredients = "Соус 'Сливочный', Томаты черри, Сыр моцарелла, Сыр фетаки, " +
                 "Куриная грудка, Соус сырный 'Пармеджано', Соус 'Песто'",
                Price = "570",
                Image = "pestoriya.jpg"
            },
            new PizzaModel {
                Id = 4,
                Name = "Том ям",
                Ingredients = "Соус 'Том ям', Томаты свежие, Шампиньоны, Сыр моцарелла, Лук маринованный, Мидии, Кальмар, Осьминог, Лайм",
                Price = "650",
                Image = "tom_yam.jpg"
            },
            new PizzaModel {
                Id = 5,
                Name = "Capriccio",
                Ingredients = "Сыр моцарелла, Соус 'Барбекю', Соус 'Кальяри', Пепперони, Овощи гриль, Бекон, Ветчина, Томаты черри, Шампиньоны",
                Price = "750",
                Image = "capriccio_1.jpg"
            },
            new PizzaModel {
                Id = 6,
                Name = "XXXL",
                Ingredients = "Сыр моцарелла, Соус '1000 островов', Куриный рулет, Ветчина," +
                " Колбаски охотничьи, Бекон, Сервелат, Огурцы маринованные, Томаты черри, Маслины, Лук маринованный",
                Price = "890",
                Image = "xxxl_1.jpg"
            },
            new PizzaModel {
                Id = 7,
                Name = "4 вкуса",
                Ingredients = "Соус '1000 островов', Сыр моцарелла, Рулет куриный, Ветчина, Пепперони," +
                " Сыр пармезан, Шампиньоны, Томаты свежие, Маслины/оливки",
                Price = "540",
                Image = "4_vkusa_1.jpg"
            },
            new PizzaModel {
                Id = 8,
                Name = "Амазонка",
                Ingredients = "Соус 'Томатный', Сыр моцарелла, Куриная грудка, Брокколи," +
                " Огурцы маринованные, Перец болгарский, Шампиньоны, Томаты черри, Маслины, Лук маринованный",
                Price = "560",
                Image = "amazonka_1.jpg"
            },
            new PizzaModel {
                Id = 9,
                Name = "Барбекю",
                Ingredients = "Соус 'Томатный', Сыр моцарелла, Ветчина, Бекон, Пепперони, Соус 'Барбекю', Томаты, Перец болгарский, Лук маринованный",
                Price = "540",
                Image = "barbeq_1.jpg"
            },
            new PizzaModel {
                Id = 10,
                Name = "Гавайская",
                Ingredients = "Ветчина, Соус 'Гавайский', Сыр моцарелла, Ананас, Перец болгарский",
                Price = "580",
                Image = "hawai_1.jpg"
            },
            new PizzaModel {
                Id = 11,
                Name = "Гавайская Premium",
                Ingredients = "Соус 'Гавайский', Сыр моцарелла, Ананас, Ветчина, Куриный рулет, Кукуруза, Перец болгарский",
                Price = "540",
                Image = "hawai_premium_1.jpg"
            },
            new PizzaModel {
                Id = 12,
                Name = "Греческая",
                Ingredients = "Соус 'Кальяри', Сыр моцарелла, Сливочный сыр, Брокколи, Томаты черри, Перец болгарский, Маслины",
                Price = "570",
                Image = "grek_1.jpg"
            },
            new PizzaModel {
                Id = 13,
                Name = "Грибная",
                Ingredients = "Соус 'Грибной', Сыр моцарелла, Опята маринованные, Укроп, Шампиньоны, Лук маринованный",
                Price = "540",
                Image = "gribnaya_1.jpg"
            },
            new PizzaModel {
                Id = 14,
                Name = "Деревенская",
                Ingredients = "Соус '1000 островов', Сыр моцарелла, Ветчина, Сервелат," +
                " Огурцы маринованные, Опята маринованные, Укроп, Лук маринованный",
                Price = "550",
                Image = "derevenskaya_1.jpg"
            },
            new PizzaModel {
                Id = 15,
                Name = "Дьябло",
                Ingredients = "Соус 'Томатный', Сыр моцарелла, Ветчина, Пепперони, Соус 'Кимчи', Халапеньо, Томаты",
                Price = "570",
                Image = "diabolo_1.jpg"
            },
            new PizzaModel {
                Id = 16,
                Name = "Кальяри",
                Ingredients = "Соус 'Кальяри', Креветки тигровые, Куриная грудка, Сыр моцарелла, Ананас, Соус 'Унаги', Кунжут",
                Price = "590",
                Image = "cagliari_1.jpg"
            },
            new PizzaModel {
                Id = 17,
                Name = "Колизей",
                Ingredients = "Соус 'Горчичный', Сыр моцарелла, Куриный рулет, Колбаски охотничьи," +
                " Соус 'Кисло-сладкий', Томаты свежие, Лук маринованный",
                Price = "570",
                Image = "kolizey_1.jpg"
            },
            new PizzaModel {
                Id = 18,
                Name = "Королевская",
                Ingredients = "Соус 'Кальяри', Сыр моцарелла, Бекон, Креветки тигровые, Сыр пармезан, Томаты черри",
                Price = "660",
                Image = "korolevskaya_1.jpg"
            },
            new PizzaModel {
                Id = 19,
                Name = "Крестьянская",
                Ingredients = "Соус '1000 островов', Сыр моцарелла, Ветчина, Бекон, Укроп, Томаты, Шампиньоны, Лук маринованный",
                Price = "535",
                Image = "krestyanskaya_1.jpg"
            },
            new PizzaModel {
                Id = 20,
                Name = "Маргарита",
                Ingredients = "Соус 'Томатный', Сыр моцарелла, Сливочный сыр, Томаты черри",
                Price = "530",
                Image = "margarita_1.jpg"
            },
            new PizzaModel {
                Id = 21,
                Name = "Морская",
                Ingredients = "Соус 'Кальяри', Сыр моцарелла, Кальмар, Креветки тигровые, Мидии, Осьминог, Лимон, Укроп, Лук маринованный, Маслины",
                Price = "650",
                Image = "morskaya_1.jpg"
            },
            new PizzaModel {
                Id = 22,
                Name = "Мясная сборная",
                Ingredients = "Соус 'Барбекю', Сыр моцарелла, Куриный рулет, Ветчина, Бекон, " +
                "Сервелат, Томаты, Перец болгарский, Лук маринованный, Маслины",
                Price = "580",
                Image = "myasnaya_sbornaya_1.jpg"
            },
            new PizzaModel {
                Id = 23,
                Name = "Остров пепперони",
                Ingredients = "Сыр моцарелла x2, Соус '1000 островов', Пепперони, Томаты свежие",
                Price = "560",
                Image = "ostrov_pepperoni_1.jpg"
            },
            new PizzaModel {
                Id = 24,
                Name = "Охотничья",
                Ingredients = "Соус '1000 островов', Сыр моцарелла, Сервелат, Бекон, Колбаски охотничьи," +
                " Сливочный сыр, Сыр пармезан, Томаты черри, Лук маринованный, Маслины",
                Price = "580",
                Image = "ohotnichya_1.jpg"
            },
            new PizzaModel {
                Id = 25,
                Name = "Пепперони",
                Ingredients = "Соус 'Томатный', Сыр моцарелла, Пепперони",
                Price = "510",
                Image = "peperoni_1.jpg"
            },
            new PizzaModel {
                Id = 26,
                Name = "Пикантная",
                Ingredients = "Соус 'Кальяри', Ветчина, Сливочный сыр, Сыр моцарелла, Сыр пармезан, Томаты свежие, Перец болгарский",
                Price = "570",
                Image = "pikantnaya_1.jpg"
            },
            new PizzaModel {
                Id = 27,
                Name = "Пиноккио",
                Ingredients = "Соус 'Гавайский', Куриный рулет, Сыр моцарелла, Кукуруза",
                Price = "530",
                Image = "pinokio_1.jpg"
            },
            new PizzaModel {
                Id = 28,
                Name = "Пицца-Cezar",
                Ingredients = "Ветчина, Куриная грудка, Соус 'Кальяри', Сыр моцарелла, Салат айсберг, Сыр пармезан, Соус 'Спайси'",
                Price = "570",
                Image = "cezar_1.jpg"
            },
            new PizzaModel {
                Id = 29,
                Name = "Пицца-бургер",
                Ingredients = "Соус 'Томатный', Сыр моцарелла, Куриный рулет, Ветчина, Соус 'Бургер', Сервелат, Кунжут, Перец болгарский",
                Price = "560",
                Image = "burger_1.jpg"
            },
                new PizzaModel {
                Id = 30,
                Name = "Сардиния",
                Ingredients = "Соус 'Кальяри', Сыр моцарелла, Брокколи, Сливочный сыр, Креветки тигровые, Томаты черри",
                Price = "600",
                Image = "sardiniya_1.jpg"
            },
            new PizzaModel {
                Id = 31,
                Name = "Славянская",
                Ingredients = "Соус '1000 островов', Сыр моцарелла, Картофельные дольки, Бекон, Ветчина," +
                " Огурцы маринованные, Лук маринованный, Зелень, Томаты свежие",
                Price = "560",
                Image = "slavyanskaya_1.jpg"
            },
            new PizzaModel {
                Id = 32,
                Name = "Сладкая Италия",
                Ingredients = "Соус 'Сливочный', Груша консервированная, Сыр моцарелла, Сыр с голубой плесенью, Орехи грецкие, Мёд натуральный",
                Price = "620",
                Image = "sladkaya_italiya_1.jpg"
            },
            new PizzaModel {
                Id = 33,
                Name = "Сливочно-острая",
                Ingredients = "Соус '1000 островов', Сыр моцарелла, Сервелат, Бекон, Сливочный сыр, Соус 'Кимчи', Халапеньо, Томаты",
                Price = "560",
                Image = "slivochno_ostraya_1.jpg"
            },
            new PizzaModel {
                Id = 34,
                Name = "Солянка",
                Ingredients = "Соус 'Барбекю', Сыр моцарелла, Колбаски охотничьи, Бекон, Сервелат," +
                " Огурцы маринованные, Лимон, Укроп, Томаты черри, Лук маринованный, Маслины",
                Price = "600",
                Image = "solanka_1.jpg"
            },
            new PizzaModel {
                Id = 35,
                Name = "Сырная",
                Ingredients = "Сыр моцарелла, Сливочный сыр, Соус 'Кальяри', Сыр фетаки, Сыр с голубой плесенью, Сыр пармезан",
                Price = "620",
                Image = "cheese_1.jpg"
            },
            new PizzaModel {
                Id = 36,
                Name = "Татарская",
                Ingredients = "Соус 'Томатный', Куриный рулет, Сыр моцарелла, Конно-говяжья колбаса, Лук маринованный," +
                " Томаты, Шампиньоны, Перец болгарский",
                Price = "600",
                Image = "tatarskaya.jpg"
            },
            new PizzaModel {
                Id = 37,
                Name = "Фиеста",
                Ingredients = "Соус '1000 островов', Сыр моцарелла, Куриный рулет, Колбаски охотничьи, Сливочный сыр," +
                " Сервелат, Опята маринованные, Шампиньоны",
                Price = "580",
                Image = "fiesta_1.jpg"
            },
            new PizzaModel {
                Id = 38,
                Name = "Филадельфия",
                Ingredients = "Соус 'Кальяри', Сыр моцарелла, Лосось, Сливочный сыр, Авокадо",
                Price = "650",
                Image = "filadelf_1.jpg"
            },
            new PizzaModel {
                Id = 39,
                Name = "Цезарь с лососем",
                Ingredients = "Сыр моцарелла, Соус 'Кальяри', Томаты свежие, Лосось, Салат айсберг, Соус 'Спайси', Сыр пармезан",
                Price = "650",
                Image = "cezar_s_lososem_1.jpg"
            },
            new PizzaModel {
                Id = 40,
                Name = "Инди-мандарин",
                Ingredients = "Соус 'Сливочный', Индейка в имбирном соусе, Сыр моцарелла, Мандарины консервированные, " +
                "Орехи грецкие, Соус 'Брусничный'",
                Price = "Временно недоступно",
                Image = "indi_mandarin_1.jpg"
            }
        };
        public ReadOnlyCollection<PizzaModel> GetPizzas()
        {
            return pizzas.AsReadOnly();
        }
        public PizzaModel? FindById(int id)
        {
            return pizzas.FirstOrDefault(p => p.Id == id);
        }
    }
}
