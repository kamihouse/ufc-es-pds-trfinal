public class Empresa : ILogradouro {

	private int indice;
	private	int idJogadorDono;
	private int preco;
	private int taxa;

	public Empresa(int indice, int preco){
		this.indice = indice;
		this.idJogadorDono = 0;
		this.preco = preco;
		double calcTaxa =preco*0.2; 
		this.taxa = (int)calcTaxa;
	
	}

	public void acao(Jogador j){
		if (idJogadorDono == -1) {
			opcaoCompra (j);
		} else if (idJogadorDono != j.getIdJogador ()) {
			cobrarTaxa(j);
		}
		
	}
	
	public int getIndice(){
		return this.indice;
	}
	
	public void opcaoCompra(Jogador j){
		
		comprar (j, true);
		
		
	}
	public void comprar(Jogador j,bool decisao){
		if (decisao) {
			this.idJogadorDono = j.getIdJogador ();
			j.cobrarValor (this.preco);
		}
	}
	public void cobrarTaxa(Jogador j){
		j.cobrarValor (taxa);
	}

}
