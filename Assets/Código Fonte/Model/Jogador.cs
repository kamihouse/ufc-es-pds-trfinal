﻿public class Jogador {

	private int posicao;
	private int idJogador;
	private int saldo;

	public Jogador(int idJogador, int saldo){
		this.posicao = 0;
		this.idJogador = idJogador;
		this.saldo = saldo;
	
	}

	public int getPosicao(){
		return this.posicao;
	}


	public int getIdJogador(){
		return this.idJogador;
	}


	public double getSaldo(){
		return this.saldo;
	}


	public void setPosicao(int posicao){
		this.posicao = posicao;

	}
	

	public void cobrarValor(int valor){
		this.saldo -= valor;
		
	}
}
