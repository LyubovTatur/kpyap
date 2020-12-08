using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//      Создать также класс наследник Цифровой фотоаппарат, 
//      в котором будет дополнительный целый параметр – количество мегапикселей и переопределить метод «Стоимость», 
//      который будет возвращать число, равное стоимости обычного фотоаппарата умножить на количество мегапикселей, 
//      а также определить новый метод «Обновление модели», который увеличивает количество мегапикселей на 2.
//      В главной программе(либо по нажатию на кнопку) создать объект
//      класса Фотоаппарат с 4-ми кратным оптическим увеличением(Zoom= 4) и пластиковым корпусом,
//      а также Цифровой фотоаппарат с металлическим корпусом, 8-ю мегапикселями и 3-кратным
//      оптическим увеличением.Вывести на экран(или форму) информацию о фотоаппаратах и о том,
//      являются ли они дорогими.Обновить модели цифрового фотоаппарата и снова вывести информацию о нем.

namespace labaa10
{
    class DigitFotik : Fotik
    {
        int Megapix;
        public DigitFotik(string Model, int Zoom, string Stuff, int Megapix) : base(Model, Zoom, Stuff)
        {
            this.Megapix = Megapix;
        }

        public override int Price()
        {
            return base.Price()*Megapix;
        }
        public void  UpgradeModel()
        {
            Megapix += 2;
        }
        public override string Info()
        {

            return base.Info() + $"Мегапикселей: {Megapix}\n";
        }
    }
}
