/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package trananhtuan;

import java.util.Scanner;

/**
 *
 * @author Administrator
 */
public class TranAnhTuan_Bai4 {
    public static void main(String[] args) {
        System.out.println("Tran Anh Tuan-22211TT4630_Bai4");
        Scanner input = new Scanner(System.in);
        System.out.println("Enter Length: ");
        int length = input.nextInt();
        System.out.println("Enter Width: ");
        int width = input.nextInt();
        int areaofrectangle = length * width;
        int perimeterofrectangle = (length+width)*2;
        System.out.println("Area of Rectangle("+length+","+width+") is "+areaofrectangle);
        System.out.println("Perimeter of Rectangle("+length+","+width+") is "+perimeterofrectangle);
    }
}
