//Bir Figure abstrakt class-ı olur və onun Figure-dan miras alan zaman mütləq override edilməsi lazım olan bir CalcArea methodu olur.

//Bir Square class-ı olur side deyə bir property-i olur və side mənfi ola bilməz.
//Side dəyəri təyin olunmamış Square obyekti yaradıla bilməz.
//Square class-ı Figure class-ından miras alacaq və CalcArea methodunu özünə uyğun override edəcək.

//Bir Rectangular class-ı olur width və length deyə property-ləri olacaq, width və length mənfi ola bilməz.
//Width və length dəyərləri təyin olunmamış Rectangular obyekti yaradıla bilməz.
//Rectangular class-ı Figure class-ından miras alacaq və CalcArea methodunu özünə uyğun override edəcək.

//Program class-ında bir menu olacaq
//1. Square
//2. Rectangular
//0. Quit

//İstifadəçi 1 yazıb enter-ə click-ləsə Square-in CalcArea methodu işə düşməlidir.
//İstifadəçi 2 yazıb enter-ə click-ləsə Rectangular-in CalcArea methodu işə düşməlidir.
//İstifadəçi 0 yazıb enter-ə click-ləsə proqram sonlanmalıdı.

using Polimorphism;

Figure figure;

Console.WriteLine("1. Square  2. Rectangular  0. Quit ");
int a = int.Parse (Console.ReadLine());
switch (a)
{
    case 1:
        Square s = new Square (5);
        Console.WriteLine(s.CalcArea());
        break;
        case 2:
        Rectangular r = new Rectangular (5,7);
        Console.WriteLine(r.CalcArea());
        break;
        case 0:
        return;

}
