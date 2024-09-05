

public class Corrida
{
    private int numero;
    private String data;
    private String hora;
    private double distanciaPercorrida;
    private String local;
    private double valorCorrida;
    private double tempoCorrida;
    
    public Corrida(int numero, String data, String hora, double distanciaPercorrida, String local, double valorCorrida, double tempoCorrida){
        this.numero = numero;
        this.data = data;
        this.hora = hora;
        this.distanciaPercorrida = distanciaPercorrida;
        this.local = local;
        this.valorCorrida = valorCorrida;
        this.tempoCorrida = tempoCorrida;
    }
    
    public double velocidadeMedia(){
        return getDistanciaPercorrida() / getTempoCorrida();
    }
    
    public String getData(){
        return this.data;
    }
    public void setData(String data){
        this.data = data;
    }
    
    public int getNumero(){
        return this.numero;
    }
    public void setNumero(int numero){
        this.numero = numero;
    }
    
    public String getHora(){
        return this.hora;
    }
    public void setHora(String hora){
        this.hora = hora;
    }
    
    public double getDistanciaPercorrida(){
        return this.distanciaPercorrida;
    }
    public void setDistanciaPercorrida(double distanciaPercorrida){
        this.distanciaPercorrida = distanciaPercorrida;
    }
    
    public String getLocal(){
        return this.local;
    }
    public void setLocal(String local){
        this.local = local;
    }
    
    public double getValorCorrida(){
        return this.valorCorrida;
    }
    public void setValorCorrida(double valorCorrida){
        this.valorCorrida = valorCorrida;
    }
    
    public double getTempoCorrida(){
        return this.tempoCorrida;
    }
    public void setTempoCorrida(double tempoCorrida){
        this.tempoCorrida = tempoCorrida;
    }
}
