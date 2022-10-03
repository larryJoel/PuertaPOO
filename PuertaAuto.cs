class PuertaAuto: PuertaSeguridad{
    bool bloqueoChicos;
    public PuertaAuto(string m): base(m){
        Console.WriteLine(getNombre() + " : Constructor puerta auto");
        bloquearChicos();
    }
    ~PuertaAuto(){
        Console.WriteLine(getNombre() + " : Destructor puerta auto");
    }
    public void bloquearChicos(){
        bloqueoChicos = true;
        Console.WriteLine(getNombre()+" : Bloqueando puerta de los chicos");
    }
    public void desbloquearChicos(){
        bloqueoChicos = false;
        Console.WriteLine (getNombre()+" : desbloqueando puerta para los chicos");
    }
}