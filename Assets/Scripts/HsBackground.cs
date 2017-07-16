using UnityEngine;
/* 
	@author Hudson Schumaker
	@version 1.0.0
*/
public class HsBackground : MonoBehaviour {

	private SpriteRenderer grafico;
	private float larguraImagem;
	private float alturaImagem;
	private float alturaTela;
	private float larguraTela;

	private void Start () {
		this.grafico = GetComponent<SpriteRenderer> ();
		this.larguraImagem = grafico.sprite.bounds.size.x;
		this.alturaImagem = grafico.sprite.bounds.size.y;
		this.alturaTela = Camera.main.orthographicSize * 2.0f;
		this.larguraTela = alturaTela / Screen.height * Screen.width;

		Vector2 novaEscala = transform.localScale;
		novaEscala.x = larguraTela/larguraImagem; // + 0.25f para nao risco em background scroller 
		novaEscala.y = alturaTela/alturaImagem;
		this.transform.localScale = novaEscala;
	}
}