
interface Sofa
{
    public void collor();
}

interface CofeTable
{
    public void collor();
}
interface Chair
{
    public void hasLegs();
    public void sitOn();
}

class VictorianChair : Chair
{
    public void hasLegs()
    {
        throw new NotImplementedException();
    }

    public void sitOn()
    {
        throw new NotImplementedException();
    }
}

class ModernChair : Chair
{
    public void hasLegs()
    {
        throw new NotImplementedException();
    }

    public void sitOn()
    {
        throw new NotImplementedException();
    }
}

class ArtDecorChair : Chair
{
    public void hasLegs()
    {
        throw new NotImplementedException();
    }

    public void sitOn()
    {
        throw new NotImplementedException();
    }
}

class VictorianCofeTable : CofeTable
{
    public void collor()
    {
        throw new NotImplementedException();
    }
}

class ModernCofeTable : CofeTable
{
    public void collor()
    {
        throw new NotImplementedException();
    }
}
class ArtDecorCofeTable : CofeTable
{
    public void collor()
    {
        throw new NotImplementedException();
    }
}
class VictorianSofa : Sofa
{
    public void collor()
    {
        throw new NotImplementedException();
    }
}

class ModernSofa : Sofa
{
    public void collor()
    {
        throw new NotImplementedException();
    }
}
class ArtDecorSofa : Sofa
{
    public void collor()
    {
        throw new NotImplementedException();
    }
}


interface FurnitureFactory
{
    public Chair createChair();
    public CofeTable createCofeTable();
    public Sofa createSofa();
}

class VictorianFurnitureFactory : FurnitureFactory
{
    public Chair createChair()
    {
         return new VictorianChair();
    }

    public CofeTable createCofeTable()
    {
        return new VictorianCofeTable();
    }

    public Sofa createSofa()
    {
        return new VictorianSofa();
    }
}

class ModernFurnitureFactory : FurnitureFactory
{
    public Chair createChair()
    {
        return new ModernChair();
    }

    public CofeTable createCofeTable()
    {
        return new ModernCofeTable();
    }

    public Sofa createSofa()
    {
        return new ModernSofa();
    }
}

class ArtDecorFurnitureFactory : FurnitureFactory
{
    public Chair createChair()
    {
        return new ArtDecorChair();
    }

    public CofeTable createCofeTable()
    {
        return new ArtDecorCofeTable();
    }

    public Sofa createSofa()
    {
        return new ArtDecorSofa();
    }
}

