# Jaguatibaia — Uma semente muda tudo
Landing page acadêmica **de uma única tela, sem rolagem**, desenvolvida em ASP.NET Core MVC (.NET 8), C#, Razor, HTML5, CSS3 e JavaScript com GSAP.

## Executar no Visual Studio 2022
1. Instale o **Visual Studio 2022** com a carga **Desenvolvimento ASP.NET e Web** e o **SDK .NET 8**.
2. Extraia o ZIP.
3. No Visual Studio: **Arquivo > Abrir > Projeto/Solução**, selecione `JaguatibaiaLanding.csproj`.
4. Pressione **Ctrl+F5** (sem depuração) ou **F5**.
5. Se preferir terminal: `dotnet run` na pasta do projeto; abra o endereço localhost exibido.

## O que demonstrar
- `Program.cs`: inicializa a aplicação e configura rotas e arquivos estáticos.
- `Controllers/HomeController.cs`: recebe a requisição e entrega o modelo à View.
- `Models/LandingViewModel.cs`: armazena nome, fundação e URL oficial.
- `Views/Home/Index.cshtml`: página Razor com HTML semântico e botão acessível.
- `wwwroot/css/site.css`: layout 100dvh, cena vetorial, semente e flor animadas por CSS.
- `wwwroot/js/site.js`: animação inicial via GSAP, clique, germinação e redirecionamento.

## Interação
O visitante clica na semente. A semente desaparece, o caule cresce, folhas aparecem, pétalas abrem. Após ~3,1 s, o navegador redireciona para `https://jaguatibaia.org.br/`. O link também aparece no cabeçalho.

## Observações
- A arte é vetorial (CSS + SVG) e não usa imagens externas.
- A biblioteca GSAP e as fontes são carregadas por CDN, exigindo internet para esses recursos. O botão e a flor funcionam sem GSAP.
- A página é um **projeto acadêmico independente**, não o site oficial da ONG.
- O enunciado PIM fornecido exige outras seções (galeria, contato, indicadores etc.). Esta versão de uma tela segue o pedido específico, mas **não cumpre integralmente o checklist do PIM**.
- Teste em Chrome/Edge e em diferentes resoluções. Se a altura da janela for muito pequena, conteúdo pode ficar comprimido porque a rolagem está desativada.
