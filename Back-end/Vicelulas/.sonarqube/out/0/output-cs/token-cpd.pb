�
yC:\Users\lcontesini\Documents\GitHub\vicelulas\Back-end\Vicelulas\Viceluas.Dominio\Configuracoes\VicelulasConfiguracao.cs
	namespace 	
Viceluas
 
. 
Dominio 
. 
Configurações (
{ 
public 

class !
VicelulasConfiguracao &
{ 
public 
string 
Conexao 
{ 
get  #
;# $
set% (
;( )
}* +
} 
} �
cC:\Users\lcontesini\Documents\GitHub\vicelulas\Back-end\Vicelulas\Viceluas.Dominio\Dto\PessoaDto.cs
	namespace 	
	Vicelulas
 
. 
Dominio 
. 
Dto 
{ 
public 

class 
	PessoaDto 
{ 
public 
int 
Id 
{ 
get 
; 
set  
;  !
}" #
public 
int 
Id_Papel 
{ 
get !
;! "
set# &
;& '
}( )
public

 
string

 
Nome

 
{

 
get

  
;

  !
set

" %
;

% &
}

' (
public 
string 
Email 
{ 
get !
;! "
set# &
;& '
}( )
public 
string 
Cargo 
{ 
get !
;! "
set# &
;& '
}( )
public 
Boolean 
Ativo 
{ 
get "
;" #
set$ '
;' (
}) *
public 
int 
	Id_Squads 
{ 
get "
;" #
set$ '
;' (
}) *
public 
int 

Id_Unidade 
{ 
get  #
;# $
set% (
;( )
}* +
public 
int 
Permisao 
{ 
get !
;! "
set# &
;& '
}( )
} 
} �
bC:\Users\lcontesini\Documents\GitHub\vicelulas\Back-end\Vicelulas\Viceluas.Dominio\Dto\SquadDto.cs
	namespace 	
Viceluas
 
. 
Dominio 
. 
Dto 
{ 
public 

class 
SquadDto 
{ 
public 
int 
Id 
{ 
get 
; 
set  
;  !
}" #
public 
int 
Id_Tribo 
{ 
get !
;! "
set# &
;& '
}( )
public		 
string		 
Nome		 
{		 
get		  
;		  !
set		" %
;		% &
}		' (
public

 
string

 
	NomeTribo

 
{

  !
get

" %
;

% &
set

' *
;

* +
}

, -
public 
Boolean 
Ativo 
{ 
get "
;" #
set$ '
;' (
}) *
} 
} �
bC:\Users\lcontesini\Documents\GitHub\vicelulas\Back-end\Vicelulas\Viceluas.Dominio\Dto\TriboDto.cs
	namespace 	
Viceluas
 
. 
Dominio 
. 
Dto 
{ 
public 

class 
TriboDto 
{ 
public 
int 
Id 
{ 
get 
; 
set  
;  !
}" #
public 
string 
Nome 
{ 
get  
;  !
set" %
;% &
}' (
public		 
Boolean		 
Ativo		 
{		 
get		 "
;		" #
set		$ '
;		' (
}		) *
}

 
} �
pC:\Users\lcontesini\Documents\GitHub\vicelulas\Back-end\Vicelulas\Viceluas.Dominio\Excecoes\ConflitoException.cs
	namespace 	
Viceluas
 
. 
Dominio 
. 

Exceções #
{ 
[ 
Serializable 
] 
public 

class 
ConflitoException "
:# $
	Exception% .
{ 
public 
ConflitoException  
(  !
)! "
{		 	
}

 	
public 
ConflitoException  
(  !
int! $
id% '
)' (
{ 	
} 	
public 
ConflitoException  
(  !
string! '
message( /
)/ 0
:1 2
base3 7
(7 8
message8 ?
)? @
{ 	
} 	
} 
} �
uC:\Users\lcontesini\Documents\GitHub\vicelulas\Back-end\Vicelulas\Viceluas.Dominio\Excecoes\NaoEncontradoException.cs
	namespace 	
Viceluas
 
. 
Dominio 
. 

Exceções #
{ 
[ 
Serializable 
] 
public 

class "
NaoEncontradoException '
:( )
	Exception* 3
{ 
public "
NaoEncontradoException %
(% &
)& '
{		 	
}

 	
public "
NaoEncontradoException %
(% &
int& )
id* ,
), -
{ 	
} 	
public "
NaoEncontradoException %
(% &
string& ,
message- 4
)4 5
:6 7
base8 <
(< =
message= D
)D E
{ 	
} 	
} 
} �
pC:\Users\lcontesini\Documents\GitHub\vicelulas\Back-end\Vicelulas\Viceluas.Dominio\Excecoes\RecusadoException.cs
	namespace 	
Viceluas
 
. 
Dominio 
. 

Exceções #
{ 
[ 
Serializable 
] 
public 

class 
RecusadoException "
:# $
	Exception% .
{ 
public 
RecusadoException  
(  !
)! "
{		 	
}

 	
public 
RecusadoException  
(  !
int! $
id% '
)' (
{ 	
} 	
public 
RecusadoException  
(  !
string! '
message( /
)/ 0
:1 2
base3 7
(7 8
message8 ?
)? @
{ 	
} 	
} 
} 