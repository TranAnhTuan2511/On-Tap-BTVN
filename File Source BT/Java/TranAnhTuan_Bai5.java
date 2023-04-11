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
public class TranAnhTuan_Bai5 {
    public static void main(String[] args) {
        System.out.println("Tran Anh Tuan-22211TT4630_Bai5");
        Scanner input = new Scanner(System.in);
        System.out.println("Enter amount of seconds: ");
        int seconds = input.nextInt();
        int hour = seconds / 3600;
        int minute = seconds % 3600 / 60;
        int second = seconds % 3600 % 60;
        
        System.out.printf(" result: %02d:%02d:%02d",hour,minute,second);
        System.out.println(" ");
    }
}
