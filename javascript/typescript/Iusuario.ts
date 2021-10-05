interface IUsuario {
    id: string;
    email: string;
}

interface IAdmin extends IUsuario {
    cargo: 'gerente' | 'coordenador' | 'supervisor';
}

function redirecione(usuario: IUsuario | IAdmin){
    if ('cargo' in usuario) {

    }
}


interface IUsuario {
    id: string;
    email: string;
    cargo?: 'gerente' | 'coordenador' | 'supervisor' | 'funcionario';
}

function redireciona(usuario: IUsuario){
    if (usuario.cargo) {
        //redireciona(usuario.cargo)
    }
    //redireciona area do usuario
}
