/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.project2_calculatrice;

import javax.swing.JOptionPane;

/**
 *
 * @author youcef
 */
public class Calc {
    public static boolean containOperation(String str){
        char firstChar =str.charAt(0);
        str=str.substring(1);
        if (!Character.isDigit(firstChar)){

            return false;
        }else  if (str.contains("+") || str.contains("-") || str.contains("x") || str.contains("/")) {
            return true;
        }else return false;
    }

    public static char extractOperation(String m){

        String str=m.substring(1);
        if (str.contains("+") )return '+';
        else if  (str.contains("-") ) return '-';
        else if (str.contains("x")) return 'x';
        else if  (str.contains("/")) return '/';
        else return 'N';
        }
    public static double[] getNumbers(String str){
        double[] numbers=new double[2];
        char op=extractOperation(str);
        int index =str.indexOf(op);
       
        String num1 = str.substring(0, index);
        String num2 = str.substring(index+1, str.length());
        if (num1.contains("-")) {
            numbers[0]=Double.parseDouble(num1);
        }
        else numbers[0]=Double.parseDouble(num1);
        numbers[1]=Double.parseDouble(num2);
        return numbers;
    }
     public static double   calculate(double[] numbers,char op,String newOperation){
         double total=0;
     switch (op) {
            case '+':
                total=numbers[0]+numbers[1];
                break;
            case '-':
                total=(numbers[0]-numbers[1]);
                break;
            case 'x':
                total=(numbers[0]*numbers[1]);
                break;
            case '/':
                if(numbers[1]==0)  JOptionPane.showConfirmDialog(null, "cant divide on 0");
            else {
            total=(numbers[0]/numbers[1]);
            break;}

     }
     return total;
    }
}
