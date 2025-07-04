public class X{
	private int a1 ;
	private int a2 ;
	protected int a3 ;
	
	public X(int a3){
		this.a3 = a3;}
	public void f(){ 
		System.out.println(a1);}
	private void g(){
		System.out.println(a2);}
	public void h(){ 
		g();}
}

public class Y extends X{
	private int a1y;
	protected int y1;
	
	public Y(int a1y){
		super(1);
		this.a1y = a1y; }
	public int g(){
		returny1 + a1y ;}
}
public class Z extends Y{ 
	private int a1z ;
	public Z(){
		super(2) ;} 
	@ Override
	public int g(){
		super. g() +10;}
}
public class Z1 {
    private int a1;  
    private int a2;	
	private int a1y;

    protected int y1;
	protected int a3;

	public Z1(int a3,int a1y){
		this.a3 = 1;
		this.a1y = 2; 	
	}
	public void f(){ 
		System.out.println(a1);}
	private void g(){
		System.out.println(a2);}
	public void h(){ 
		g();}
    public int g_Y() {
        return y1 + a1y;
    }
    public int g_Z() {
        return g_Y() + 10;
    }	
}