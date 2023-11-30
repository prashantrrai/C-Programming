using System;
using System.Text;
using Patterns;

namespace Pattern
{
    class DriverCode
    {
        static void Main(string[] args)
        {
            half_left_pyramid obj = new half_left_pyramid();
            half_right_pyramid obj2 = new half_right_pyramid();
            Full_Top_Pyramid obj3 = new Full_Top_Pyramid();
            Full_Down_Pyramid obj4 = new Full_Down_Pyramid();
            Diamond obj5 = new Diamond();
            Heart obj6 = new Heart();
            Right_Pascal_Triangle obj7 = new Right_Pascal_Triangle();
            Hollow obj8 = new Hollow();
            Pascals_Triangle obj9 = new Pascals_Triangle();
            Pattern_Task obj10 = new Pattern_Task();

            Console.WriteLine("Enter the Value :");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("======================================================");


            //obj.star(num);
            //obj.number(num);
            //obj.floydtriangle(num);
            //obj.reversefloydtriangle(num);
            //obj.reversefloydtriangle_withoutcounter(num);
            //obj.samenumber(num);
            //obj.abcd(num);
            //obj.misc1(num);
            //obj.misc2(num);
            //obj.misc3(num);


            //obj2.star(num);
            //obj2.number(num);
            //obj2.floydtriangle(num);
            //obj2.reversefloydtriangle(num);
            //obj2.reversefloydtriangle_withoutcounter(num);
            //obj2.samenumber(num);
            //obj2.abcd(num);
            //obj2.misc1(num);
            //obj2.misc2(num);
            //obj2.misc3(num);
            //obj2.misc4(num);

            //obj3.star(num);
            //obj4.left(num);
            //obj4.right(num);
            //obj4.full(num);

            //obj5.diamond(num);
            //obj5.diamond_odd(num);
            //obj5.numerical_diamond_1(num);
            //obj5.numerical_diamond_2(num);
            //obj5.numerical_diamond_3(num);

            //obj6.Heart_Pattern();

            //obj7.left_pascal(num);
            //obj7.right_pascal(num);
            //obj7.sand_glass(num);

            //obj8.triangle_hollow(num);
            //obj8.pyramid_hollow(num);


            //obj9.pascal(num);

            //obj10.pattern1(num);
            //obj10.pattern2(num);
            //obj10.pattern3(num);
            //obj10.pattern4(num);
            //obj10.pattern5(num);
            //obj10.pattern6(num);
            obj10.pattern7(num);


            Console.WriteLine("======================================================");

        }
    }
}