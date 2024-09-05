

public class Main
{
    public static void main(String[] args){
        Corredor corredor = new Corredor("Otavio");
      
        adicionarCorrida(corredor);
        System.out.println("Ola " +corredor.getNome());
        System.out.println("Corrida mais rapida: " +corredor.maisRapida());
        System.out.println("Velocidade media: " +corredor.velMedia());
    }
    
    public static void adicionarCorrida(Corredor corredor){
        Corrida corrida1 = new Corrida(1, "01/01/2024", "19:00", 1.8, "Pedro teixeira", 25, 10);
        Corrida corrida2 = new Corrida(2, "01/01/2023", "17:00", 5.7, "Pedro teixeira", 45, 32);
        Corrida corrida3 = new Corrida(3, "01/01/2022", "15:00", 3.0, "Pedro teixeira", 35, 15);
        Corrida corrida4 = new Corrida(4, "01/01/2021", "13:00", 2.5, "Pedro teixeira", 30, 10);
    
        corredor.addCorrida(corrida1);
        corredor.addCorrida(corrida2);
        corredor.addCorrida(corrida3);
        corredor.addCorrida(corrida4);
        
    }
}
