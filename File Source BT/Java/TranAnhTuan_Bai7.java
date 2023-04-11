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
public class TranAnhTuan_Bai7 {
    public static void main(String[] args) {
        System.out.println("Tran Anh Tuan-22211TT4630_Bai7");
        Scanner input = new Scanner(System.in);
//        System.out.print("Enter weightInPounds: "); 
//        double weightInPounds = input.nextDouble();
        System.out.print("Enter weightInKilograms: ");
        double weightInKilograms = input.nextDouble();
//        System.out.print("Enter heightInInches: ");
//        double heightInInches = input.nextDouble();
        System.out.print("Enter heightInMeters: ");
        double heightInMeters = input.nextDouble();
        
//        double BMI = (weightInPounds * 703) / (heightInInches * heightInInches);
        double BMI = weightInKilograms / (heightInMeters * heightInMeters);
        
        if (BMI < 18.5){
            System.out.println("Underweight");
        }
        else if (BMI >= 18.5 && BMI <= 24.9){
            System.out.println("Normal");
        }
        else if (BMI >= 25 && BMI <= 29.9){
            System.out.println("Overweight");
        }
        else {
            System.out.println("Obese");
        }
        System.out.println(BMI);
    }
}
