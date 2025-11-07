Este é um projeto de estudo em .NET MAUI desenvolvido para o curso Técnico em Desenvolvimento de Sistemas (ETEC), com base no "AppHotel" das Agendas 13 e 14 de Programação Mobile.

O aplicativo original foi totalmente personalizado para refletir um tema "Halloween", incluindo um novo esquema de cores, uma nova página "Sobre" e elementos de design personalizados.

✨ Minhas Personalizações 🎃

Enquanto o projeto base focava na lógica, as seguintes alterações foram implementadas para demonstrar a personalização da interface:

Tema Halloween: Todo o esquema de cores (Colors.xaml) e estilos (Styles.xaml) foi alterado para usar uma paleta de Laranja Neon, Preto, Roxo e Cinza Escuro.

Página "Sobre" Personalizada: Uma nova tela (Sobre.xaml) foi criada de raiz, contendo:

Uma imagem de um castelo (adicionada localmente em Resources/Images/).

Um título neon ("CASTELO DA NADJAN") usando efeitos de Sombra (Shadow).

Um slogan personalizado ("Onde seus monstros podem ser livres").

Informações do desenvolvedor.

Correção de Navegação: A lógica de navegação foi ajustada para usar Navigation.PushAsync(new Sobre()) em vez de Shell.Current para contornar um erro NullReferenceException, garantindo que o app funcione sem um AppShell complexo.

N Foco da Atividade (Agendas 13 & 14)

Este projeto aplica os conceitos fundamentais de .NET MAUI e POO, incluindo:

Programação Orientada a Objetos (POO): Criação de classes Hospedagem e Quarto para modelar os dados.

Componentes de UI (XAML):

DatePicker: Para seleção de datas de Check-in e Check-out (com validação).

Picker: Para carregar a lista de suítes (Quartos) a partir de uma List<T>.

Stepper: Para selecionar a quantidade de adultos e crianças.

Frame e VerticalStackLayout: Para organizar o layout.

BindingContext: Para enviar o objeto Hospedagem da tela de contratação para a tela de resumo.

Navegação: Uso de Navigation.PushAsync() e PopToRootAsync() para controlar o fluxo das telas.

Projeto base por: Prof. Tiago Antonio da Silva (ETEC)
Personalização e implementação por: Nadjan S.F.