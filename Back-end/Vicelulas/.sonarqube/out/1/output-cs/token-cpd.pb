�
pC:\Users\lcontesini\Documents\GitHub\vicelulas\Back-end\Vicelulas\Vicelulas.Dado\Abstração\IRepositorioBase.cs
	namespace 	
	Vicelulas
 
. 
Dado 
. 
Abstração "
{ 
internal 
	interface 
IRepositorioBase '
<' (
T( )
>) *
where+ 0
T1 2
:3 4
class5 :
{ 
IEnumerable		 
<		 
T		 
>		 

Selecionar		 !
(		! "
)		" #
;		# $
T

 	
SelecionarPorId


 
(

 
int

 
id

  
)

  !
;

! "
int 
Inserir 
( 
T 
entity 
) 
; 
void 
Alterar 
( 
T 
entity 
) 
; 
void 
Deletar 
( 
int 
id 
) 
; 
} 
} �
vC:\Users\lcontesini\Documents\GitHub\vicelulas\Back-end\Vicelulas\Vicelulas.Dado\Configuração\DbConnectionFactory.cs
	namespace 	
	Vicelulas
 
. 
Dado 
. 
Configuração %
{ 
internal 
static 
class 
DbConnectionFactory -
{ 
public		 
static		 
string		 
SQLConnectionString		 0
=>		1 3
$str		4 v
;		v w
}

 
} 