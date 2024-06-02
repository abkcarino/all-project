import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JPanel;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.Color;
import java.awt.Font;
import java.awt.GridLayout;
import java.util.Random;
import javax.swing.Timer;
import javax.swing.*;
public class jeu {
    public static void main(String[] args) {
     JFrame f=new JFrame();
     f.setLayout(null);
     f.setVisible (true);
     f.setSize(1000,600);
     f.setTitle("Jeu éducatif");
     f.setLocationRelativeTo(null);
    // f.getContentPane().setBackground(Color.gray);
   // ((JPanel) f.getContentPane()).setOpaque(true);
    ImageIcon backgroundImage = new ImageIcon("num.jpg");
      JLabel backgroundLabel = new JLabel(backgroundImage);
      backgroundLabel.setBounds(0, 0, f.getWidth(), f.getHeight());

     JLabel l= new JLabel("WELCOME TO THE EDUCATIONAL GAME !!");
     JButton b=new JButton("START");
     Font a= new Font("Garamond",Font.BOLD,24);
     l.setForeground(Color.white);
     //l.setBackground(Color.YELLOW);
     //l.setOpaque(true);
     l.setFont(a);
     l.setBounds(230, 150, 520, 50);
     b.setBackground(Color.white);
     b.setBounds(400, 350, 200, 100);
     f.setContentPane(backgroundLabel);
     b.addActionListener(new ActionListener(){  
        public void actionPerformed(ActionEvent e){ 
            f.dispose(); 
            JFrame fmenu = new JFrame();
            fmenu.setLayout(null);
            fmenu.setVisible (true);
            fmenu.setSize(1000,600);
            fmenu.setTitle("Jeu éducatif");
            fmenu.setLocationRelativeTo(null);
             //fmenu.getContentPane().setBackground(Color.gray);
            JLabel backgroundLabel1 = new JLabel(backgroundImage);
             backgroundLabel1.setBounds(0, 0, fmenu.getWidth(), fmenu.getHeight());
             fmenu.setContentPane(backgroundLabel1);
            JLabel lmenu= new JLabel("CHOOSE THE DIFFICULTY :");
            lmenu.setForeground(Color.black);
           // lmenu.setBackground(Color.YELLOW);
            lmenu.setOpaque(true);
            lmenu.setFont(a);
            lmenu.setBounds(325, 150, 350, 50);
            fmenu.add(lmenu);
            JButton b1=new JButton("EASY");
            JButton b2=new JButton("HARD");
            b1.setBackground(Color.green);
            b2.setBackground(Color.red);
            b1.setBounds(200, 350, 200, 100);
             b2.setBounds(600, 350, 200, 100);
            
            b1.addActionListener(new ActionListener() {
                public void actionPerformed(ActionEvent e){
                    fmenu.dispose();
                    JFrame feasy = new JFrame();
                    feasy.setLayout(null);
                    feasy.setVisible (true);
                    feasy.setSize(1000,600);
                    feasy.setTitle("Jeu éducatif");
                    feasy.setLocationRelativeTo(null);
                    feasy.getContentPane().setBackground(Color.gray);           
                    int max=10;
                    int maxsol=20;
                    int num1=new Random().nextInt(max);
                    int num2=new Random().nextInt(max);
                    int num10=new Random().nextInt(maxsol);
                    int num20=new Random().nextInt(maxsol);
                    int num30=new Random().nextInt(maxsol);
                    int num40=num1+num2;
                    while (num10 == num40 || num10 == num30 || num10 ==num20){num10=new Random().nextInt(maxsol);}
                    while (num20 == num40 || num20 == num30 || num20 ==num10){num20=new Random().nextInt(maxsol);}
                    while (num30 == num40 || num30 == num10 || num30 ==num20){num30=new Random().nextInt(maxsol);}
                    int[]wanswers = {num10,num20,num30};
                    int numc=new Random().nextInt(4);
                    int[] ansewrs = new int[4];
                    ansewrs[numc]=num40;
                    int j=0;
                    for (int i=0;i<4;i++){
                        if (ansewrs[i]==num40){}else{ansewrs[i]=wanswers[j];j++;}
                    }
                    JPanel ansewrspanel = new JPanel(new GridLayout(2,2));
                    for (int i=0;i<4;i++){
                        if (i==numc){
                            String S=ansewrs[i]+" ?";
                            JButton button=new JButton(S);
                            button.addActionListener(new ActionListener() {
                                public void actionPerformed(ActionEvent e){
                                    JFrame fcorr=new JFrame();
                                    fcorr.setLayout(null);
                                    fcorr.setVisible (true);
                                    fcorr.setSize(300,250);
                                    fcorr.setTitle("Jeu éducatif");
                                    fcorr.setLocationRelativeTo(null);
                                    fcorr.getContentPane().setBackground(Color.green);
                                    JLabel lcorr=new JLabel("CORRECT !!");
                                    lcorr.setForeground(Color.black);
                                    lcorr.setBackground(Color.green);
                                    lcorr.setOpaque(true);
                                    lcorr.setBounds(100,55,100,50);
                                    JButton bpa = new JButton("Play Again");
                                    bpa.addActionListener(new ActionListener() { 
                                        public void actionPerformed(ActionEvent e){
                                            fcorr.dispose();
                                            feasy.dispose();
                                            main(null);
                                        }
                                    });
                                    bpa.setBounds(100,120 ,100 ,50 );
                                    fcorr.add(bpa);
                                    fcorr.add(lcorr);
                                }
                                
                            });
                            ansewrspanel.add(button);
                        }else{
                            String S=ansewrs[i]+" ?";
                            JButton button1=new JButton(S);
                            button1.addActionListener(new ActionListener() {
                                public void actionPerformed(ActionEvent e){
                                    JFrame fincorr=new JFrame();
                                    fincorr.setLayout(null);
                                    fincorr.setVisible (true);
                                    fincorr.setSize(300,200);
                                    fincorr.setTitle("Jeu éducatif");
                                    fincorr.setLocationRelativeTo(null);
                                    fincorr.getContentPane().setBackground(Color.red);
                                    JLabel lincorr=new JLabel("INCORRECT !!");
                                    lincorr.setForeground(Color.black);
                                    lincorr.setBackground(Color.red);
                                    lincorr.setOpaque(true);
                                    lincorr.setBounds(100,55,100,50);
                                    fincorr.add(lincorr);
                                }
                            }); 
                            ansewrspanel.add(button1);  }          

                    }
                    ansewrspanel.setBounds(200, 350, 600, 200 );
                    feasy.add(ansewrspanel);
                    String equation ="         "+ num1 + " + " + num2 + " = ?";
                    JLabel leasy=new JLabel(equation);
                    leasy.setForeground(Color.black);
                    leasy.setBackground(Color.YELLOW);
                    leasy.setOpaque(true);
                    leasy.setFont(a);
                    leasy.setBounds(400, 150, 200, 50);
                    feasy.add(leasy);
                    
                }
            });
            b2.addActionListener(new ActionListener() {
                public void actionPerformed(ActionEvent e){
                    fmenu.dispose();
                    JFrame fhard = new JFrame();
                    fhard.setLayout(null);
                    fhard.setVisible (true);
                    fhard.setSize(1000,600);
                    fhard.setTitle("Jeu éducatif");
                    fhard.setLocationRelativeTo(null);
                    fhard.getContentPane().setBackground(Color.gray); 
                    JLabel timerlabel = new JLabel("Time : 0 seconds");
                    timerlabel.setForeground(Color.black);
                    timerlabel.setBackground(Color.YELLOW);
                    timerlabel.setOpaque(true);
                    timerlabel.setFont(a);
                    timerlabel.setBounds(400, 250, 200, 50);
                    Timer timer= new Timer(1000,new ActionListener() {
                        int Time = 0;
                       public void actionPerformed(ActionEvent e) {
                           Time++;
                           timerlabel.setText("Time: " + Time + " seconds");
                       }
                   });
                   timer.start();
                   fhard.add(timerlabel);
                   int num1,num2,num10,num20,num30,num40;
                    int numeq=new Random().nextInt(2);
                    if (numeq==1){
                     num1=new Random().nextInt(5,20);
                     num2=new Random().nextInt(2,10);
                     num40=num1*num2;
                    }else{ 
                    num1=new Random().nextInt(100,300);
                    num2=1;
                    for (int i=15;i>1;i--){if (num1%i == 0){num2=i;i=0;}}
                    num40=num1 / num2;
                    }
                    num10= new Random().nextInt(num40-5,num40+5 );
                    num20= new Random().nextInt(num40-5,num40+5 );
                    num30= new Random().nextInt(num40-5,num40+5 );
                    while (num10 == num40 || num10 == num30 || num10 ==num20){num10=new Random().nextInt(num40-5,num40+5 );}
                    while (num20 == num40 || num20 == num30 || num20 ==num10){num20=new Random().nextInt(num40-5,num40+5 );}
                    while (num30 == num40 || num30 == num10 || num30 ==num20){num30=new Random().nextInt(num40-5,num40+5 );}  
                    int[]wanswers = {num10,num20,num30};
                    int numc=new Random().nextInt(4);
                    int[] ansewrs = new int[4];
                    ansewrs[numc]=num40;
                    int j=0;
                    for (int i=0;i<4;i++){
                        if (ansewrs[i]==num40){}else{ansewrs[i]=wanswers[j];j++;}
                    }
                    JPanel ansewrspanel = new JPanel(new GridLayout(2,2));
                    for (int i=0;i<4;i++){
                        if (i==numc){
                            String S=ansewrs[i]+" ?";
                            JButton button=new JButton(S);
                            button.addActionListener(new ActionListener() {
                                public void actionPerformed(ActionEvent e){
                                    timer.stop();
                                    JFrame fcorr=new JFrame();
                                    fcorr.setLayout(null);
                                    fcorr.setVisible (true);
                                    fcorr.setSize(300,250);
                                    fcorr.setTitle("Jeu éducatif");
                                    fcorr.setLocationRelativeTo(null);
                                    fcorr.getContentPane().setBackground(Color.green);
                                    JLabel lcorr=new JLabel("CORRECT !!");
                                    lcorr.setForeground(Color.black);
                                    lcorr.setBackground(Color.green);
                                    lcorr.setOpaque(true);
                                    lcorr.setBounds(100,55,100,50);
                                    fcorr.add(lcorr);
                                    JButton bpa = new JButton("Play Again");
                                    bpa.addActionListener(new ActionListener() { 
                                        public void actionPerformed(ActionEvent e){
                                            fcorr.dispose();
                                            fhard.dispose();
                                            main(null);
                                        }
                                    });
                                    bpa.setBounds(100,120 ,100 ,50 );
                                    fcorr.add(bpa);
                                }
                                
                            });
                            ansewrspanel.add(button);
                        }else{
                            String S=ansewrs[i]+" ?";
                            JButton button1=new JButton(S);
                            button1.addActionListener(new ActionListener() {
                                public void actionPerformed(ActionEvent e){
                                    JFrame fincorr=new JFrame();
                                    fincorr.setLayout(null);
                                    fincorr.setVisible (true);
                                    fincorr.setSize(300,200);
                                    fincorr.setTitle("Jeu éducatif");
                                    fincorr.setLocationRelativeTo(null);
                                    fincorr.getContentPane().setBackground(Color.red);
                                    JLabel lincorr=new JLabel("INCORRECT !!");
                                    lincorr.setForeground(Color.black);
                                    lincorr.setBackground(Color.red);
                                    lincorr.setOpaque(true);
                                    lincorr.setBounds(100,55,100,50);
                                    fincorr.add(lincorr);
                                }
                            }); 
                            ansewrspanel.add(button1);  }          

                    }
                    ansewrspanel.setBounds(200, 350, 600, 200 );
                    fhard.add(ansewrspanel); 
                    String equation;
                    if (numeq==1){equation ="         "+ num1 + " * " + num2 + " = ?";} 
                    else{equation ="         "+ num1 + " / " + num2 + " = ?";}  
                    JLabel lhard=new JLabel(equation);
                    lhard.setForeground(Color.black);
                    lhard.setBackground(Color.YELLOW);
                    lhard.setOpaque(true);
                    lhard.setFont(a);
                    lhard.setBounds(400, 150, 200, 50);
                    fhard.add(lhard);              
                }
            });
            fmenu.add(b1);
            fmenu.add(b2);

            }  
        });  
     f.add(b);
     f.add(l);
    }
}