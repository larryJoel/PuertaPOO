class program{
    static void pruebaDePuertas(){
        var p = new Puerta("Comedor");
    p.abrir();
    p.cerrar();
    Console.WriteLine(p);

    var hela = new PuertaHeladera ("Heladera Cocina");
    hela.abrir();
    hela.cerrar();
    Console.WriteLine(hela);

    var pSeg = new PuertaSeguridad("Tranquera");
    Console.WriteLine(pSeg);
    //pSeg.abrir();
    //pSeg.cerrar();
    pSeg.trabar();
    pSeg.abrir();
    Console.WriteLine(pSeg);
    pSeg.destrabar();
    pSeg.abrir();
    Console.WriteLine(pSeg);

    var pAuto = new PuertaAuto("Ferrari");
    pAuto.abrir();
    pAuto.cerrar();
    pAuto.trabar();
    pSeg.destrabar();
    pAuto.desbloquearChicos();
    pAuto.bloquearChicos();
    Console.WriteLine(pAuto);
    }
    static void Main(string[] args)
{
    pruebaDePuertas();
    GC.Collect();
    Console.WriteLine("Terminado");
    Console.ReadKey();
}
}