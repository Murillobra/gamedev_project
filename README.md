🎮 Game Design Document (GDD) - Dungeon Fighter


📌 Visão Geral do Jogo
•	Descrição Temática: Dungeon Fighter é um RPG de plataforma 2D ambientado em um mundo sombrio e cheio de perigos. O jogador assume o papel de Lyra, uma guerreira destemida que precisa atravessar masmorras traiçoeiras, derrotar inimigos cruéis e evitar armadilhas mortais para cumprir sua missão.
•	Objetivo Geral: O jogador deve guiar Lyra através de três fases repletas de desafios, derrotando inimigos e superando obstáculos para alcançar o final de cada fase.
•	Progresso: Cada fase aumenta gradualmente em dificuldade, introduzindo novos tipos de inimigos e desafios ambientais.
________________________________________
🛠️ Mecânicas de Jogo
•	Movimentação:
o	Andar: Movimenta-se horizontalmente. Setas direita e esquerda do teclado.
o	Correr: Acelera para superar obstáculos.
o	Pular: Permite acessar plataformas mais altas. Botão de espaço do teclado.
•	Sistema de Coleta:
o	Itens de cura, ou seja, vidas que se acumulam e são transferidas junto com o Player ao passar de fase.
•	Sistema de Combate:
o	Ataques corpo a corpo com espada.
o	Animação de ataque específica para a ação.
________________________________________
🗺️ Design de Níveis
Fase 1 - Ruínas Esquecidas:
•	Introdução às mecânicas básicas (andar, pular, correr).
•	Inimigos básicos e armadilhas simples (espinhos).
•	Plataformas estáticas.
Fase 2 - Abismo Sombrio:
•	Adiciona abismos perigosos e mais desafios combinando inimigos com espinhos.
•	Maior ênfase em reflexos rápidos e precisão nos saltos.
Fase 3 - Fortaleza Final:
•	Combinação de todos os desafios anteriores.
•	Inimigos mais numerosos e com habilidades especiais.
•	Armadilhas complexas.
Aumento de Dificuldade: Cada fase introduz novos elementos para desafiar a habilidade do jogador, como armadilhas mais complexas e inimigos mais agressivos.
________________________________________
🦸‍♀️ Personagens e Inimigos
•	Protagonista:
o	Nome: Lyra
o	Habilidades: Andar, correr, pular, ataque corpo a corpo.
o	Características: Determinada, corajosa e habilidosa com a espada.
•	Inimigos:
o	Esqueleto Patrulheiro: Anda em padrões fixos e ataca quando Lyra se aproxima.
o	Espinhos: Possuem animação de descer e subir, com tempo determinado para que Lyra possa passar por eles sem levar dano.
________________________________________
🎨 Arte e Áudio
•	Estilo Visual: Pixel art detalhado com paleta de cores sombrias e acentuadas. ________________________________________
________________________________________
📑 Relatório Técnico - Dungeon Fighter
Fluxo de Jogo:
1.	Menu Principal:
o	Opções: Start Game, Controls, Exit.
2.	Gameplay:
o	Fases interconectadas com checkpoints.
o	Tela de Pause com opções: Resume Game e Back to Menu.
3.	Game Over:
o	Tela exibida quando o jogador morre (queda no abismo ou sem vida). Possui como opções: Restart e Back to Menu.
________________________________________
Plano de Testes:
•	Testes de Mecânicas:
o	Testar comportamento do pulo e precisão em plataformas.
o	Verificar a funcionalidade da ação de andar/correr.
•	Testes de IA:
o	Checar padrões de patrulha dos inimigos.
o	Validar resposta de ataque dos inimigos à aproximação do jogador.
•	Testes de Checkpoints:
o	Garantir que o jogador respawna corretamente após morrer.
•	Testes de UI:
o	Validar funcionamento dos botões (Restart, Resume Game, Back to Menu).
