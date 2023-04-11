/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package trananhtuan;

import java.util.Scanner;

/**
 *
 * @author TUAN
 */
public class TranAnhTuan_Bai6 {
    public static void main(String[] args) {
        System.out.println("Tran Anh Tuan-22211TT4630_Bai6");
        Scanner input = new Scanner(System.in);
        System.out.println("Change temperature F <-> C");
        System.out.println("1. C2F");
        System.out.println("2. F2C");
        System.out.print("Choose: ");
        int option = input.nextInt();
        
        if (option != 1) if (option == 2) {
            System.out.print("Enter Fahrenheit: ");
            double Fahrenheit = input.nextDouble();
            
            double Celsius = 5.0 / 9.0 * (Fahrenheit - 32);
            System.out.println(Celsius + "Celsius = " +Fahrenheit+ "Fahrenheit");
        }
        else {
            System.out.println("Loi vui long chon lai");
        }
        else {
            System.out.print("Enter Celsius: ");
            double Celsius = input.nextDouble();
            
            double Fahrenheit = 9.0 / 5.0 * Celsius + 32;
            System.out.println(Celsius+"Celsius = "+Fahrenheit+"Fahrenheit");
        }
    }
}
