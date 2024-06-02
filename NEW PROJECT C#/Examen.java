import java.util.Scanner;

public class Examen {
    static Scanner read = new Scanner(System.in);

    public static void remplirm(int[][] m, int l, int c) {
        for (int i = 0; i < l; i++) {
            for (int j = 0; j < c; j++) {

                System.out.println("donner la valeur de la case [" + i + "]" + "[" + j + "]:");
                while ((read.hasNextInt() == false)) {
                    System.out.println(" donner la valeur de la case [" + i + "]" + "[" + j + "]:");

                    read.next();
                }

                m[i][j] = read.nextInt();

            }
        }

    }

    public static int sommediag(int[][] m, int l, int c) {
        int s = 0;
        for (int i = 0; i < l; i++) {
            for (int j = 0; j < c; j++) {
                if (i == j) {
                    s = s + m[i][j];

                }
            }
        }

        return s;

    }

    public static void maxm(int[][] m, int l, int c) {
        int max = m[0][0];

        for (int i = 0; i < l; i++) {
            for (int j = 0; j < c; j++) {
                if (m[i][j] > max) {
                    max = m[i][j];

                }
            }
        }
        for (int i = 0; i < l; i++) {
            for (int j = 0; j < c; j++) {
                if (m[i][j] == max) {
                    System.out.println("le valeur max de la matrice =" + m[i][j] + "et sa position:" + i + "," + j);
                }
            }
        }

    }

    public static void echangev(int[][] m, int l, int c, int l1, int l2) {
        int[] p = new int[c];
        for (int j = 0; j < c; j++) {
            p[j] = m[l1][j];
        }
        for (int j = 0; j < c; j++) {
            m[l1][j] = m[l2][j];
        }
        for (int j = 0; j < c; j++) {
            m[l2][j] = p[j];
        }

    }

    public static void affichem(int[][] m, int l, int c) {
        for (int i = 0; i < l; i++) {
            for (int j = 0; j < c; j++) {

                System.out.println(" la valeur de la case [" + i + "]" + "[" + j + "]:" + m[i][j]);

            }
        }
    }

    public static void main(String[] args) {
        int c, l;

        System.out.println(" donner nombre de ligne :");

        while ((read.hasNextInt() == false)) {
            System.out.println(" donner nombre de ligne :");

            read.next();
        }
        l = read.nextInt();
        System.out.println(" donner nombre de collone :");

        while ((read.hasNextInt() == false)) {

            System.out.println(" donner nombre de collone :");

            read.next();
        }
        c = read.nextInt();
        while (c != l) {
            System.out.println(" donner nombre de collone :");
            c = read.nextInt();
        }
        int[][] m = new int[l][c];

        System.out.println("1 methode");
        remplirm(m, l, c);
        affichem(m, l, c);

        System.out.println("3 methode");
        maxm(m, l, c);
        System.out.println("4 methode");
        System.out.println("donner la premiere ligne");
        int l1 = read.nextInt();
        while (l1 > l) {
            System.out.println("donner la premiere ligne");
            l1 = read.nextInt();
        }
        System.out.println("donner la deuxieme ligne");
        int l2 = read.nextInt();
        while (l2 > l) {
            System.out.println("donner la deuxieme ligne");
            l2 = read.nextInt();
        }
        echangev(m, l, c, l1, l2);
        affichem(m, l, c);

        System.out.println("2 methode");
        int s = sommediag(m, l, c);
        System.out.println("la somme des elements de la diagonale=" + s);

    }

}