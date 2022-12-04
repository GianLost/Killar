function ValidateFormUserRegister() {
  var Name = formuser.Name.value;
  var BirthDate = formuser.BirthDate.value;
  var LoginWr = formuser.LoginWr.value;
  var LoginName = formuser.LoginName.value;
  var Password = formuser.Password.value;
  var CheckedPassword = formuser.CheckedPassword.value;
  var Lane = formuser.Lane.value;
  var Elo = formuser.Elo.value;
  var Tipo = formuser.Tipo.value;

  if (Name == "") {
    alert("O campo Nome é obrigatório");
    formuser.Name.focus();
    return false;
  }

  if (BirthDate == "") {
    alert("O campo Data é obrigatório");
    formuser.BirthDate.focus();
    return false;
  }

  if (LoginWr == "") {
    alert("O campo LoginWr é obrigatório");
    formuser.LoginWr.focus();
    return false;
  }

  if (LoginName == "") {
    alert("O campo LoginName é obrigatório");
    formuser.LoginName.focus();
    return false;
  }

  if (Password == "") {
    alert("O campo Password é obrigatório");
    formuser.Password.focus();
    return false;
  }

  if (CheckedPassword == "") {
    alert("O campo Repetir Senha é obrigatório");
    formuser.CheckedPassword.focus();
    return false;
  }

  if (Password == "" || Password.length <= 5) {
    alert("Preencha o campo de senha com no minimo 6 caracteres");
    formuser.Password.focus();
    return false;
  }

  if (CheckedPassword != Password || CheckedPassword.length <= 5) {
    alert("As senhas são diferentes");
    formuser.CheckedPassword.focus();
    return false;
  }

  if (Lane == "") {
    alert("O campo Lane é obrigatório");
    formuser.Lane.focus();
    return false;
  }

  if (Elo == "") {
    alert("O campo Elo é obrigatório");
    formuser.Elo.focus();
    return false;
  }

  if (Tipo == "") {
    alert("O campo Tipo é obrigatório");
    formuser.Tipo.focus();
    return false;
  } else {
    alert("Cadastro realizado com Sucesso!");
  }
}
