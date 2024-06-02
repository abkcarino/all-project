const formOpenBtn = document.querySelector("#form-open"),
  home = document.querySelector(".home"),
  formContainer = document.querySelector(".form_container"),
  formCloseBtn = document.querySelector(".form_close"),
  signupBtn = document.querySelector("#signup"),
  loginBtn = document.querySelector("#login"),
  pwShowHide = document.querySelectorAll(".pw_hide");

formOpenBtn.addEventListener("click", () => home.classList.add("show"));
formCloseBtn.addEventListener("click", () => home.classList.remove("show"));

pwShowHide.forEach((icon) => {
  icon.addEventListener("click", () => {
    let getPwInput = icon.parentElement.querySelector("input");
    if (getPwInput.type === "password") {
      getPwInput.type = "text";
      icon.classList.replace("uil-eye-slash", "uil-eye");
    } else {
      getPwInput.type = "password";
      icon.classList.replace("uil-eye", "uil-eye-slash");
    }
  });
});

signupBtn.addEventListener("click", (e) => {
  e.preventDefault();
  formContainer.classList.add("active");
});
loginBtn.addEventListener("click", (e) => {
  e.preventDefault();
  formContainer.classList.remove("active");
});
function checkEmail() {
  var emailInput = document.getElementById("email");


  if (emailInput.value.includes("@")) {
    console.log("L'email est valide.");

  } else {
    console.log("L'email est invalide.");

  }

}
function checkPassword() {
  var passwordInput = document.getElementById("password"); // Récupère l'élément <input> par son ID

  var containsNumber = /\d/g; // Vérifie la présence d'au moins un chiffre
  var containsLetter = /[a-zA-Z]/g;
  var containsSpecialChar = /[!@#$%^&*()\-_=+{};:,<.>]/g // Vérifie la présence d'au moins un caractère spécial

  if (passwordInput.ariaValueMax.match(containsLetter)) {
    console.log("Le mot de passe est valide.");
    // Ajoute ici le code que tu souhaites exécuter lorsque le mot de passe est valide
  } else {
    console.log("Le mot de passe est invalide.");
    // Ajoute ici le code que tu souhaites exécuter lorsque le mot de passe est invalide
  }
}


