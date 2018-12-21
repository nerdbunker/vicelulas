�
{C:\Users\lcontesini\Documents\GitHub\vicelulas\Back-end\Vicelulas\Viceluas.Dominio\Configurações\VicelulasConfiguracao.cs
	namespace 	
Viceluas
 
. 
Dominio 
. 
Configurações (
{ 
public 

class !
VicelulasConfiguracao &
{ 
public		 
string		 
Conexao		 
{		 
get		  #
;		# $
set		% (
;		( )
}		* +
}

 
} �
bC:\Users\lcontesini\Documents\GitHub\vicelulas\Back-end\Vicelulas\Viceluas.Dominio\Dto\TriboDto.cs
	namespace 	
Viceluas
 
. 
Dominio 
. 
Dto 
{ 
public 

class 
TriboDto 
{ 
public		 
int		 
Id		 
{		 
get		 
;		 
set		  
;		  !
}		" #
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
} �
rC:\Users\lcontesini\Documents\GitHub\vicelulas\Back-end\Vicelulas\Viceluas.Dominio\Exceções\ConflitoException.cs
	namespace 	
Viceluas
 
. 
Dominio 
. 

Exceções #
{ 
[ 
Serializable 
] 
public 

class 
ConflitoException "
:# $
	Exception% .
{		 
public

 
ConflitoException

  
(

  !
)

! "
{ 	
} 	
public 
ConflitoException  
(  !
int! $
id% '
)' (
{ 	
} 	
public 
ConflitoException  
(  !
string! '
message( /
)/ 0
:1 2
base3 7
(7 8
message8 ?
)? @
{ 	
} 	
} 
} �
wC:\Users\lcontesini\Documents\GitHub\vicelulas\Back-end\Vicelulas\Viceluas.Dominio\Exceções\NaoEncontradoException.cs
	namespace 	
Viceluas
 
. 
Dominio 
. 

Exceções #
{ 
[ 
Serializable 
] 
public 

class "
NaoEncontradoException '
:( )
	Exception* 3
{		 
public

 "
NaoEncontradoException

 %
(

% &
)

& '
{ 	
} 	
public "
NaoEncontradoException %
(% &
int& )
id* ,
), -
{ 	
} 	
public "
NaoEncontradoException %
(% &
string& ,
message- 4
)4 5
:6 7
base8 <
(< =
message= D
)D E
{ 	
} 	
} 
} �
rC:\Users\lcontesini\Documents\GitHub\vicelulas\Back-end\Vicelulas\Viceluas.Dominio\Exceções\RecusadoException.cs
	namespace 	
Viceluas
 
. 
Dominio 
. 

Exceções #
{ 
[ 
Serializable 
] 
public 

class 
RecusadoException "
:# $
	Exception% .
{		 
public

 
RecusadoException

  
(

  !
)

! "
{ 	
} 	
public 
RecusadoException  
(  !
int! $
id% '
)' (
{ 	
} 	
public 
RecusadoException  
(  !
string! '
message( /
)/ 0
:1 2
base3 7
(7 8
message8 ?
)? @
{ 	
} 	
} 
} �
[C:\Users\lcontesini\Documents\GitHub\vicelulas\Back-end\Vicelulas\Viceluas.Dominio\Tribo.cs
	namespace 	
Viceluas
 
. 
Dominio 
{ 
public 

class 
Tribo 
{ 
public		 
int		 
Id		 
{		 
get		 
;		 
set		  
;		  !
}		" #
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
} 