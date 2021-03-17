# launchergcclassic
Launcher classic of GC in VB

<p align="center">
    <img alt="UpdaterGC" src="https://i.imgur.com/2pEa472.gif" width="740" height="700" />
</p>
<p>
<p align="left">
  	<img alt="PT-BR" src="https://i.imgur.com/3fl9Sfi.gif" width="30" height="20"/>
</p>

## Conteúdo

Esse projeto contém o launcher-main do Grand Chase, na versão clássica original, reconstruído em VB .NET, utilizando Engenharia Reversa e contents como screenshots da comunidade na época que o game ainda existia. Esse starter é mais conclusivo que o anterior, pois como rotina ele verifica se o user possui conexão com a internet no form `Splash`, e cria um arquivo `checklist.txt` para verificar a integridade dos arquivos no PATH onde o game está situado, ou seja, a pasta corrente (ou raiz), antes de iniciar o game de fato.

*"Esse projeto contém o trunfo de ouro do Grand Chase em sua raiz primitiva, o starter mais bonito entre os forks do Grand Chase após sua queda, na minha opnião, simples, limpo, sem instruções que geram alocação de memória desnecessária ou registros acumulados com o tempo, ideal para cpus's low-end."*

## Mergulho no código

- Foi desenvolvido em `VBasic/.NET` para rodar nas versões mais simples de `.NET Framework`, 
mantendo assim a transparência entre os sistemas operacionais.
- O código está brevemente comentado, só explicitando a lógica pensada por mim, sendo mais literal para amadores.
- Uma build-essential simples, o programa executa testes proativos e consistentes, sendo assim mantendo um tamanho executável enxuto, carregando consigo 2 forms simples (`Splash` & `Launcher`).
- Basicamente como a maioria das operações são feitas com arquivos, é imprescindível o uso de artificios como Try-Catch.
- A ideia sobre integridade, é que o arquivo `checklist.txt` é criado na primeira execução do programa. Nessa instrução é armazenado o caminho (PATH) de todos os arquivos que estão no diretório corrente, para que nas próximas execuções, a rotina do programa verifique se algum arquivo foi apagado.
- Essa integridade corresponde ao que diz respeiro aos arquivos necessários para o arranque do game em si, não necessariamente deve ser algum arquivo de procedência duvidosa, ou o próprio arquivo `checklist.txt`. 
- A cada rotina de execução é verificado se a `checklist.txt` foi criada, caso sim, basta fazer a leitura por linha e comparar com os arquivos realmente existem.
- O usuário pode editar a checklist como bem entender, mas deve saber que isto significa interferir na consistência do game como um todo, assim como editar o caminho de um arquivo na checklist ou o seu nome pode gerar um erro, deletar ou trocar o arquivo de diretório tambem pode. Mas isto significaria em ambos os casos, um erro intencional.
- A lógica poderia ser categórica, porém como dito anterior, erros intencionais causados por usuário, por uma fenda no programa, seria um erro de estratégia (engenharia de software). Entretando, o software é intencionalmente idealizado a isso, pois isso facilita a significativamente ao desenvolvedor mapear os erros potenciais que ocorriam e ainda ocorre em games com starter.

## Receita do componente

Sem segredos, apenas build-compile e instancie o executável na raiz do game, e sinta a nostalgia.

## Referências

- Exit & Minimize

*Esses botões foram criados do mesmo vetor das assets da season 5 do game, são as mesmas ao lado do `V`, e os dois botões possuem listeiners mouseover, mouseout e mouseclick, feitos com muito carinho assim como todo o projeto.*

- Carousel-Slider like a boss

*Usando o timer do VB, nunca foi tão fácil imitar o efeito do original ou até mesmo da web, possuindo persistência mesmo apos o click nos índices, com uma lógica simples e de fácil modificação nos sliders.*

<p align="left">
  	<img alt="EN-US" src="https://i.imgur.com/QqtGoQ4.gif" width="30" height="20" />
</p>

## Content

This project contains the Grand Chase launcher-main, in the original classic version, rebuilt in VB .NET, using Reverse Engineering and contents as screenshots of the community at the time the game still existed. This starter is more conclusive than the previous one, because as a routine it checks if the user has internet connection in the form `Splash`, and creates a file `checklist.txt` to check the integrity of the files in the PATH where the game is located , that is, the current folder (or root), before actually starting the game.

*"This project contains the golden asset of the Grand Chase in its primitive root, the most beautiful starter among the Grand Chase forks after its fall, in my opinion, simple, clean, without instructions that generate unnecessary memory allocation or accumulated records over time, ideal for low-end CPUs."*

## Dive into the code

- It was developed in `VBasic/.NET` to run in the simplest versions of `.NET Framework`,
thus maintaining transparency between operating systems.
- The code is briefly commented, just explaining the logic thought by me, being more literal for amateurs.
- A simple build-essential, the program performs proactive and consistent tests, thus maintaining a lean executable size, carrying 2 simple forms (`Splash` & `Launcher`).
- Basically as most operations are done with files, it is essential to use devices such as Try-Catch.
- The idea about integrity, is that the file `checklist.txt` is created in the first execution of the program. In this instruction, the path (PATH) of all files that are in the current directory is stored, so that in the next executions, the program routine checks if any files have been deleted.
- This integrity corresponds to what is said about the files needed to start the game itself, it should not necessarily be a file of doubtful origin, or the `checklist.txt` file itself.
- At each execution routine, it is checked whether the `checklist.txt` was created, if so, just read it per line and compare it with the files that actually exist.
- The user can edit the checklist as he sees fit, but he must know that this means interfering with the consistency of the game as a whole, as well as editing the path of a file in the checklist or its name can generate an error, delete or change the file directory can also. But this would mean in both cases, an intentional error.
- The logic could be categorical, but as stated above, intentional errors caused by the user, by a crack in the program, would be a strategy error (software engineering). However, the software is intentionally designed for this, as it significantly facilitates the developer to map the potential errors that occurred and still occurs in games with starter.

## Component revenue

No secrets, just build-compile and instantiate the executable at the root of the game, and feel the nostalgia.

## References

- Exit & Minimize

*These buttons were created from the same vector as the assets of season 5 of the game, they are the same next to the `V`, and the two buttons have mouseover, mouseout and mouseclick listeiners, made with great care as well as the whole project.*

- Carousel-Slider like a boss

*Using the VB timer, it has never been easier to imitate the effect of the original or even the web, having persistence even after clicking on the indexes, with a simple logic and easy modification on the sliders.*