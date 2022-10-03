class PuertaSeguridad: Puerta{
    bool estado;
    public PuertaSeguridad(string n) :base(n){
        estado = true;
        Console.WriteLine(getNombre() +" : Constructor Puerta de seguridad");
    }
    ~PuertaSeguridad(){
        Console.WriteLine(getNombre()+ " : Destructor Puerta de seguridad");
    }

    public new void abrir(){
        if(false ==estado){
            base.abrir();
        }else{
            Console.WriteLine(base.getNombre()+" : No se puede abrir esta trabada");
        }
    }
    public void trabar(){ estado =  true;}
    public void destrabar(){estado =  false;}

}