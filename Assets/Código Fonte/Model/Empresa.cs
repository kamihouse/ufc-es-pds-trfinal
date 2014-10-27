public class Empresa : ILogradouro {

	private int indice;
	private	int idJogadorDono;
	private int preco;
	private int taxa;


	public void acao(){

	}
	

	public int getIndice(){
		return this.indice;
	}


	public bool compra(int idJogador){
		return true;
	}


	public int pedagio(int valorDado){
		return 0;
	}
}
