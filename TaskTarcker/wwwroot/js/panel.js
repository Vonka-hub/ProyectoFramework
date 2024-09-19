const body = document.querySelector("body"),
  sidebar = body.querySelector("nav"),
  toggle = body.querySelector(".toggle"),
  buscadorBtn = body.querySelector(".buscador"),
  modoDelSwitch = body.querySelector(".toggle-switch"),
  modoDelText = body.querySelector(".mode-text");

toggle.addEventListener("click", () => {
  sidebar.classList.toggle("close");
});

buscadorBtn.addEventListener("click", () => {
  sidebar.classList.remove("close");
});

modoDelSwitch.addEventListener("click", () => {
  body.classList.toggle("dark");

  if (body.classList.contains("dark")) {
    modoDelText.innerText = "Modo oscuro";
  } else {
    modoDelText.innerText = "Modo claro";
  }
});


