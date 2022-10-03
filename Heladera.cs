class PuertaHeladera: Puerta{
    List<string> cosas;
    public PuertaHeladera() : this("Unica Heladera"){}
    public PuertaHeladera(string n) :base(n){
        cosas = new List<string>();
        Console.WriteLine(getNombre()+" : Constructor PuertaHeladera");
    }
    ~PuertaHeladera(){
        Console.WriteLine(getNombre()+" : Destructor PuertaHeladera");
    }
    public override string ToString()
    {
        string msg = base.ToString()+"\n";
        msg += getNombre() + " : PuertaHeladera: ";
        foreach (var n in cosas)
        {
            msg += n + ",";
        }
        return msg;
    }

    public override void cerrar(){
        Console.WriteLine(getNombre()+ " : Apagando la luz de la heladera");
    }
    public new void abrir(){
        base.abrir();
        Console.WriteLine(getNombre()+" : Prendiendo la luz de la heladera");
    }

}