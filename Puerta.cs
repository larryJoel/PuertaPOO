class Puerta{
    bool abierta;
    string nombre;
    virtual public void abrir(){
        abierta = true;
        Console.WriteLine(nombre+" : abriendo");
    }
    virtual public void cerrar(){
    abierta = false;
        Console.WriteLine(nombre+" : cerrando");
    }
    public override string ToString()
    {
        var msg = nombre +": Estado: ";
        if(abierta)
            msg += "abierta";
        else
            msg += "cerrada";
        return msg;
    }
    protected string getNombre(){
        return nombre;
    }
    public Puerta(string nomb){
        abierta = false;
        nombre=nomb;
        Console.WriteLine("Constructor puerta");
    }

    ~Puerta(){
        cerrar();
        Console.WriteLine("Destructor puerta");
    }


}