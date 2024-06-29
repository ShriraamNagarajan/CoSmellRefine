(function () {
    const sidebar = document.querySelector(".sidebar");
    const menu = document.querySelector("#menu");

    const main = document.querySelector(".user-main");

    const menu_container = document.querySelector(".menu-container");
    const logout_container = document.querySelector(".logout-container");

    const icon_logout = document.querySelector(".icon-logout");


    const dashboard = document.querySelector("#dashboard");
    const question = document.querySelector("#question");
    const learn = document.querySelector("#learn");


    let previousToggled = null;
    let currentToggled = null;


    dashboard.addEventListener("click", (e) => {
        toggleMenu(dashboard);
    });

    question.addEventListener("click", (e) => {
        toggleMenu(dicussion);
    });

    learn.addEventListener("click", (e) => {
        toggleMenu(learn);
    });




    const toggleMenu = (button) => {
        if (previousToggled && button !== menu) {
            untoggleMenu(previousToggled);
        }

        button.classList.add("toggled");
        button.style.backgroundColor = "#FCFCAE";

        if (button !== menu) {
            previousToggled = button;
        }
    };

    const untoggleMenu = (button) => {
        button.classList.remove("toggled");
        button.style.backgroundColor = "#1FFFE86";
    };

    menu.addEventListener("click", (e) => {
        console.log("helo");
        sidebar.classList.contains("active") ? closeMenu() : openMenu();
    });

    const openMenu = () => {
        sidebar.classList.add("active");
        sidebar.style.width = "250px";

        toggleMenu(menu);

        let menu_logo = document.createElement("img");
        menu_logo.id = "menu-logo";
        menu_logo.src = "../images/logo.svg";
        menu_logo.style.width = "30px";
        menu_container.style.paddingLeft = "10px";
        menu_container.insertBefore(menu_logo, menu_container.childNodes[0]);


        let p_dash = document.createElement("p");
        p_dash.id = "p-dashboard";
        p_dash.innerHTML = "Dashboard";
        dashboard.style.width = "220px";
        dashboard.style.justifyContent = "left";
        dashboard.appendChild(p_dash);

        let p_question = document.createElement("p");
        p_question.id = "p-question";
        p_question.innerHTML = "QnA";
        question.style.width = "220px";
        question.style.justifyContent = "left";
        question.appendChild(p_question);

        let p_learn = document.createElement("p");
        p_learn.id = "p-learn";
        p_learn.innerHTML = "Learn";
        learn.style.width = "220px";
        learn.style.justifyContent = "left";
        learn.appendChild(p_learn);



        icon_logout.style.width = "25%";

        let user_container = document.createElement("div");
        user_container.id = "user-container";

        let user_name = document.createElement("p");
        user_name.id = "user-name";
        user_name.innerHTML = "Logout";


        user_container.appendChild(user_name);
        logout_container.insertBefore(user_container, logout_container.childNodes[0]);


        logout_container.style.paddingLeft = "10px";

        main.style.width = "calc(100% - 250px)";
    };

    const closeMenu = () => {
        menu_container.removeChild(document.getElementById("menu-logo"));
        menu_container.style.paddingLeft = "0px";

        untoggleMenu(menu);

        dashboard.removeChild(document.getElementById("p-dashboard"));
        dashboard.style.width = "50px";
        dashboard.style.justifyContent = "center";

        question.removeChild(document.getElementById("p-question"));
        question.style.width = "50px";
        question.style.justifyContent = "center";

        learn.removeChild(document.getElementById("p-learn"));
        learn.style.width = "50px";
        learn.style.justifyContent = "center";

        logout_container.removeChild(document.getElementById("user-container"));
        logout_container.style.paddingLeft = "0px";

        icon_logout.style.width = "100%";

        sidebar.classList.remove("active");
        sidebar.style.width = "78px";

        main.style.width = "calc(100% - 78px)";
    };


})();

