

public class Fraction{
    private int _bottom;
    private int _top;
    public Fraction(){
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int integer){
        _top = integer;
        _bottom = 1;
    }
    public Fraction(int top, int bottom){
        _top = top;
        _bottom = bottom;
    }
    public string GetFractionString(){
        return _top + "/" + _bottom;
    }
    public double GetDecimalValue(){
        return (double)_top / (double)_bottom;
    }
}